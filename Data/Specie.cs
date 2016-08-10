using System;
using MySql.Data.MySqlClient;

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
            string strQuery = "INSERT INTO Species(description) VALUES (@description)";

            MySqlCommand mySqlCommand = new MySqlCommand(strQuery);

            //Parameters
            mySqlCommand.Parameters.AddWithValue("@description", pSpecie.description);

            //Let's try to open connection
            try
            {
                mySqlConnection.Open();
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
            }
            catch (Exception)
            {
                throw new Exception("No se pudo acceder a la base de datos");
            }
        }

    }
}
