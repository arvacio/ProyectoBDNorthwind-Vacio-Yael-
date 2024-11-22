using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDNorthwind_Vacio_Yael_
{
    public class CustomerCustomerDemoDAL
    {

        public static int AgregarCustomerCustomerDemo(CustomerCustomerDemo customerCustomerDemo)
        {
            int resultado = 0;

            try
            {
                // Abrimos la conexión con la base de datos
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL para insertar un nuevo registro en la tabla CustomerCustomerDemo
                    string query = "INSERT INTO CustomerCustomerDemo (CustomerID, CustomerTypeID) " +
                                   "VALUES (@CustomerID, @CustomerTypeID)";

                    // Creamos el comando SQL
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        // Añadimos los parámetros con los valores proporcionados
                        comando.Parameters.AddWithValue("@CustomerID", customerCustomerDemo.CustomerID);
                        comando.Parameters.AddWithValue("@CustomerTypeID", customerCustomerDemo.CustomerTypeID);

                        // Ejecutamos la consulta y obtenemos el número de filas afectadas
                        resultado = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // Si ocurre un error SQL, mostramos el mensaje de error
                MessageBox.Show("Error al insertar el registro en CustomerCustomerDemo: " + sqlEx.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Manejo de otros errores no esperados
                MessageBox.Show("Error general: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Retornamos el número de filas afectadas (0 si no se insertó nada)
            return resultado;
        }

        public static List<CustomerCustomerDemo> PresentarRegistroCustomerCustomerDemo()
        {
            List<CustomerCustomerDemo> lista = new List<CustomerCustomerDemo>();

            try
            {
                // Abrimos la conexión a la base de datos
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL para obtener todos los registros de la tabla CustomerCustomerDemo
                    string query = "SELECT CustomerID, CustomerTypeID FROM CustomerCustomerDemo";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    // Ejecutamos la consulta y obtenemos el lector de datos
                    SqlDataReader reader = comando.ExecuteReader();

                    // Iteramos sobre los registros obtenidos
                    while (reader.Read())
                    {
                        // Creamos un nuevo objeto de tipo CustomerCustomerDemo
                        CustomerCustomerDemo customerCustomerDemo = new CustomerCustomerDemo();

                        // Asignamos los valores obtenidos a las propiedades del objeto
                        customerCustomerDemo.CustomerID = reader.GetString(0);  // CustomerID (nchar(5))
                        customerCustomerDemo.CustomerTypeID = reader.GetString(1);  // CustomerTypeID (nchar(10))

                        // Añadimos el objeto a la lista
                        lista.Add(customerCustomerDemo);
                    }

                    // Cerramos la conexión después de usarla
                    conexion.Close();
                }
            }
            catch (SqlException sqlEx)
            {
                // Si ocurre un error, mostramos el mensaje correspondiente
                MessageBox.Show("Error al obtener los registros: " + sqlEx.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Retornamos la lista de registros obtenidos
            return lista;
        }

        public static int ModificarCustomerCustomerDemo(CustomerCustomerDemo customerCustomerDemo)
        {
            int result = 0;

            try
            {
                // Abrimos la conexión a la base de datos
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL para actualizar un registro en la tabla CustomerCustomerDemo
                    string query = "UPDATE CustomerCustomerDemo SET " +
                                   "CustomerTypeID = @CustomerTypeID " +
                                   "WHERE CustomerID = @CustomerID";

                    // Creamos el comando SQL y añadimos los parámetros
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@CustomerID", customerCustomerDemo.CustomerID);
                    comando.Parameters.AddWithValue("@CustomerTypeID", customerCustomerDemo.CustomerTypeID);

                    // Ejecutamos el comando
                    result = comando.ExecuteNonQuery();

                    // Cerramos la conexión
                    conexion.Close();
                }
            }
            catch (SqlException sqlEx)
            {
                // Si ocurre una excepción, mostramos un mensaje con el error
                MessageBox.Show("Error al modificar el registro: " + sqlEx.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Retornamos el número de filas afectadas
            return result;
        }

        public static int EliminarCustomerCustomerDemo(string customerID, string customerTypeID)
        {
            int result = 0;

            try
            {
                // Establecemos la conexión con la base de datos
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL para eliminar el registro en la tabla CustomerCustomerDemo
                    string query = "DELETE FROM CustomerCustomerDemo WHERE CustomerID = @CustomerID AND CustomerTypeID = @CustomerTypeID";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    // Añadimos los parámetros para evitar inyecciones SQL
                    comando.Parameters.AddWithValue("@CustomerID", customerID);
                    comando.Parameters.AddWithValue("@CustomerTypeID", customerTypeID);

                    // Ejecutamos la consulta
                    result = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                // Si ocurre un error, mostramos el mensaje correspondiente
                MessageBox.Show("Error al eliminar el registro: " + sqlEx.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Devolvemos el número de filas afectadas (0 si no se eliminó ningún registro, 1 si se eliminó correctamente)
            return result;
        }

        // Busquedas

        public static List<CustomerCustomerDemo> BuscarRegistroCustomerTypeID(string customerTypeID)
        {
            List<CustomerCustomerDemo> lista = new List<CustomerCustomerDemo>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL para buscar por CustomerTypeID
                string query = "SELECT * FROM CustomerCustomerDemo WHERE CustomerTypeID = @CustomerTypeID";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadir el parámetro para evitar inyección SQL
                comando.Parameters.AddWithValue("@CustomerTypeID", customerTypeID);

                try
                {
                    // Ejecutar la consulta
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        CustomerCustomerDemo customerCustomerDemo = new CustomerCustomerDemo();

                        // Asignar valores de cada columna al objeto CustomerDemographics
                        customerCustomerDemo.CustomerID = reader.GetString(0);  // CustomerTypeID (nchar)
                        customerCustomerDemo.CustomerTypeID = reader.GetString(1);  // CustomerDesc (ntext), manejamos DBNull

                        // Añadir el objeto a la lista
                        lista.Add(customerCustomerDemo);
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

        public static List<CustomerCustomerDemo> BuscarRegistroCustomerID(string customerID)
        {
            List<CustomerCustomerDemo> lista = new List<CustomerCustomerDemo>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL para buscar por CustomerTypeID
                string query = "SELECT * FROM CustomerCustomerDemo WHERE CustomerID = @CustomerID";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadir el parámetro para evitar inyección SQL
                comando.Parameters.AddWithValue("@CustomerID", customerID);

                try
                {
                    // Ejecutar la consulta
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        CustomerCustomerDemo customerCustomerDemo = new CustomerCustomerDemo();

                        // Asignar valores de cada columna al objeto CustomerDemographics
                        customerCustomerDemo.CustomerID = reader.GetString(0);  // CustomerTypeID (nchar)
                        customerCustomerDemo.CustomerTypeID = reader.GetString(1);  // CustomerDesc (ntext), manejamos DBNull

                        // Añadir el objeto a la lista
                        lista.Add(customerCustomerDemo);
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
