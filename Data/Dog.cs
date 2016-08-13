﻿using MySql.Data.MySqlClient;
using System;

namespace Data
{
    public static class Dog
    {
        private static string strConnection = @"Server=localhost;Database=Criadero;Uid=admin;Pwd=msfsxs";
        private static MySqlConnection mySqlConnection;
        
        private static void ConnectAndExecute(MySqlCommand mySqlCommand)
        {
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
        public static void insert(Entity.Dog pDog)
        {
            //Query
            string mySqlQuery = @"INSERT INTO Dogs VALUES (null, @nameReal, @nameFormal, @birthDate, @gender, @Specie_idSpecie, @Color_idColor)";
            try
            {
                mySqlConnection = new MySqlConnection(strConnection);
            }
            catch (Exception)
            {
                throw new Exception("No se pudo iniciar una conexion a la base de datos");
            }

            MySqlCommand mySqlCommand = new MySqlCommand(mySqlQuery, mySqlConnection);
            mySqlCommand.Parameters.AddWithValue("nameReal", pDog.NameReal);
            mySqlCommand.Parameters.AddWithValue("nameFormal", pDog.NameFormal);
            mySqlCommand.Parameters.AddWithValue("birthDate", pDog.birthDate);
            mySqlCommand.Parameters.AddWithValue("gender", pDog.gender);
            mySqlCommand.Parameters.AddWithValue("Specie_idSpecie", pDog.Specie_idSpecie);
            mySqlCommand.Parameters.AddWithValue("Color_idColor", pDog.Color_idColor);
 
            try
            {
                ConnectAndExecute(mySqlCommand);
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
            try
            {
                mySqlConnection = new MySqlConnection(strConnection);
            }
            catch (Exception)
            {
                throw new Exception("No se pudo iniciar una conexion a la base de datos");
            }

            MySqlCommand mySqlCommand = new MySqlCommand(mySqlQuery, mySqlConnection);
            mySqlCommand.Parameters.AddWithValue("nameReal", pDog.NameReal);
            mySqlCommand.Parameters.AddWithValue("nameFormal", pDog.NameFormal);
            mySqlCommand.Parameters.AddWithValue("gender", pDog.gender);
            mySqlCommand.Parameters.AddWithValue("Specie_idSpecie", pDog.Specie_idSpecie);
            mySqlCommand.Parameters.AddWithValue("Color_idColor", pDog.Color_idColor);

            try
            {
                ConnectAndExecute(mySqlCommand);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
