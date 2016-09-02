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
        public void insert(Entity.Zeal pZeal)
        {
            try
            {
                Data.Zeal.insert(pZeal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void update(Entity.Zeal pDogHasZeal)
        {
            try
            {
                Data.Zeal.update(pDogHasZeal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
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
        public DataTable getAllActiveZeals()
        {
            try
            {
                return Data.Zeal.getAllActiveZeals();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
