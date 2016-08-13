using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

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
        /// <summary>
        /// This method find an ID specifying a Description
        /// </summary>
        /// <param name="description">Receives a string to compare</param>
        /// <returns>ID of specified description</returns>
        public static int getSpecieID(string pDescription)
        {
            //TODO arreglar esto!!
            int id = 0;
            MySqlConnection mySqlConnection = new MySqlConnection(strConnection);
            DataTable dataTable = new DataTable();
            string query = @"SELECT idSpecie FROM Species WHERE ('@description' = description)";
            //MySqlCommand command = new MySqlCommand(query);
            //command.Parameters.AddWithValue("description", pDescription);
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, strConnection);
            adapter.SelectCommand.Parameters.AddWithValue("@description", "%" + pDescription + "%");
            MessageBox.Show(query);

            adapter.Fill(dataTable);
            DataRow row = dataTable.Rows[0];
            id = Convert.ToInt32(row["idSpecie"].ToString());
            return id;
        }
    }
}
