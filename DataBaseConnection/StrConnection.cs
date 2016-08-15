using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseConnection
{
    public static class StrConnection
    {
        private static string userID;
        private static string password;
        private static string host = "localhost";

        public static string UserID
        {
            get
            {
                return userID;
            }

            set
            {
                userID = value;
            }
        }       
        public static string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
        public static string Host
        {
            get
            {
                return host;
            }

            set
            {
                host = value;
            }
        }

        public static string GetStringConnection()
        {
            return @"Server=" + Host + ";Database=Criadero;Uid=" + UserID +";Pwd=" + Password + "";
        }
    }
}
