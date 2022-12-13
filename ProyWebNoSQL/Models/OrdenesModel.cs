using ProyWebNoSQL.Entities;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;


namespace ProyWebNoSQL.Models
{
    public class OrdenesModel
    {
        public void AgregarOrdenes(Ordenes ordenes)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://localhost:44368/api/Proyecto/AgregarOrden";

                JsonContent contenido = JsonContent.Create(ordenes);
                HttpResponseMessage respuesta = client.PostAsync(url, contenido).GetAwaiter().GetResult();
            }
        }

        public List<Ordenes>? VerOrdenes() //aqui
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://localhost:44368/api/Proyecto/VerOrden";

                HttpResponseMessage respuesta = client.GetAsync(url).GetAwaiter().GetResult();
                return respuesta.Content.ReadFromJsonAsync<List<Ordenes>>().Result;
            }
        }


        public void VerOrdenesEspecifico(string idOrdenes)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://localhost:44368/api/VerOrdenesEspecifico?id=" + idOrdenes;

                HttpResponseMessage respuesta = client.GetAsync(url).GetAwaiter().GetResult();
            }
        }

        public void EditarOrdenes(string idOrden, Ordenes ordenes)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://localhost:44368/api/EditarOrden?id=" + idOrden;
                JsonContent contenido = JsonContent.Create(ordenes);
                HttpResponseMessage respuesta = client.PutAsync(url, contenido).GetAwaiter().GetResult();
            }
        }

        public void EliminarOrdenes(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://localhost:44368/api/Proyecto/EliminarOrden?id=" + id;

                // JsonContent contenido = JsonContent.Create(id);
                HttpResponseMessage respuesta = client.DeleteAsync(url).GetAwaiter().GetResult();

            }
        }

    }
}
