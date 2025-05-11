using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab3.Models.domain
{
    public class ProductoPerecible : Producto


    {
        public DateOnly FechaDeVencimiento { get; set; }
       
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
