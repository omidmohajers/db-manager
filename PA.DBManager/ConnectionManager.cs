using PA.DataEntity.Codes;
using System;

namespace PA.DBManager
{
    public static class ConnectionManager
    {
        public static bool Retry(Exception ex)
        {
            return false;
        }

        public static void Start(DataBaseInstance instance)
        {
            instance.Broken += Instance_Broken;
            instance.Closed += Instance_Closed;
            instance.Connecting += Instance_Connecting;
            instance.DataTransmitted += Instance_DataTransmitted;
            instance.Opened += Instance_Opened;
        }

        private static void Instance_Opened(object sender, EventArgs e)
        {

        }

        private static void Instance_DataTransmitted(object sender, EventArgs e)
        {

        }

        private static void Instance_Connecting(object sender, EventArgs e)
        {

        }

        private static void Instance_Closed(object sender, EventArgs e)
        {

        }

        private static void Instance_Broken(object sender, EventArgs e)
        {

        }
    }
}
