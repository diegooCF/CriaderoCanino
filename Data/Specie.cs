using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using DataBaseConnection;

namespace Data
{
    public static class Specie
    {
        public static void insert(Entity.Specie pSpecie)
        {
            //Insert statement
            string strQuery = "INSERT INTO Species VALUES (null, @description)";

            MySqlCommand mySqlCommand = new MySqlCommand(strQuery, MainConnection.GetConnection());

            //Parameters
            mySqlCommand.Parameters.AddWithValue("@description", pSpecie.Description);

            //Let's try to open connection
            try
            {
                MainConnection.ConnectAndExecute(mySqlCommand);
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
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, StrConnection.GetStringConnection());
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }        
        }      
    }
}
