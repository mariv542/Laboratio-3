using System.ComponentModel.DataAnnotations;

namespace Lab3.Models.domain
{
    public class ProductoPerecible : Producto
    {
        [Required]
        [Display(Name = "Fecha de vencimiento")]
        [DataType(DataType.Date)]
        public DateOnly FechaDeVencimiento { get; set; }

        [Required]
        [Display(Name = "Dias para vencer")]
        public int DiasParaVencer
        {
            get
            {
                return (FechaDeVencimiento.DayNumber - DateOnly.FromDateTime(DateTime.Now).DayNumber);    
            }
            private set { } 
        }

    }
}
