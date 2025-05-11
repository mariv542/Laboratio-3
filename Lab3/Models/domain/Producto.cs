namespace Lab3.Models.domain
{
    public class Producto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public Producto() { 
        }
        
        public Producto (string name, string description)
        {
            Name = name;
            Description = description;

        }
    }
}
