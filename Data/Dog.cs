using MySql.Data.MySqlClient;
using System;
using DataBaseConnection;
using System.Data;

namespace Data
{
    public static class Dog
    {              
        public static void insert(Entity.Dog pDog)
        {
            //Query
            string mySqlQuery = @"INSERT INTO Dogs VALUES (null, @nameReal, @nameFormal, @birthDate, @gender, @Specie_idSpecie, @Color_idColor)";

            MySqlCommand mySqlCommand = new MySqlCommand(mySqlQuery, MainConnection.GetConnection());
            mySqlCommand.Parameters.AddWithValue("nameReal", pDog.NameReal);
            mySqlCommand.Parameters.AddWithValue("nameFormal", pDog.NameFormal);
            mySqlCommand.Parameters.AddWithValue("birthDate", pDog.birthDate);
            mySqlCommand.Parameters.AddWithValue("gender", pDog.gender);
            mySqlCommand.Parameters.AddWithValue("Specie_idSpecie", pDog.Specie_idSpecie);
            mySqlCommand.Parameters.AddWithValue("Color_idColor", pDog.Color_idColor);
 
            try
            {
                MainConnection.ConnectAndExecute(mySqlCommand);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void InsertNoDate(Entity.Dog pDog)
        {
            //Query
            string mySqlQuery = @"INSERT INTO Dogs VALUES (null, @nameReal, @nameFormal, null, @gender, @Specie_idSpecie, @Color_idColor)";

            MySqlCommand mySqlCommand = new MySqlCommand(mySqlQuery, MainConnection.GetConnection());
            mySqlCommand.Parameters.AddWithValue("nameReal", pDog.NameReal);
            mySqlCommand.Parameters.AddWithValue("nameFormal", pDog.NameFormal);
            mySqlCommand.Parameters.AddWithValue("gender", pDog.gender);
            mySqlCommand.Parameters.AddWithValue("Specie_idSpecie", pDog.Specie_idSpecie);
            mySqlCommand.Parameters.AddWithValue("Color_idColor", pDog.Color_idColor);

            try
            {
                MainConnection.ConnectAndExecute(mySqlCommand);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable getFemales()
        {
            string query = @"SELECT dogs.nameReal FROM dogs WHERE (gender = 'Hembra')";
            DataTable dataTable = new DataTable();
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
        public static DataTable getMales()
        {
            string query = @"SELECT dogs.nameReal FROM dogs WHERE (gender = 'Macho')";
            DataTable dataTable = new DataTable();
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
