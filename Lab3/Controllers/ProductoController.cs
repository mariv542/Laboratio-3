using Lab3.Models.domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{
    public class ProductoController : Controller
    {
        private static List<Producto> productos = new List<Producto>();

        // GET: ProductoController
        public ActionResult Index()
        {
            return View(productos);
        }

        // GET: ProductoController/Details/5
        public ActionResult Details(string codigoDeBarras)
        {
            foreach (var producto in productos)
            {
                if (producto.CodigoDeBarra == codigoDeBarras)
                {
                    return View(producto);
                }
            }
            return NotFound("Producto no encontrado");
        }

        // GET: ProductoController/Create
        [HttpPost]
        public ActionResult Create(Producto producto)
        {
            if (ModelState.IsValid)
            {
                productos.Add(producto);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(producto);
            }
        }

        // POST: ProductoController/Create
        
        public ActionResult Create()
        {
            return View();
        }


        /// <summary>
        /// ///////////////////////////////////////
        /// </summary>
        /// <returns></returns>

        // GET: ProductoController/Edit/5
        public ActionResult Edit()
        {
            return View();
        }

        // POST: ProductoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Producto producto)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductoController/Delete/5
        public ActionResult Delete()
        {
            return View();
        }

        // POST: ProductoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Producto producto)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
