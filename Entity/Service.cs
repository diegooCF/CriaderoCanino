using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Service
    {
        public int idMale { get; set; }
        public int idFemale { get; set; }
        public int Zeal_idDogs { get; set; }
        public DateTime Zeal_startDate { get; set; }

        public Service() { }
        public Service(int idMale, int idFemale, DateTime Zeal_startDate)
        {
            this.idMale = idMale;
            this.idFemale = idFemale;
            this.Zeal_idDogs = idFemale;
            this.Zeal_startDate = Zeal_startDate;
        } 
    }
}
