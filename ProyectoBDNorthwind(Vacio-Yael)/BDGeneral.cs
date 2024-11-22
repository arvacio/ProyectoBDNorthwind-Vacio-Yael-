using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDNorthwind_Vacio_Yael_
{
    public class BDGeneral
    {
        // Funcion para obtener la conexion de la BD
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=master;Data Source=DESKTOP-B36TSS5\\SQLEXPRESS"); 
            conexion.Open();
            return conexion;
        }
    }
}
