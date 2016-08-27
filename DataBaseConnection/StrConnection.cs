using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseConnection
{
    public static class StrConnection
    {
        //TODO Dejar esto como estaba
        private static string userID = "root";
        private static string password = "Sur.5947/*-";
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
            return @"Server=" + Host + ";Database=criadero;Uid=" + UserID +";Pwd=" + Password + "";
        }
    }
}
