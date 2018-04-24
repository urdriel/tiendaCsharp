
namespace Clientes {

    public class Cliente{

        int id;
        string nombre;
        string email;        
        string fechaAlta;
        string fechaBaja;
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }
        public string FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public string FechaBaja { get => fechaBaja; set => fechaBaja = value; }
         public Cliente(int id, string nombre, string email, string fechaAlta, string fechaBaja)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Email = email;
            this.FechaAlta = fechaAlta;
            this.FechaBaja = fechaBaja;
        }

    }

}