
namespace lineaVentas{

    public class LineaVenta {

        int id;
        int codart;
        int codVenta;
        string articulo;
        string precio;
        string subtotal;
        int cantidad;

        public int Id { get => id; set => id = value; }
        public int Codart { get => codart; set => codart = value; }
        public int CodVenta { get => codVenta; set => codVenta = value; }
        public string Articulo { get => articulo; set => articulo = value; }
        public string Precio { get => precio; set => precio = value; }
        public string Subtotal { get => subtotal; set => subtotal = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public LineaVenta(int id, int codart, int codVenta, string articulo, string precio, string subtotal, int cantidad)
        {
            this.id = id;
            this.codart = codart;
            this.codVenta = codVenta;
            this.articulo = articulo;
            this.precio = precio;
            this.subtotal = subtotal;
            this.cantidad = cantidad;
        }

    }

}