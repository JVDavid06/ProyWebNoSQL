using ProyWebNoSQL.Entities;

namespace ProyWebNoSQL.Models
{
    public class ProveedorModel
    {

        public List<Proveedor>? VerProveedores()
        {
        using (HttpClient client = new HttpClient())
            {
                string url = "https://localhost:44368/api/Proyecto/VerProveedores";

                HttpResponseMessage respuesta = client.GetAsync(url).GetAwaiter().GetResult();
                return respuesta.Content.ReadFromJsonAsync<List<Proveedor>>().Result;
            }
        }

        public void CrearProveedores(Proveedor proveedor)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://localhost:44368/api/Proyecto/CrearProveedor";

                JsonContent contenido = JsonContent.Create(proveedor);
                HttpResponseMessage respuesta = client.PostAsync(url, contenido).GetAwaiter().GetResult();
                //return "OK";
            }
        }

    }
}
