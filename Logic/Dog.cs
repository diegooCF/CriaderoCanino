using System;
using System.Collections.Generic;
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
        public void InsertNoDate(Entity.Dog pDog)
        {
            try
            {
                Data.Dog.InsertNoDate(pDog);
            }
            catch (Exception e)
            {
                //We catch the exception provided by Data.Dog class and throw it again
                throw e;
            }
        }
    }
}
