namespace AcmeApi.Models.Clases
{
    public class Pedido
    {
        public string numPedido { get; set; }
        public int cantidadPedido { get; set; }
        public string codigoEAN { get; set; }
        public string nombreProducto { get; set; }
        public string numDocumento { get; set; }
        public string direccion { get; set; }
    }
}
