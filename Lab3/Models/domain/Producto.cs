using Microsoft.Extensions.Primitives;

namespace Lab3.Models.domain
{
    public class Producto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CodigoDeBarra { get; set; }
        public int Precio { get; set; }
        public int CantidadDisponible { get; set; }
        public bool Estado { get; set; } 

        public Producto() { 
        }
        
        public Producto (string name, string codigoDeBarra, int precio, int cantidadDisponible, bool estado)
        {
            Name = name;
            CodigoDeBarra = codigoDeBarra;
            Precio = precio;
            CantidadDisponible = cantidadDisponible;
            Estado = estado;

        }
    }
}