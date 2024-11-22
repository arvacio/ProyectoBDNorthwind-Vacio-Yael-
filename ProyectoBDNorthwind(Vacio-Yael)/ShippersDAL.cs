using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDNorthwind_Vacio_Yael_
{
    public class ShippersDAL
    {
        public static int AgregarShipper(Shippers shipper)
        {
            int retorna = 0;

            try
            {
                // Abrimos la conexión con la base de datos
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL para insertar un nuevo registro en la tabla Shippers
                    string query = "INSERT INTO Shippers (CompanyName, Phone) " +
                                   "VALUES (@CompanyName, @Phone)";

                    // Usamos un comando SQL con la consulta
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        // Añadimos los parámetros con los valores proporcionados
                        comando.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 40).Value = shipper.CompanyName;
                        comando.Parameters.Add("@Phone", SqlDbType.NVarChar, 24).Value = (object)shipper.Phone ?? DBNull.Value; // En caso de que Phone sea null

                        // Ejecutamos la consulta y obtenemos el número de filas afectadas
                        retorna = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // Si ocurre un error SQL, mostramos el mensaje de error
                MessageBox.Show("Error al insertar: " + sqlEx.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Capturamos cualquier otro tipo de excepción (no SQL)
                MessageBox.Show("Error general: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Aquí podemos realizar alguna acción adicional si es necesario, como liberar recursos manualmente
            }

            // Retornamos el número de filas afectadas (0 si no se insertó nada)
            return retorna;
        }

        public static List<Shippers> PresentarRegistroShippers()
        {
            List<Shippers> lista = new List<Shippers>();

            try
            {
                // Abrimos la conexión a la base de datos
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL para obtener todos los registros de la tabla Shippers
                    string query = "SELECT ShipperID, CompanyName, Phone FROM Shippers";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        // Ejecutamos la consulta y obtenemos el lector de datos
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Iteramos sobre los registros obtenidos
                            while (reader.Read())
                            {
                                // Creamos un nuevo objeto de tipo Shipper
                                Shippers shipper = new Shippers();

                                // Asignamos los valores obtenidos a las propiedades del objeto
                                shipper.ShipperID = reader.GetInt32(0);  // ShipperID (int)
                                shipper.CompanyName = reader.GetString(1);  // CompanyName (nvarchar)
                                shipper.Phone = reader.IsDBNull(2) ? null : reader.GetString(2);  // Phone (nvarchar), puede ser null

                                // Añadimos el objeto a la lista
                                lista.Add(shipper);
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // Si ocurre un error, mostramos el mensaje correspondiente
                MessageBox.Show("Error al obtener los registros: " + sqlEx.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Capturamos cualquier otro tipo de excepción
                MessageBox.Show("Error general: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Retornamos la lista de registros obtenidos
            return lista;
        }


        public static int ModificarShippers(Shippers s)
        {
            int result = 0;

            try
            {
                // Abrimos la conexión a la base de datos
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL para actualizar un registro en la tabla Shippers
                    string query = "UPDATE Shippers SET " +
                                   "CompanyName = @CompanyName, " +
                                   "Phone = @Phone " +
                                   "WHERE ShipperID = @ShipperID";

                    // Usamos un comando SQL con la consulta
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        // Añadimos los parámetros con los valores proporcionados
                        comando.Parameters.Add("@ShipperID", SqlDbType.Int).Value = s.ShipperID;
                        comando.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 50).Value = s.CompanyName ?? (object)DBNull.Value; // Si es null, insertamos DBNull
                        comando.Parameters.Add("@Phone", SqlDbType.NVarChar, 24).Value = s.Phone ?? (object)DBNull.Value; // Si es null, insertamos DBNull

                        // Ejecutamos el comando y obtenemos el número de filas afectadas
                        result = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // Si ocurre una excepción SQL, mostramos el mensaje de error
                MessageBox.Show("Error al modificar el registro: " + sqlEx.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Capturamos cualquier otro tipo de excepción
                MessageBox.Show("Error general: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Retornamos el número de filas afectadas (0 si no se modificó nada)
            return result;
        }


        public static int EliminarShipper(int shipperId)
        {
            int result = 0;

            try
            {
                // Establecemos la conexión con la base de datos
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL para eliminar el registro en la tabla Shippers donde el ShipperID coincida
                    string query = "DELETE FROM Shippers WHERE ShipperID = @ShipperID";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        // Añadimos el parámetro para evitar inyecciones SQL
                        comando.Parameters.AddWithValue("@ShipperID", shipperId);

                        // Ejecutamos la consulta y obtenemos el número de filas afectadas
                        result = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // Si ocurre un error SQL, mostramos el mensaje de error
                MessageBox.Show("Error al eliminar el transportista: " + sqlEx.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Capturamos cualquier otro tipo de excepción
                MessageBox.Show("Error general: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Devolvemos el número de filas afectadas (0 si no se eliminó ningún registro, 1 si se eliminó correctamente)
            return result;
        }


        // Busquedas

        public static List<Shippers> BuscarRegistroShipperID(int shipperID)
        {
            List<Shippers> lista = new List<Shippers>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL para buscar por ShipperID
                string query = "SELECT * FROM Shippers WHERE ShipperID = @ShipperID";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadir el parámetro para evitar inyección SQL
                comando.Parameters.AddWithValue("@ShipperID", shipperID);

                try
                {
                    // Ejecutar la consulta
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Shippers shipper = new Shippers();

                        // Asignar valores de cada columna al objeto Shippers
                        shipper.ShipperID = reader.GetInt32(0);
                        shipper.CompanyName = reader.GetString(1);
                        shipper.Phone = reader.IsDBNull(2) ? null : reader.GetString(2);  // Se maneja el valor nulo de Phone

                        // Añadir el objeto a la lista
                        lista.Add(shipper);
                    }

                    conexion.Close();
                }
                catch (SqlException sqlEx)
                {
                    // Manejo de errores
                    MessageBox.Show("Error al realizar la búsqueda: " + sqlEx.Message);
                }

                return lista;
            }
        }

        public static List<Shippers> BuscarRegistroCompanyName(string companyName)
        {
            List<Shippers> lista = new List<Shippers>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL para buscar por CompanyName
                string query = "SELECT * FROM Shippers WHERE CompanyName LIKE @CompanyName";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadir el parámetro para evitar inyección SQL
                comando.Parameters.AddWithValue("@CompanyName", "%" + companyName + "%");  // Uso de LIKE para búsqueda parcial

                try
                {
                    // Ejecutar la consulta
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Shippers shipper = new Shippers();

                        // Asignar valores de cada columna al objeto Shippers
                        shipper.ShipperID = reader.GetInt32(0);  // Asumiendo que ShipperID es el primer campo
                        shipper.CompanyName = reader.GetString(1);
                        shipper.Phone = reader.IsDBNull(2) ? null : reader.GetString(2);  // Se maneja el valor nulo de Phone

                        // Añadir el objeto a la lista
                        lista.Add(shipper);
                    }

                    conexion.Close();
                }
                catch (SqlException sqlEx)
                {
                    // Manejo de errores
                    MessageBox.Show("Error al realizar la búsqueda: " + sqlEx.Message);
                }

                return lista;
            }
        }

        public static List<Shippers> BuscarRegistroPhone(string phone)
        {
            List<Shippers> lista = new List<Shippers>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL para buscar por Phone (usando LIKE para búsqueda parcial)
                string query = "SELECT * FROM Shippers WHERE Phone LIKE @Phone";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadir el parámetro para evitar inyección SQL
                comando.Parameters.AddWithValue("@Phone", "%" + phone + "%");  // Uso de LIKE para búsqueda parcial

                try
                {
                    // Ejecutar la consulta
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Shippers shipper = new Shippers();

                        // Asignar valores de cada columna al objeto Shippers
                        shipper.ShipperID = reader.GetInt32(0);  // Asumiendo que ShipperID es el primer campo
                        shipper.CompanyName = reader.GetString(1);
                        shipper.Phone = reader.IsDBNull(2) ? null : reader.GetString(2);  // Se maneja el valor nulo de Phone

                        // Añadir el objeto a la lista
                        lista.Add(shipper);
                    }

                    conexion.Close();
                }
                catch (SqlException sqlEx)
                {
                    // Manejo de errores
                    MessageBox.Show("Error al realizar la búsqueda: " + sqlEx.Message);
                }

                return lista;
            }
        }


    }
}
