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

        // get para mostrar el formulario
        public IActionResult Create()
        {
            return View();
        }

        // post para recibir datos del formulario y crear un nuevo producto
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

        // get para mostrar un producto en especifico 
        // que se busca por su código de barras
        public IActionResult Details(string codigo)
        {
            foreach (Producto producto in productos)
            {
                if (producto.CodigoDeBarra == codigo)
                {
                    return View(producto);
                }
            }
            return NotFound();
        }


        // get para mostrar el formulario de editar un producto
        public IActionResult Edit(string codigo)
        {
            foreach (var p in productos)
            {
                if (p.CodigoDeBarra == codigo)
                {
                    return View(p);
                }
            }
            //si no lo encuentra  muestra un error
            return NotFound();
        }


        // post para editar un producto
        [HttpPost]
        public IActionResult Edit(Producto p)
        {
            for (int i = 0; i < productos.Count; i++)
            {
                if (productos[i].CodigoDeBarra == p.CodigoDeBarra)
                {
                    if (ModelState.IsValid)
                    {
                        productos[i].Nombre = p.Nombre;
                        productos[i].Precio = p.Precio;
                        productos[i].CantidadDisponible = p.CantidadDisponible;
                        productos[i].Estado = p.Estado;
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View(p);
                    }
                }
            }
            return NotFound("Producto no encontrado");
        }

        // get para mostrar el formulario de eliminar un producto
        public IActionResult Delete(string codigo)
        {
            foreach (var p in productos)
            {
                if (p.CodigoDeBarra == codigo)
                {
                    return View(p);
                }
            }
            return NotFound();
        }


        // post para eliminar un producto y regresas a la vista de productos
        [HttpPost]
        public IActionResult DeletePost(string codigoDeBarras)
        {
            for (int i = 0; i < productos.Count; i++)
            {
                if (productos[i].CodigoDeBarra == codigoDeBarras)
                {
                    productos.RemoveAt(i);
                    break;
                }
            }
            return RedirectToAction("Index");

        }




    }
}
