using System.ComponentModel.DataAnnotations;

namespace Lab3.Models.domain
{
    public class Envasado
    {
        [Required]
        [StringLength(120)]
        [Display(Name = "Nombre del envasado")]
        public string Nombre { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Descripción del envasado")]
        public string Descripcion { get; set; }

        public Envasado(string nombre, string descripcion) 
        {
            Nombre = nombre;        
            Descripcion = descripcion;

        }

    }
}
