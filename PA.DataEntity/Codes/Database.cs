namespace PA.DataEntity.Codes
{
    public static class Database
    {
        private static string password = null;
        private static string dbPath = null;
        public static string MainConnectionString
        {
            get
            {
                string con = System.Configuration.ConfigurationManager.ConnectionStrings["eMainDBEntities"].ConnectionString;

                return SetConnection(con);

            }
        }

        private static string SetConnection(string con)
        {
            //if (string.IsNullOrEmpty(password))
            //    password = Activation.getDBPassword();
            //con = string.Format(con, Application.StartupPath);
            //if (string.IsNullOrEmpty(dbPath))
            //dbPath = String.Format("{0}\\Data\\eOfficeDB"/*; Password ={1}"*/, Application.StartupPath/*, password*/) + ";";
            //string dbType = System.Configuration.ConfigurationManager.AppSettings["DbType"].ToString();
            //switch (dbType.ToLower())
            //{
            //    case "sqlite":
            //        con = string.Format(con, SystemManager.StartUpPath);
            //        break;
            //    case "mssql":
            //        con = string.Format(con, SystemManager.StartUpPath);
            //        break;
            //}
            return con;
        }

        public static string ExceptionConnectionString
        {
            get
            {
                string con = System.Configuration.ConfigurationManager.ConnectionStrings["eExceptionDBEntities"].ConnectionString;
                return SetConnection(con);
            }
        }

        public static string SmsConnectionString
        {
            get
            {
                string con = System.Configuration.ConfigurationManager.ConnectionStrings["eSmsDBEntities"].ConnectionString;
                return SetConnection(con);
            }
        }

        public static string UserConnectionString
        {
            get
            {
                string con = System.Configuration.ConfigurationManager.ConnectionStrings["eUserDatabase"].ConnectionString;
                return SetConnection(con);
            }
        }

        public static string CalendarConnectionString
        {
            get
            {
                string con = System.Configuration.ConfigurationManager.ConnectionStrings["eContactDBEntities"].ConnectionString;
                return SetConnection(con);
            }
        }

        public static string ContactsConnectionString
        {
            get
            {
                string con = System.Configuration.ConfigurationManager.ConnectionStrings["eContactsDBEntities"].ConnectionString;
                return SetConnection(con);
            }
        }

        public static string eMailConnectionString
        {
            get
            {
                string con = System.Configuration.ConfigurationManager.ConnectionStrings["eMailDB"].ConnectionString;
                return SetConnection(con);
            }
        }

        public static string DoctorOfficeConnectionString
        {
            get
            {
                string con = System.Configuration.ConfigurationManager.ConnectionStrings["eDoctorOfficeContainer"].ConnectionString;
                return SetConnection(con);
            }
        }

        public static string AccountingConnectionString
        {
            get
            {
                string con = System.Configuration.ConfigurationManager.ConnectionStrings["AccountingDBEnt"].ConnectionString;
                return SetConnection(con);
            }
        }
        public static string JahadConnectionString
        {
            get
            {
                string con = System.Configuration.ConfigurationManager.ConnectionStrings["JahadDBEnt"].ConnectionString;
                return SetConnection(con);
            }
        }

        public static string GomrocConnectionString
        {
            get
            {
                string con = System.Configuration.ConfigurationManager.ConnectionStrings["GomrocDBEnt"].ConnectionString;
                return SetConnection(con);
            }
        }

        public static string WarehouseConnectionString
        {
            get
            {
                string con = System.Configuration.ConfigurationManager.ConnectionStrings["wareHouseDBEntities"].ConnectionString;
                return SetConnection(con);
            }
        }

        public static void AddConnectionString(string dbName, string connectionName)
        {
            System.Configuration.ConnectionStringSettings css = new System.Configuration.ConnectionStringSettings()
            {
                Name = connectionName,
                ConnectionString = MainConnectionString.Replace("PublicDB", dbName)
            };

            System.Configuration.ConfigurationManager.ConnectionStrings.Add(css);
        }
    }
}
