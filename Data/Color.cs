using DataBaseConnection;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Data
{
    public static class Color
    {
        public static void insert(Entity.Color pColor)
        {
            //Query
            string mySqlQuery = "INSERT INTO Colors VALUES (null, @description)";

            MySqlCommand mySqlCommand = new MySqlCommand(mySqlQuery, MainConnection.GetConnection());
            mySqlCommand.Parameters.AddWithValue("description", pColor.Description);

            try
            {
                MainConnection.ConnectAndExecute(mySqlCommand);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable getColors()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM Colors";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, StrConnection.GetStringConnection());
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
