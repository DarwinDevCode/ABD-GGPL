using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class csConexionBD
    {
        static string cadena_conexion = @"Server=192.168.10.50,1433;Database=GGPL; User Id=admin;Password=admin;TrustServerCertificate=True;";

        static SqlConnection conexion = new SqlConnection(cadena_conexion);

        public static SqlConnection ObtenerConexion()
        {
            var cn = new SqlConnection(cadena_conexion);
            cn.Open();
            return cn;
        }

    }
}
