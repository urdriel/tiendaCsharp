using System;
using AdministrarBD;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace tiendacsharp
{
    class Program
    {
        static void Main(string[] args)
        {

           BDAdmin conexion = new BDAdmin();

           conexion.obtenerDatos();

           }
    }
}
