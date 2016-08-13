using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Dog
    {
        public string nameReal { get; set; }
        public string nameFormal { get; set; }
        public DateTime birthDate { get; set; }
        public string gender { get; set; }
        public int Specie_idSpecie { get; set; }
        public int Color_idColor { get; set; }

        public Dog() { }
        public Dog(string nameReal, string nameFormal, DateTime birthDate, string gender, int idSpecie, int idColor)
        {
            this.nameReal = nameReal;
            this.nameFormal = nameFormal;
            this.birthDate = birthDate;
            this.gender = gender;
            this.Specie_idSpecie = idSpecie;
            this.Color_idColor = idColor;
        }
    }
}
