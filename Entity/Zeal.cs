using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Zeal
    {
        public int Dogs_idDogs { get; set; }
        public DateTime startDate { get; set; }

        public Zeal() { }
        public Zeal(int Dogs_idDogs, DateTime startDate)
        {
            this.Dogs_idDogs = Dogs_idDogs;
            this.startDate = startDate;
        }
    }
}
