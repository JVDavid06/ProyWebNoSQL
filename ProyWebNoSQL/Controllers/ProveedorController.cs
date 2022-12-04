using Microsoft.AspNetCore.Mvc;
using ProyWebNoSQL.Entities;
using ProyWebNoSQL.Models;

namespace ProyWebNoSQL.Controllers
{
    public class ProveedorController : Controller
    {
        ProveedorModel modelo = new ProveedorModel();

        [HttpGet]
        public IActionResult VerProveedores()
        {
            var resultado = modelo.VerProveedores();
            return View(resultado);
        }

        [HttpGet]
        public IActionResult CrearProveedores()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CrearProveedores(Proveedor proveedor)
        {
            modelo.CrearProveedores(proveedor);
            return RedirectToAction("VerProveedores","Proveedor");
        }

    }
}
