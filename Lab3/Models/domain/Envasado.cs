namespace Lab3.Models.domain
{
    public class Envasado
    {
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public Envasado(string nombre, string descripcion) 
        {
            Nombre = nombre;        
            Descripcion = descripcion;

        }

    }
}
