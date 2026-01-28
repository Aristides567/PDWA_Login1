using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {
        private static string cadena = "Data Source=LAPTOP-PHCFNULN\\SQLEXPRESS;Initial Catalog=LoginDB;Integrated Security=True;";

        public static SqlConnection obtenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}
