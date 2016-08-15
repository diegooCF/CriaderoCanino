using MySql.Data.MySqlClient;
using System;

namespace DataBaseConnection
{
    public static class MainConnection
    {
        private static MySqlConnection mySqlConnection = new MySqlConnection(StrConnection.GetStringConnection());

        private static void UpdateConnection()
        {
            CloseConnection();
            mySqlConnection = new MySqlConnection(StrConnection.GetStringConnection());
        }
        public static MySqlConnection GetConnection()
        {
            return mySqlConnection;
        }
        public static bool CheckIfOpen()
        {
            if (mySqlConnection.State == System.Data.ConnectionState.Open)
                return true;
            else
                return false;
        }
        public static void OpenConnection()
        {
            try
            {
                if (mySqlConnection.State == System.Data.ConnectionState.Closed)
                {
                    UpdateConnection();
                    mySqlConnection.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void CloseConnection()
        {
            try
            {
                if(mySqlConnection.State != System.Data.ConnectionState.Closed)
                    mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void ConnectAndExecute(MySqlCommand mySqlCommand)
        {
            try
            {
                GetConnection().Open();
                mySqlCommand.ExecuteNonQuery();
                GetConnection().Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
