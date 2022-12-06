using ProyWebNoSQL.Entities;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;

namespace ProyWebNoSQL.Models
{
    public class PedidosModel
    {
        public void AgregarPedidos(Pedidos pedidos)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://localhost:44368/api/Proyecto/AgregarPedido";

                JsonContent contenido = JsonContent.Create(pedidos);
                HttpResponseMessage respuesta = client.PostAsync(url, contenido).GetAwaiter().GetResult();
            }
        }

        public List<Pedidos>? VerPedidos()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://localhost:44368/api/Proyecto/VerPedidos";

                HttpResponseMessage respuesta = client.GetAsync(url).GetAwaiter().GetResult();
                return respuesta.Content.ReadFromJsonAsync<List<Pedidos>>().Result;
            }
        }

       
        public void VerPedidoEspecifico(string idPedido)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://localhost:44368/api/VerPedidoEspecifico?id="+idPedido;

                HttpResponseMessage respuesta = client.GetAsync(url).GetAwaiter().GetResult();
            }
        }

        public void EditarPedido(string idPedido, Pedidos pedidos)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://localhost:44368/api/EditarPedido?id=" + idPedido;
                JsonContent contenido = JsonContent.Create(pedidos);
                HttpResponseMessage respuesta = client.PutAsync(url, contenido).GetAwaiter().GetResult();
            }
        }

        public void EliminarPedido(string idPedido)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://localhost:44368/api/EliminarPedido?id=" + idPedido;
                HttpResponseMessage respuesta = client.DeleteAsync(url).GetAwaiter().GetResult();
            }
        }


    }
}
