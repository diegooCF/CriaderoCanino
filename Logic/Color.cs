using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Color
    {
        public void insert(Entity.Color pColor)
        {
            try
            {
                Data.Color.insert(pColor);
            }
            catch (Exception e)
            {
                //We catch the exception provided by Data.Specie class and throw it again
                throw e;
            }
        }
    }
}
