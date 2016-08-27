﻿using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;
using DataBaseConnection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public static class Service
    {
        public static void insert(Entity.Service pService)
        {
            string query = @"INSERT INTO Services VALUES (null, @idMale, @idFemale, @Zeal_idDogs, @Zeal_startDate)";
            MySqlCommand mySqlCommand = new MySqlCommand(query, MainConnection.GetConnection());
            mySqlCommand.Parameters.AddWithValue("idMale", pService.idMale);
            mySqlCommand.Parameters.AddWithValue("idFemale", pService.idFemale);
            mySqlCommand.Parameters.AddWithValue("Zeal_idDogs", pService.Zeal_idDogs);
            mySqlCommand.Parameters.AddWithValue("Zeal_startDate", pService.Zeal_startDate);
            try
            {
                MainConnection.ConnectAndExecute(mySqlCommand);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable getAllServices()
        {
            string query =
                @"SELECT 
                services.idService as 'ID',
                T1.nameReal as 'Macho',
                T2.nameReal as 'Hembra',
                DATE_FORMAT(services.Zeal_startDate, '%d/%m/%Y') as 'Inicio de Celo',
                DATE_ADD(services.Zeal_startDate, INTERVAL 2 MONTH) as 'Min Fecha Nac'
                FROM Services 
                INNER JOIN Dog_has_Zeal
                ON Services.Zeal_idDogs = Dog_has_Zeal.Dogs_idDogs AND services.Zeal_startDate = Dog_has_Zeal.startDate
                INNER JOIN Dogs as T1
                ON Services.idMale = T1.idDogs
                INNER JOIN Dogs as T2
                ON Services.idFemale = T2.idDogs";

            DataTable dataTable = new DataTable();
            try
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, StrConnection.GetStringConnection());
                mySqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void update(Entity.Service pService)
        {
            string sprocQuery = "sprocUpdateService";
            MySqlCommand mySqlCommand = new MySqlCommand(sprocQuery, MainConnection.GetConnection());
            mySqlCommand.CommandType = CommandType.StoredProcedure;

            //Parameters
            mySqlCommand.Parameters.AddWithValue("idMale", pService.idMale);
            mySqlCommand.Parameters.AddWithValue("idFemale", pService.idFemale);
            mySqlCommand.Parameters.AddWithValue("Zeal_idDogs", pService.Zeal_idDogs);
            mySqlCommand.Parameters.AddWithValue("Zeal_startDate", pService.Zeal_startDate);

            try
            {
                MainConnection.ConnectAndExecute(mySqlCommand);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
