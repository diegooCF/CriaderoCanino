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
        public int Specie_idSpecie { get; set; }
        public int Color_idColor { get; set; }
        public int Gender_idGender { get; set; }

        public Dog() { }
        public Dog(string nameReal, string nameFormal, DateTime birthDate, int idSpecie, int idColor, int idGender)
        {
            this.nameReal = nameReal;
            this.nameFormal = nameFormal;
            this.birthDate = birthDate;
            this.Specie_idSpecie = idSpecie;
            this.Color_idColor = idColor;
            this.Gender_idGender = idGender;
        }
    }
}
