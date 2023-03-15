using System;
using System.Data.SqlClient;

namespace PA.DataEntity.Codes
{
    public class DataBaseInstance
    {
        public event EventHandler Connecting = null;
        public event EventHandler Opened = null;
        public event EventHandler Closed = null;
        public event EventHandler Broken = null;
        public event EventHandler DataTransmitted = null;

        private bool initialized = false;
        private SqlConnection sqlConn;
        public DataBaseInstance(string cs)
        {
            ConnectionString = cs;
            sqlConn = new SqlConnection(ConnectionString);
            Initialize();
        }

        public string ConnectionString { get; }

        public SqlConnection Connection
        {
            get
            {
                return sqlConn;
            }
        }

        private void Initialize()
        {
            sqlConn.Disposed += SqlConn_Disposed;
            sqlConn.InfoMessage += SqlConn_InfoMessage;
            sqlConn.StateChange += SqlConn_StateChange;
        }

        private void SqlConn_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            switch (e.CurrentState)
            {
                case System.Data.ConnectionState.Broken:
                    Broken?.Invoke(sender, EventArgs.Empty);
                    break;
                case System.Data.ConnectionState.Closed:
                    Closed?.Invoke(sender, EventArgs.Empty);
                    break;
                case System.Data.ConnectionState.Connecting:
                    Connecting?.Invoke(sender, EventArgs.Empty);
                    break;
                case System.Data.ConnectionState.Executing:
                case System.Data.ConnectionState.Fetching:
                    DataTransmitted?.Invoke(sender, EventArgs.Empty);
                    break;
                case System.Data.ConnectionState.Open:
                    Opened?.Invoke(sender, EventArgs.Empty);
                    break;
            }
        }

        private void SqlConn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {

        }

        private void SqlConn_Disposed(object sender, EventArgs e)
        {

        }
    }
}
