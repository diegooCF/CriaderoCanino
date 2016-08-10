using MySql.Data.MySqlClient;
using System;

namespace Data
{
    public static class Dog
    {
        private static string strConnection = @"Server=localhost;Database=Criadero;Uid=admin;Pwd=msfsxs";
        private static MySqlConnection mySqlConnection;
        public static void insert(Entity.Dog pDog)
        {
            //Query
            string mySqlQuery = @"INSERT INTO Dogs VALUES (null, @nameReal, @nameFormal, @birthDate, @Specie_idSpecie, @Color_idColor, @Gender_idGender)";
            try
            {
                mySqlConnection = new MySqlConnection(strConnection);
            }
            catch (Exception)
            {
                throw new Exception("No se pudo iniciar una conexion a la base de datos");
            }

            MySqlCommand mySqlCommand = new MySqlCommand(mySqlQuery, mySqlConnection);
            mySqlCommand.Parameters.AddWithValue("nameReal", pDog.nameReal);
            mySqlCommand.Parameters.AddWithValue("nameFormal", pDog.nameFormal);
            mySqlCommand.Parameters.AddWithValue("birthDate", pDog.birthDate);
            mySqlCommand.Parameters.AddWithValue("Specie_idSpecie", pDog.Specie_idSpecie);
            mySqlCommand.Parameters.AddWithValue("Color_idColor", pDog.Color_idColor);
            mySqlCommand.Parameters.AddWithValue("Gender_idGender", pDog.Gender_idGender);
       
            try
            {
                mySqlConnection.Open();
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Clone();
            }
            catch (Exception)
            {
                throw new Exception("No se pudo acceder a la base de datos");
            }
        }
    }
}
