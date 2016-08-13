using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Dog
    {
        private string nameReal;
        public string NameReal
        {
            get
            { return nameReal; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    nameReal = value;
                }
                else
                {
                    throw new Exception("Campo nulo o vacio. Revise los datos ingresados.");
                }
            }
        }
        private string nameFormal;
        public string NameFormal
        {
            get { return nameFormal; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    nameFormal = value;
                }
                else
                {
                    nameFormal = null;
                }
            }
        }
        public DateTime birthDate { get; set; }
        public string gender { get; set; }
        public int Specie_idSpecie { get; set; }
        public int Color_idColor { get; set; }

        public Dog() { }
        public Dog(string nameReal, string nameFormal, DateTime birthDate, string gender, int idSpecie, int idColor)
        {
            this.NameReal = nameReal;
            this.NameFormal = nameFormal;
            this.birthDate = birthDate;
            this.gender = gender;
            this.Specie_idSpecie = idSpecie;
            this.Color_idColor = idColor;
        }
    }
}
