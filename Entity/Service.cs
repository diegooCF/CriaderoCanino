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
        public DateTime birthStart { get; set; }
        public DateTime birthEnd { get; set; }
        public int idDogZeal { get; set; }
        public DateTime startDateZeal { get; set; }

        public Service() { }
        public Service(int idMale, int idFemale, DateTime birthStart, DateTime birthEnd, int idDogZeal, DateTime startDateZeal)
        {
            this.idMale = idMale;
            this.idFemale = idFemale;
            this.birthStart = birthStart;
            this.birthEnd = birthEnd;
            this.idDogZeal = idDogZeal;
            this.startDateZeal = startDateZeal;
        } 
    }
}
