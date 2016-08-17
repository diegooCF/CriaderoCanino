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
        public static DataTable GetAllServices()
        {
            string query =
                @"SELECT 
                services.idService as 'ID',
                T1.nameReal as 'Macho',
                T2.nameReal as 'Hembra',
                services.birthStart as 'Aprox Min Fecha Parto',
                services.birthEnd as 'Aprox Max Fecha Parto',
                dog_has_zeal.startDate as 'Inicio de Celo'
                FROM Services 
                INNER JOIN Dog_has_Zeal
                ON Services.Dog_has_Zeal_Dogs_idDogs = Dog_has_Zeal.Dogs_idDogs
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
    }
}
