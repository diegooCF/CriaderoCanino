using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace Data
{
    public static class Specie
    {
        //String connection
        private static string strConnection = @"Server=localhost;Database=Criadero;Uid=admin;Pwd=msfsxs";

        public static void insert(Entity.Specie pSpecie)
        {
            //We create a connection to the Database
            MySqlConnection mySqlConnection = new MySqlConnection(strConnection);

            //Insert statement
            string strQuery = "INSERT INTO Species VALUES (null, @description)";

            MySqlCommand mySqlCommand = new MySqlCommand(strQuery, mySqlConnection);

            //Parameters
            mySqlCommand.Parameters.AddWithValue("@description", pSpecie.Description);

            //Let's try to open connection
            try
            {
                mySqlConnection.Open();
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable getSpecies()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM Species";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, strConnection);
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
