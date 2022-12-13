namespace ProyWebNoSQL.Entities
{
    public class Ordenes
    {
        public string id { get; set; }
        public string FechaPedidp { get; set; }
        public string FechaPedido { get; set; }
        public string FechaEntrega { get; set; }
        public string IdPedido { get; set; }
        public string DireccionEnvio { get; set; }
        public bool Estado { get; set; }

    }
}
