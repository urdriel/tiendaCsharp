
namespace Ventas{

    public class Venta{

        int id;
        string fecha;
        decimal total;
        decimal iva21;
        decimal iva10;
        decimal iva7;
        int idcliente;

        public Venta(int id, string fecha, decimal total, decimal iva21, decimal iva10, decimal iva7, int idcliente)
        {
            this.Id = id;
            this.Fecha = fecha;
            this.Total = total;
            this.Iva21 = iva21;
            this.Iva10 = iva10;
            this.Iva7 = iva7;
            this.Idcliente = idcliente;
        }

        public int Id { get => id; set => id = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public decimal Total { get => total; set => total = value; }
        public decimal Iva21 { get => iva21; set => iva21 = value; }
        public decimal Iva10 { get => iva10; set => iva10 = value; }
        public decimal Iva7 { get => iva7; set => iva7 = value; }
        public int Idcliente { get => idcliente; set => idcliente = value; }
    }



}