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
        public void insert(Entity.Service pService)
        {
            try
            {
                Data.Service.insert(pService);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable getAllServices()
        {
            try
            {
                return Data.Service.getAllServices();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DataTable getAllServicesCompositeData()
        {
            try
            {
                return Data.Service.getAllServicesCompositeData();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void update(Entity.Service pService)
        {
            try
            {
                Data.Service.update(pService);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Entity.Service getService(int pId)
        {
            try
            {
                return Data.Service.getService(pId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void delete(int pId)
        {
            try
            {
                Data.Service.delete(pId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
