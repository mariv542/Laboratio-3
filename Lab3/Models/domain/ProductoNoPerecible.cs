using System.ComponentModel.DataAnnotations;

namespace Lab3.Models.domain
{
    public class ProductoNoPerecible : Producto
    {
        [Required]
        [StringLength(120)]
        [Display(Name = "Nombre del envasado")]
        public Envasado TipoEnvasado { get; set; }
       
        public ProductoNoPerecible( Envasado tipoEnvasado)
        {
            TipoEnvasado = tipoEnvasado;
        }
       
    }
}
