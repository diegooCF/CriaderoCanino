using System;
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
            string query = @"INSERT INTO Services VALUES (null, @idMale, @idFemale, @birthStart, @birthEnd, @idDogZealFemale, @startDateZeal);";
            MySqlCommand mySqlCommand = new MySqlCommand(query, MainConnection.GetConnection());
            mySqlCommand.Parameters.AddWithValue("idMale", pService.idMale);
            mySqlCommand.Parameters.AddWithValue("idFemale", pService.idFemale);
            mySqlCommand.Parameters.AddWithValue("birthStart", pService.birthStart.Date);
            mySqlCommand.Parameters.AddWithValue("birthEnd", pService.birthEnd.Date);
            mySqlCommand.Parameters.AddWithValue("idDogZealFemale", pService.idDogZeal);
            mySqlCommand.Parameters.AddWithValue("startDateZeal", pService.startDateZeal.Date);

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
                DATE(services.birthStart) as 'Aprox Min Fecha Parto',
                DATE(services.birthEnd) as 'Aprox Max Fecha Parto',
                DATE(services.Dog_has_Zeal_Dogs_startDate) as 'Inicio de Celo'
                FROM Services 
                INNER JOIN Dog_has_Zeal
                ON Services.Dog_has_Zeal_Dogs_idDogs = Dog_has_Zeal.Dogs_idDogs AND services.Dog_has_Zeal_Dogs_startDate = Dog_has_Zeal.startDate
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
            string query = @"UPDATE Services SET idMale = @idMale, idFemale = @idFemale, birthStart = @birthStart, birthEnd = @birthEnd, Dog_has_Zeal_Dogs_idDogs = @idDogZeal, Dog_has_Zeal_Dogs_startDate = @startDateZeal";
            MySqlCommand mySqlCommand = new MySqlCommand(query, MainConnection.GetConnection());
            mySqlCommand.Parameters.AddWithValue("idMale", pService.idMale);
            mySqlCommand.Parameters.AddWithValue("idFemale", pService.idFemale);
            mySqlCommand.Parameters.AddWithValue("birthStart", pService.birthStart);
            mySqlCommand.Parameters.AddWithValue("birthEnd", pService.birthEnd);
            mySqlCommand.Parameters.AddWithValue("idDogZeal", pService.idDogZeal);
            mySqlCommand.Parameters.AddWithValue("startDateZeal", pService.startDateZeal);

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
