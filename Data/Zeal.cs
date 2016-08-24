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
    }
}
