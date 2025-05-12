using Lab3.Models.domain;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{
    public class ProductoController : Controller
    {
        private static List<Producto> productos = new List<Producto>();

        // GET: ProductoController
        public IActionResult Index()
        {
            return View(productos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Producto producto)
        {
            if (ModelState.IsValid)
            {
                productos.Add(producto);
                return RedirectToAction("Index");
            }
            
            return View(productos);
        }
        // GET: ProductoController/Details/5
        public IActionResult Details(string codigoDeBarras)
        {
            foreach (Producto producto in productos)
            {
                if (producto.CodigoDeBarra == codigoDeBarras)
                {
                    return View(producto);
                }
            }
            return NotFound("Producto no encontrado");
        }
    
    }
}
