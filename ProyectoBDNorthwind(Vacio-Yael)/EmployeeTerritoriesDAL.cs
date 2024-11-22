using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDNorthwind_Vacio_Yael_
{
    public class EmployeeTerritoriesDAL
    {

        public static int AgregarEmployeeTerritories(EmployeeTerritories employeeTerritories)
        {
            int retorna = 0;

            try
            {
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    string query = "INSERT INTO EmployeeTerritories (EmployeeID, TerritoryID) " +
                                   "VALUES (@EmployeeID, @TerritoryID)";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@EmployeeID", employeeTerritories.EmployeeID);
                    comando.Parameters.AddWithValue("@TerritoryID", employeeTerritories.TerritoryID);

                    retorna = comando.ExecuteNonQuery();
                }

                return retorna;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error al insertar: " + sqlEx.Message);
                return retorna;
            }
        }

        public static List<EmployeeTerritories> PresentarRegistroEmployeeTerritories()
        {
            List<EmployeeTerritories> lista = new List<EmployeeTerritories>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "SELECT * FROM EmployeeTerritories";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    EmployeeTerritories employeeTerritories = new EmployeeTerritories();

                    employeeTerritories.EmployeeID = reader.GetInt32(0);  
                    employeeTerritories.TerritoryID = reader.GetString(1);  

                    lista.Add(employeeTerritories);
                }
                conexion.Close();
                return lista;
            }
        }

        public static int ModificarEmployeeTerritories(EmployeeTerritories employeeTerritories)
        {
            int result = 0;

            try
            {
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {

                    string query = "UPDATE EmployeeTerritories SET " +
                                   "TerritoryID = @TerritoryID " + 
                                   "WHERE EmployeeID = @EmployeeID AND TerritoryID = @TerritoryID";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@EmployeeID", employeeTerritories.EmployeeID);
                    comando.Parameters.AddWithValue("@TerritoryID", employeeTerritories.TerritoryID);

                    result = comando.ExecuteNonQuery();
                    conexion.Close();
                }
                return result;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error al modificar: " + sqlEx.Message);
                return result;
            }
        }

        public static int EliminarEmployeeTerritories(int employeeId, string territoryId)
        {
            int retorna = 0;

            try
            {
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    string query = "DELETE FROM EmployeeTerritories WHERE EmployeeID = @EmployeeID AND TerritoryID = @TerritoryID";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@EmployeeID", employeeId);
                    comando.Parameters.AddWithValue("@TerritoryID", territoryId);

                    retorna = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error al eliminar: " + sqlEx.Message);
            }

            return retorna;
        }

        // Busquedas

        public static List<EmployeeTerritories> BuscarRegistroEmployeeID(int EmployeeID)
        {
            List<EmployeeTerritories> Lista = new List<EmployeeTerritories>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from EmployeeTerritories where EmployeeID =" + EmployeeID + "";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    EmployeeTerritories employeeTerritories = new EmployeeTerritories();

                    employeeTerritories.EmployeeID = reader.GetInt32(0);
                    employeeTerritories.TerritoryID = reader.GetString(1);

                    Lista.Add(employeeTerritories);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static List<EmployeeTerritories> BuscarRegistroTerritoryID(string TerritoryID)
        {
            List<EmployeeTerritories> Lista = new List<EmployeeTerritories>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from EmployeeTerritories where TerritoryID ='" + TerritoryID + "' ";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    EmployeeTerritories employeeTerritories = new EmployeeTerritories();

                    employeeTerritories.EmployeeID = reader.GetInt32(0);
                    employeeTerritories.TerritoryID = reader.GetString(1);

                    Lista.Add(employeeTerritories);
                }
                conexion.Close();
                return Lista;
            }
        }







    }
}
