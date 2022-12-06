namespace ProyWebNoSQL.Entities
{
    public class Pedidos
    {
        public string id { get; set; }
        public string FormaDePago { get; set; }
        public string IdUsuario { get; set; }
        public string IdProducto { get; set; }
        public int Cantidad { get; set; }
        public int Total { get; set; }
    }
}
