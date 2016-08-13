namespace Entity
{
    public class Color
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

        public Color() { }
        public Color(string description)
        {
            this.description = description;
        }
    }
}
