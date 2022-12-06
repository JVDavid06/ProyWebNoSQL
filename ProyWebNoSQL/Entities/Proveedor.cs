namespace ProyWebNoSQL.Entities
{
    public class Proveedor
    {
        public string id { get; set; }
        public string NombreProveedor { get; set; } = string.Empty;
        public string Direccion { get; set; }= string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
