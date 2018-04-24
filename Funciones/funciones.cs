using System;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace AdministrarBD{

    public class BDAdmin{        
        string serverIp;
        string dbUser;
        string dbUserPassword;
        string database;

        public string ServerIp { get => serverIp; set => serverIp = value; }
        public string DbUser { get => dbUser; set => dbUser = value; }
        public string DbUserPassword { get => dbUserPassword; set => dbUserPassword = value; }
        public string Database { get => database; set => database = value; }

        public void obtenerDatos(){
            
         var connection = new MySqlConnection("server=localhost;user id=root;password=;database=proyectotienda;SslMode=none;");
           connection.Open();

           string query = "select * from articulo";

           var cmd = new MySql.Data.MySqlClient.MySqlCommand(query,connection);
           var reader = cmd.ExecuteReader();
           
           while (reader.Read()){
               
               var nombre = reader["nombre"];
               Console.WriteLine(nombre);
               
                                }

        }

    }

}