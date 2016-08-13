using System.Diagnostics.Contracts;

namespace Entity
{
    public class Specie
    {
        private string description;
        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                if (value != "")
                    description = value;
                else
                    throw new System.Exception("El campo Descripcion no puede estar vacio");
            }
        }

        public Specie() { }
        public Specie(string description)
        {
            this.Description = description;
        }

    }
}
