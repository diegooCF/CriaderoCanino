using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Dog
    {
        public void insert(Entity.Dog pDog)
        {
            try
            {
                Data.Dog.insert(pDog);
            }
            catch (Exception e)
            {
                //We catch the exception provided by Data.Dog class and throw it again
                throw e;
            }
        }
        public void insertNoDate(Entity.Dog pDog)
        {
            try
            {
                Data.Dog.insertNoDate(pDog);
            }
            catch (Exception e)
            {
                //We catch the exception provided by Data.Dog class and throw it again
                throw e;
            }
        }

        public DataTable getFemales()
        {
            try
            {
                return Data.Dog.getFemales();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable getMales()
        {
            try
            {
                return Data.Dog.getMales();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int getIdByRealName(string nameReal)
        {
            try
            {
                return Data.Dog.getIdByRealName(nameReal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
