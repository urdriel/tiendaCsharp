

namespace Articulos{
    public class Articulo{
        int id;
        string nombre;
        string descripcion;
        string imagen;
        int stock;
        decimal preciocompra;
        decimal precio;
        decimal iva;
        
        public Articulo(int id, string nombre, string descripcion, string imagen, int stock, decimal preciocompra, decimal precio, decimal iva)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Imagen = imagen;
            this.Stock = stock;
            this.Preciocompra = preciocompra;
            this.Precio = precio;
            this.Iva = iva;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public int Stock { get => stock; set => stock = value; }
        public decimal Preciocompra { get => preciocompra; set => preciocompra = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public decimal Iva { get => iva; set => iva = value; }
    }



}