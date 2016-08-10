using MySql.Data.MySqlClient;
using System;

namespace Data
{
    public static class Color
    {
        private static string strConnection = @"Server=localhost;Database=Criadero;Uid=admin;Pwd=msfsxs";
        private static MySqlConnection mySqlConnection;
        public static void insert(Entity.Color pColor)
        {
            //Query
            string mySqlQuery = "INSERT INTO Colors VALUES (null, @description)";
            try
            {
                mySqlConnection = new MySqlConnection(strConnection);
            }
            catch (Exception)
            {
                throw new Exception("No se pudo iniciar una conexion a la base de datos");
            }

            MySqlCommand mySqlCommand = new MySqlCommand(mySqlQuery, mySqlConnection);
            mySqlCommand.Parameters.AddWithValue("description", pColor.description);

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
