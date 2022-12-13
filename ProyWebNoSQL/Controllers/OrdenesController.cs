using Microsoft.AspNetCore.Mvc;
using ProyWebNoSQL.Entities;
using ProyWebNoSQL.Models;

namespace ProyWebNoSQL.Controllers
{
    public class OrdenesController : Controller
    {

        OrdenesModel model = new OrdenesModel();

        [HttpGet]
        public IActionResult VerOrdenes()
        {
            var resultado = model.VerOrdenes();
            return View(resultado);
        }

        [HttpGet]
        public IActionResult AgregarOrdenes()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AgregarOrdenes(Ordenes ordenes)
        {
            model.AgregarOrdenes(ordenes);
            return RedirectToAction("VerOrdenes", "Ordenes");
        }

        [HttpGet]
        public IActionResult EditarOrdenes(string idOrdenes)
        {
            model.VerOrdenesEspecifico(idOrdenes);
            return View();
        }

        [HttpPost]
        public IActionResult EditarOrdenes(Ordenes ordenes)
        {
            model.EditarOrdenes(ordenes.id,ordenes);
            return RedirectToAction("VerOrdenes", "Ornedes");
        }


        [HttpGet]
        public IActionResult VerOrnesEspecifico(string idOrdenes)
        {
            model.VerOrdenesEspecifico(idOrdenes);
            return View();
        }

        [HttpGet]
        public IActionResult EliminarOrdenes(string id)
        {
            model.EliminarOrdenes(id);
            return RedirectToAction("VerOrdenes", "Ordenes");
        }

    }
}
