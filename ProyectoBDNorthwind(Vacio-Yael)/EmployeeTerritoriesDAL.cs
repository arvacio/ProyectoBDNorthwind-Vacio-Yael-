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

            try
            {
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta con JOIN para obtener EmployeeID, TerritoryID, FirstName y TerritoryDescription
                    string query = @"
                SELECT et.EmployeeID, et.TerritoryID, e.FirstName, t.TerritoryDescription
                FROM EmployeeTerritories et
                INNER JOIN Employees e ON et.EmployeeID = e.EmployeeID
                INNER JOIN Territories t ON et.TerritoryID = t.TerritoryID";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EmployeeTerritories employeeTerritories = new EmployeeTerritories();

                            // Asignamos EmployeeID
                            employeeTerritories.EmployeeID = reader.GetInt32(0);

                            // Asignamos TerritoryID
                            employeeTerritories.TerritoryID = reader.GetString(1);

                            // Asignamos FirstName
                            if (!reader.IsDBNull(2)) // Verificamos si FirstName no es nulo
                            {
                                employeeTerritories.FirstName = reader.GetString(2);
                            }

                            // Asignamos TerritoryDescription
                            if (!reader.IsDBNull(3)) // Verificamos si TerritoryDescription no es nulo
                            {
                                employeeTerritories.TerritoryDescription = reader.GetString(3);
                            }

                            lista.Add(employeeTerritories);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                throw new ApplicationException("Error al obtener los datos de EmployeeTerritories.", ex);
            }

            return lista;
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

            try
            {
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL con JOIN para obtener EmployeeID, TerritoryID, FirstName y TerritoryDescription
                    string query = @"
                SELECT et.EmployeeID, et.TerritoryID, e.FirstName, t.TerritoryDescription
                FROM EmployeeTerritories et
                INNER JOIN Employees e ON et.EmployeeID = e.EmployeeID
                INNER JOIN Territories t ON et.TerritoryID = t.TerritoryID
                WHERE et.EmployeeID = @EmployeeID";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@EmployeeID", EmployeeID); // Parámetro para evitar inyecciones SQL

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EmployeeTerritories employeeTerritories = new EmployeeTerritories();

                            // Asignar EmployeeID
                            employeeTerritories.EmployeeID = reader.GetInt32(0);

                            // Asignar TerritoryID
                            employeeTerritories.TerritoryID = reader.GetString(1);

                            // Asignar FirstName
                            if (!reader.IsDBNull(2)) // Verificar si FirstName no es nulo
                            {
                                employeeTerritories.FirstName = reader.GetString(2);
                            }

                            // Asignar TerritoryDescription
                            if (!reader.IsDBNull(3)) // Verificar si TerritoryDescription no es nulo
                            {
                                employeeTerritories.TerritoryDescription = reader.GetString(3);
                            }

                            Lista.Add(employeeTerritories);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                throw new ApplicationException("Error al obtener los datos de EmployeeTerritories.", ex);
            }

            return Lista;
        }


        public static List<EmployeeTerritories> BuscarRegistroTerritoryID(string TerritoryID)
        {
            List<EmployeeTerritories> Lista = new List<EmployeeTerritories>();

            try
            {
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL con JOIN para obtener EmployeeID, TerritoryID, FirstName y TerritoryDescription
                    string query = @"
                SELECT et.EmployeeID, et.TerritoryID, e.FirstName, t.TerritoryDescription
                FROM EmployeeTerritories et
                INNER JOIN Employees e ON et.EmployeeID = e.EmployeeID
                INNER JOIN Territories t ON et.TerritoryID = t.TerritoryID
                WHERE et.TerritoryID = @TerritoryID";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@TerritoryID", TerritoryID); // Parámetro para evitar inyecciones SQL

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EmployeeTerritories employeeTerritories = new EmployeeTerritories();

                            // Asignamos EmployeeID
                            employeeTerritories.EmployeeID = reader.GetInt32(0);

                            // Asignamos TerritoryID
                            employeeTerritories.TerritoryID = reader.GetString(1);

                            // Asignamos FirstName
                            if (!reader.IsDBNull(2)) // Verificar si FirstName no es nulo
                            {
                                employeeTerritories.FirstName = reader.GetString(2);
                            }

                            // Asignamos TerritoryDescription
                            if (!reader.IsDBNull(3)) // Verificar si TerritoryDescription no es nulo
                            {
                                employeeTerritories.TerritoryDescription = reader.GetString(3);
                            }

                            Lista.Add(employeeTerritories);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                throw new ApplicationException("Error al obtener los datos de EmployeeTerritories.", ex);
            }

            return Lista;
        }

        public static List<EmployeeTerritories> BuscarRegistroFirstName(string FirstName)
        {
            List<EmployeeTerritories> Lista = new List<EmployeeTerritories>();

            try
            {
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL con JOIN para obtener EmployeeID, TerritoryID, FirstName y TerritoryDescription
                    string query = @"
                SELECT et.EmployeeID, et.TerritoryID, e.FirstName, t.TerritoryDescription
                FROM EmployeeTerritories et
                INNER JOIN Employees e ON et.EmployeeID = e.EmployeeID
                INNER JOIN Territories t ON et.TerritoryID = t.TerritoryID
                WHERE e.FirstName = @FirstName";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@FirstName", FirstName); // Parámetro para evitar inyecciones SQL

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EmployeeTerritories employeeTerritories = new EmployeeTerritories();

                            // Asignar EmployeeID
                            employeeTerritories.EmployeeID = reader.GetInt32(0);

                            // Asignar TerritoryID
                            employeeTerritories.TerritoryID = reader.GetString(1);

                            // Asignar FirstName
                            if (!reader.IsDBNull(2)) // Verificar si FirstName no es nulo
                            {
                                employeeTerritories.FirstName = reader.GetString(2);
                            }

                            // Asignar TerritoryDescription
                            if (!reader.IsDBNull(3)) // Verificar si TerritoryDescription no es nulo
                            {
                                employeeTerritories.TerritoryDescription = reader.GetString(3);
                            }

                            Lista.Add(employeeTerritories);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                throw new ApplicationException("Error al obtener los datos de EmployeeTerritories.", ex);
            }

            return Lista;
        }

        public static List<EmployeeTerritories> BuscarRegistroTerritoryDescription(string TerritoryDescription)
        {
            List<EmployeeTerritories> Lista = new List<EmployeeTerritories>();

            try
            {
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL con JOIN para obtener EmployeeID, TerritoryID, FirstName y TerritoryDescription
                    string query = @"
                SELECT et.EmployeeID, et.TerritoryID, e.FirstName, t.TerritoryDescription
                FROM EmployeeTerritories et
                INNER JOIN Employees e ON et.EmployeeID = e.EmployeeID
                INNER JOIN Territories t ON et.TerritoryID = t.TerritoryID
                WHERE t.TerritoryDescription = @TerritoryDescription";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@TerritoryDescription", TerritoryDescription); // Parámetro para evitar inyecciones SQL

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EmployeeTerritories employeeTerritories = new EmployeeTerritories();

                            // Asignar EmployeeID
                            employeeTerritories.EmployeeID = reader.GetInt32(0);

                            // Asignar TerritoryID
                            employeeTerritories.TerritoryID = reader.GetString(1);

                            // Asignar FirstName
                            if (!reader.IsDBNull(2)) // Verificar si FirstName no es nulo
                            {
                                employeeTerritories.FirstName = reader.GetString(2);
                            }

                            // Asignar TerritoryDescription
                            if (!reader.IsDBNull(3)) // Verificar si TerritoryDescription no es nulo
                            {
                                employeeTerritories.TerritoryDescription = reader.GetString(3);
                            }

                            Lista.Add(employeeTerritories);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                throw new ApplicationException("Error al obtener los datos de EmployeeTerritories.", ex);
            }

            return Lista;
        }

    }
}
