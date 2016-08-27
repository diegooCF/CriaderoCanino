using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using DataBaseConnection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public static class Zeal
    {
        public static void insert(Entity.Zeal pDogHasZeal)
        {
            string query = @"INSERT INTO Dog_has_Zeal VALUES (@Dogs_idDogs, @startDate)";
            MySqlCommand mySqlCommand = new MySqlCommand(query, MainConnection.GetConnection());
            mySqlCommand.Parameters.AddWithValue("@Dogs_idDogs", pDogHasZeal.Dogs_idDogs);
            mySqlCommand.Parameters.AddWithValue("@startDate", pDogHasZeal.startDate);

            try
            {
                MainConnection.ConnectAndExecute(mySqlCommand);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable getZealFrom(int idFemaleDog)
        {
            string query = @"SELECT * FROM Dog_has_Zeal WHERE (Dogs_idDogs = ?idFemaleDog)";
            DataTable dataTable = new DataTable();
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, StrConnection.GetStringConnection());
                adapter.SelectCommand.Parameters.AddWithValue("?idFemaleDog",idFemaleDog);
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }
        public static DataTable getAllActiveZeals()
        {
            string query = @"SELECT 
                        Dogs.nameReal as 'Hembra',
                        Zeal.startDate as 'Inicio de Celo'
                        FROM
                        Dog_has_Zeal as Zeal
                        INNER JOIN dogs 
                        ON Zeal.Dogs_idDogs = dogs.idDogs";

            DataTable dataTable = new DataTable();
            try
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, MainConnection.GetConnection());
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
