using System;
using System.Data;

namespace Logic
{
    public class Specie
    {
        public void insert(Entity.Specie pSpecie)
        {
            try
            {
                Data.Specie.insert(pSpecie);
            }
            catch(Exception e)
            {
                //We catch the exception provided by Data.Specie class and throw it again
                throw e;
            }
        }
        public DataTable getSpecies()
        {
            return Data.Specie.getSpecies();
        }
    }
}
