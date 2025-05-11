using Microsoft.Extensions.Primitives;
using System.ComponentModel.DataAnnotations;

namespace Lab3.Models.domain
{
    public class Producto
    {
        [Required]
        [StringLength(120)]
        [Display (Name = "Nombre del producto")]
        public string Name { get; set; }


        [Required]
        [StringLength(60)]
        [Display(Name = "Código de barra")]
        public string CodigoDeBarra { get; set; }

        [Required]
        [Display(Name = "Precio")]
        public int Precio { get; set; }

        [Required]
        [Display(Name = "Cantidad disponible")]
        public int CantidadDisponible { get; set; }

        [Required]
        [Display(Name = "Estado")]
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