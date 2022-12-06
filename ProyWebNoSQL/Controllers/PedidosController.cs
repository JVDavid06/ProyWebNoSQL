using Microsoft.AspNetCore.Mvc;
using ProyWebNoSQL.Entities;
using ProyWebNoSQL.Models;

namespace ProyWebNoSQL.Controllers
{
    public class PedidosController : Controller
    {

        PedidosModel model = new PedidosModel();

        [HttpGet]
        public IActionResult VerPedidos()
        {
            var resultado = model.VerPedidos();
            return View(resultado);
        }

        [HttpGet]
        public IActionResult AgregarPedido()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AgregarPedido(Pedidos pedidos)
        {
            model.AgregarPedidos(pedidos);
            return RedirectToAction("VerPedidos", "Pedidos");
        }

        [HttpGet]
        public IActionResult EditarPedido(string idPedido)
        {
            model.VerPedidoEspecifico(idPedido);
            return View();
        }

        [HttpPut]
        public IActionResult EditarPedido(Pedidos pedidos)
        {
            model.EditarPedido(pedidos.id,pedidos);
            return RedirectToAction("VerPedidos", "Pedidos");
        }


        [HttpGet]
        public IActionResult VerPedidoEspecifico(string idPedido)
        {
            model.VerPedidoEspecifico(idPedido);
            return View();
        }

        [HttpDelete]
        public IActionResult EliminarPedido(string idPedido)
        {
            model.EliminarPedido(idPedido);
            return View();
        }

    }
}
