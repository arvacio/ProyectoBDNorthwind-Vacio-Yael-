using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDNorthwind_Vacio_Yael_
{
    public  class CustomerDemographicsDAL
    {
        public static int AgregarCustomerDemographics(CustomerDemographics customerDemographics)
        {
            int resultado = 0;

            try
            {
                // Abrimos la conexión con la base de datos
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL para insertar un nuevo registro en la tabla CustomerDemographics
                    string query = "INSERT INTO CustomerDemographics (CustomerTypeID, CustomerDesc) " +
                                   "VALUES (@CustomerTypeID, @CustomerDesc)";

                    // Creamos el comando SQL
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        // Añadimos los parámetros con los valores proporcionados
                        comando.Parameters.AddWithValue("@CustomerTypeID", customerDemographics.CustomerTypeID);
                        comando.Parameters.AddWithValue("@CustomerDesc", string.IsNullOrEmpty(customerDemographics.CustomerDesc) ? (object)DBNull.Value : customerDemographics.CustomerDesc);

                        // Ejecutamos la consulta y obtenemos el número de filas afectadas
                        resultado = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // Si ocurre un error SQL, mostramos el mensaje de error
                MessageBox.Show("Error al insertar el registro en CustomerDemographics: " + sqlEx.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Manejo de otros errores no esperados
                MessageBox.Show("Error general: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Retornamos el número de filas afectadas (0 si no se insertó nada)
            return resultado;
        }

        public static List<CustomerDemographics> PresentarRegistroCustomerDemographics()
        {
            List<CustomerDemographics> lista = new List<CustomerDemographics>();

            try
            {
                // Abrimos la conexión a la base de datos
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL para obtener todos los registros de la tabla CustomerDemographics
                    string query = "SELECT CustomerTypeID, CustomerDesc FROM CustomerDemographics";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    // Ejecutamos la consulta y obtenemos el lector de datos
                    SqlDataReader reader = comando.ExecuteReader();

                    // Iteramos sobre los registros obtenidos
                    while (reader.Read())
                    {
                        // Creamos un nuevo objeto de tipo CustomerDemographics
                        CustomerDemographics customerDemographics = new CustomerDemographics();

                        // Asignamos los valores obtenidos a las propiedades del objeto
                        customerDemographics.CustomerTypeID = reader.GetString(0);  // CustomerTypeID (nchar(10))
                        customerDemographics.CustomerDesc = reader.IsDBNull(1) ? null : reader.GetString(1);  // CustomerDesc (ntext)

                        // Añadimos el objeto a la lista
                        lista.Add(customerDemographics);
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

        public static int ModificarCustomerDemographics(CustomerDemographics customerDemographics)
        {
            int result = 0;

            try
            {
                // Abrimos la conexión a la base de datos
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL para actualizar un registro en la tabla CustomerDemographics
                    string query = "UPDATE CustomerDemographics SET " +
                                   "CustomerDesc = @CustomerDesc " +
                                   "WHERE CustomerTypeID = @CustomerTypeID";

                    // Creamos el comando SQL y añadimos los parámetros
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@CustomerTypeID", customerDemographics.CustomerTypeID);
                    comando.Parameters.AddWithValue("@CustomerDesc", customerDemographics.CustomerDesc ?? (object)DBNull.Value);

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

        public static int EliminarCustomerDemographics(string customerTypeId)
        {
            int result = 0;

            try
            {
                // Establecemos la conexión con la base de datos
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL para eliminar el registro en la tabla CustomerDemographics donde el CustomerTypeID coincida
                    string query = "DELETE FROM CustomerDemographics WHERE CustomerTypeID = @CustomerTypeID";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    // Añadimos el parámetro para evitar inyecciones SQL
                    comando.Parameters.AddWithValue("@CustomerTypeID", customerTypeId);

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

        public static List<CustomerDemographics> BuscarRegistroCustomerTypeID(string customerTypeID)
        {
            List<CustomerDemographics> lista = new List<CustomerDemographics>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL para buscar por CustomerTypeID
                string query = "SELECT * FROM CustomerDemographics WHERE CustomerTypeID = @CustomerTypeID";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadir el parámetro para evitar inyección SQL
                comando.Parameters.AddWithValue("@CustomerTypeID", customerTypeID);

                try
                {
                    // Ejecutar la consulta
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        CustomerDemographics customerDemographics = new CustomerDemographics();

                        // Asignar valores de cada columna al objeto CustomerDemographics
                        customerDemographics.CustomerTypeID = reader.GetString(0);  // CustomerTypeID (nchar)
                        customerDemographics.CustomerDesc = reader.IsDBNull(1) ? null : reader.GetString(1);  // CustomerDesc (ntext), manejamos DBNull

                        // Añadir el objeto a la lista
                        lista.Add(customerDemographics);
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

                try
                {
                    using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                    {
                        // Consulta SQL para buscar por CustomerID
                        string query = "SELECT CustomerID, CustomerTypeID FROM CustomerCustomerDemo WHERE CustomerID = @CustomerID";
                        SqlCommand comando = new SqlCommand(query, conexion);

                        // Añadir el parámetro para evitar inyección SQL
                        comando.Parameters.AddWithValue("@CustomerID", customerID);

                        // Ejecutar la consulta
                        SqlDataReader reader = comando.ExecuteReader();

                        // Iterar sobre los registros obtenidos
                        while (reader.Read())
                        {
                            // Crear un objeto CustomerCustomerDemo
                            CustomerCustomerDemo customerCustomerDemo = new CustomerCustomerDemo();

                            // Asignar los valores de cada columna al objeto
                            customerCustomerDemo.CustomerID = reader.GetString(0); // CustomerID (nchar(5))
                            customerCustomerDemo.CustomerTypeID = reader.GetString(1); // CustomerTypeID (nchar(10))

                            // Añadir el objeto a la lista
                            lista.Add(customerCustomerDemo);
                        }

                        // Cerrar la conexión
                        conexion.Close();
                    }
                }
                catch (SqlException sqlEx)
                {
                    // Si ocurre un error, mostrar el mensaje correspondiente
                    MessageBox.Show("Error al realizar la búsqueda: " + sqlEx.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Retornar la lista de resultados
                return lista;
            }
    }
}
