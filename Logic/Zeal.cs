using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Zeal
    {
        public DataTable getZealFrom(int idFemaleDog)
        {
            try
            {
                return Data.Zeal.getZealFrom(idFemaleDog);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
