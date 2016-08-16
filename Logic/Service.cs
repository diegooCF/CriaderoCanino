using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Service
    {
        public DataTable GetAllServices()
        {
            try
            {
                return Data.Service.GetAllServices();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
