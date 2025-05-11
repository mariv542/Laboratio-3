namespace Lab3.Models.domain
{
    public class ProductoNoPerecible : Producto
    {
        public Envasado Envasado { get; set; }
       
        public ProductoNoPerecible( Envasado envasado)
        {
            Envasado = envasado;
        }
       
    }
}
