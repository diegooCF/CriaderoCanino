namespace Entity
{
    public class Specie
    {
        public string description { get; set; }
        
        public Specie() { }
        public Specie(string description)
        {
            this.description = description;
        }
    }
}
