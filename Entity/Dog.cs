using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Dog
    {
        public string nameReal { get; set; }
        public string nameFormal { get; set; }
        public DateTime birthDate { get; set; }

        public Dog() { }
        public Dog(string nameReal, string nameFormal, DateTime birthDate)
        {
            this.nameReal = nameReal;
            this.nameFormal = nameFormal;
            this.birthDate = birthDate;
        }
    }
}
