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

        [HttpGet]
        public ActionResult Editar(string id)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.id = id;
            return View(proveedor);
        }

        [HttpPost]
        public IActionResult EditarProveedor(Proveedor proveedor)
        {
            modelo.EditarProveedores(proveedor);
            return RedirectToAction("VerProveedores", "Proveedor");
        }
        
        [HttpGet]
        public ActionResult EliminarProveedor(string id)
        {
            modelo.EliminarProveedores(id);
            return RedirectToAction("VerProveedores", "Proveedor");
        }

    }
}
