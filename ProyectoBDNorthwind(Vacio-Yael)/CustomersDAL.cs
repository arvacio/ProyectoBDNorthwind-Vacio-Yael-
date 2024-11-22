using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDNorthwind_Vacio_Yael_
{
    public class CustomersDAL
    {
        public static int AgregarCustomer(Customers customer)
        {
            int result = 0;

            //try
            //{
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL para insertar un nuevo registro en la tabla Customers
                    string query = "INSERT INTO Customers (CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax) " +
                                   "VALUES (@CustomerID, @CompanyName, @ContactName, @ContactTitle, @Address, @City, @Region, @PostalCode, @Country, @Phone, @Fax)";

                    // Crear el comando SQL
                    SqlCommand comando = new SqlCommand(query, conexion);

                    // Asignar los parámetros a la consulta
                    comando.Parameters.AddWithValue("@CustomerID", customer.CustomerID);
                    comando.Parameters.AddWithValue("@CompanyName", customer.CompanyName);
                    comando.Parameters.AddWithValue("@ContactName", (object)customer.ContactName ?? DBNull.Value); // Si es null, asignar DBNull
                    comando.Parameters.AddWithValue("@ContactTitle", (object)customer.ContactTitle ?? DBNull.Value); // Si es null, asignar DBNull
                    comando.Parameters.AddWithValue("@Address", (object)customer.Address ?? DBNull.Value); // Si es null, asignar DBNull
                    comando.Parameters.AddWithValue("@City", (object)customer.City ?? DBNull.Value); // Si es null, asignar DBNull
                    comando.Parameters.AddWithValue("@Region", (object)customer.Region ?? DBNull.Value); // Si es null, asignar DBNull
                    comando.Parameters.AddWithValue("@PostalCode", (object)customer.PostalCode ?? DBNull.Value); // Si es null, asignar DBNull
                    comando.Parameters.AddWithValue("@Country", (object)customer.Country ?? DBNull.Value); // Si es null, asignar DBNull
                    comando.Parameters.AddWithValue("@Phone", (object)customer.Phone ?? DBNull.Value); // Si es null, asignar DBNull
                    comando.Parameters.AddWithValue("@Fax", (object)customer.Fax ?? DBNull.Value); // Si es null, asignar DBNull

                    // Ejecutar la consulta (inserción)
                    result = comando.ExecuteNonQuery();
                }
            //}
            //catch (SqlException ex)
            //{
            //    // Mostrar el mensaje de error si ocurre un problema al ejecutar el SQL
            //    MessageBox.Show("Error al agregar el cliente: " + ex.Message);
            //}

            return result;
        }

        public static List<Customers> PresentarRegistro()
        {
            List<Customers> Lista = new List<Customers>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Sentencia SQL para seleccionar todos los registros de la tabla Customers
                string query = "SELECT * FROM Customers";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Customers customer = new Customers();

                    // Recuperar datos de las columnas de la tabla Customers
                    customer.CustomerID = reader.GetString(0);  // CustomerID es de tipo nchar(5)
                    customer.CompanyName = reader.GetString(1);  // CompanyName es de tipo nvarchar(40)
                    customer.ContactName = reader.IsDBNull(2) ? null : reader.GetString(2);  // ContactName es nullable
                    customer.ContactTitle = reader.IsDBNull(3) ? null : reader.GetString(3);  // ContactTitle es nullable
                    customer.Address = reader.IsDBNull(4) ? null : reader.GetString(4);  // Address es nullable
                    customer.City = reader.IsDBNull(5) ? null : reader.GetString(5);  // City es nullable
                    customer.Region = reader.IsDBNull(6) ? null : reader.GetString(6);  // Region es nullable
                    customer.PostalCode = reader.IsDBNull(7) ? null : reader.GetString(7);  // PostalCode es nullable
                    customer.Country = reader.IsDBNull(8) ? null : reader.GetString(8);  // Country es nullable
                    customer.Phone = reader.IsDBNull(9) ? null : reader.GetString(9);  // Phone es nullable
                    customer.Fax = reader.IsDBNull(10) ? null : reader.GetString(10);  // Fax es nullable

                    // Agregar el objeto Customer a la lista
                    Lista.Add(customer);
                }

                conexion.Close();
                return Lista;
            }
        }

        public static int ModificarCustomer(Customers customer)
        {
            int result = 0;

            // Abrir la conexión a la base de datos
            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Definir la consulta SQL para actualizar el registro de Customer
                string query = "UPDATE Customers SET CompanyName = @CompanyName, ContactName = @ContactName, ContactTitle = @ContactTitle, " +
                               "Address = @Address, City = @City, Region = @Region, PostalCode = @PostalCode, Country = @Country, " +
                               "Phone = @Phone, Fax = @Fax WHERE CustomerID = @CustomerID";

                // Crear el comando con la consulta y la conexión
                SqlCommand comando = new SqlCommand(query, conexion);

                // Asignar los parámetros de la consulta SQL
                comando.Parameters.AddWithValue("@CompanyName", customer.CompanyName);
                comando.Parameters.AddWithValue("@ContactName", customer.ContactName ?? (object)DBNull.Value);  // Usar DBNull.Value para valores null
                comando.Parameters.AddWithValue("@ContactTitle", customer.ContactTitle ?? (object)DBNull.Value);
                comando.Parameters.AddWithValue("@Address", customer.Address ?? (object)DBNull.Value);
                comando.Parameters.AddWithValue("@City", customer.City ?? (object)DBNull.Value);
                comando.Parameters.AddWithValue("@Region", customer.Region ?? (object)DBNull.Value);
                comando.Parameters.AddWithValue("@PostalCode", customer.PostalCode ?? (object)DBNull.Value);
                comando.Parameters.AddWithValue("@Country", customer.Country ?? (object)DBNull.Value);
                comando.Parameters.AddWithValue("@Phone", customer.Phone ?? (object)DBNull.Value);
                comando.Parameters.AddWithValue("@Fax", customer.Fax ?? (object)DBNull.Value);

                // El parámetro que identifica el registro a modificar
                comando.Parameters.AddWithValue("@CustomerID", customer.CustomerID);

                // Ejecutar el comando y obtener el número de filas afectadas
                result = comando.ExecuteNonQuery();
            }

            return result;  // Retornar el número de filas afectadas (0 si no se modificó nada)
        }


        public static int EliminarCustomer(string customerID)
        {
            int retorna = 0;

            // Usamos 'using' para asegurarnos de que la conexión se cierre automáticamente
            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Sentencia SQL para eliminar un cliente de la tabla Customers
                string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadimos el parámetro que se usará en la consulta
                comando.Parameters.AddWithValue("@CustomerID", customerID);

                // Ejecutamos la consulta y obtenemos el número de filas afectadas
                retorna = comando.ExecuteNonQuery();
            }

            return retorna; // Retorna el número de filas afectadas
        }

        // Busquedas

        public static List<Customers> BuscarRegistroCustomerID(string customerID)
        {
            List<Customers> Lista = new List<Customers>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "SELECT * FROM Customers WHERE CustomerID = @CustomerID";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Se usa el parámetro para evitar inyección SQL
                comando.Parameters.AddWithValue("@CustomerID", customerID);

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Customers customer = new Customers
                    {
                        CustomerID = reader.GetString(0),  // CustomerID es de tipo nchar(5)
                        CompanyName = reader.GetString(1),
                        ContactName = reader.IsDBNull(2) ? null : reader.GetString(2),
                        ContactTitle = reader.IsDBNull(3) ? null : reader.GetString(3),
                        Address = reader.IsDBNull(4) ? null : reader.GetString(4),
                        City = reader.IsDBNull(5) ? null : reader.GetString(5),
                        Region = reader.IsDBNull(6) ? null : reader.GetString(6),
                        PostalCode = reader.IsDBNull(7) ? null : reader.GetString(7),
                        Country = reader.IsDBNull(8) ? null : reader.GetString(8),
                        Phone = reader.IsDBNull(9) ? null : reader.GetString(9)
                    };

                    Lista.Add(customer);
                }

                conexion.Close();
            }

            return Lista;
        }

        public static List<Customers> BuscarRegistroCompanyName(string companyName)
        {
            List<Customers> Lista = new List<Customers>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "SELECT * FROM Customers WHERE CompanyName LIKE @CompanyName";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Se usa el parámetro para evitar inyección SQL y el LIKE para hacer búsqueda parcial
                comando.Parameters.AddWithValue("@CompanyName", "%" + companyName + "%");

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Customers customer = new Customers
                    {
                        CustomerID = reader.GetString(0),  // CustomerID es de tipo nchar(5)
                        CompanyName = reader.GetString(1),
                        ContactName = reader.IsDBNull(2) ? null : reader.GetString(2),
                        ContactTitle = reader.IsDBNull(3) ? null : reader.GetString(3),
                        Address = reader.IsDBNull(4) ? null : reader.GetString(4),
                        City = reader.IsDBNull(5) ? null : reader.GetString(5),
                        Region = reader.IsDBNull(6) ? null : reader.GetString(6),
                        PostalCode = reader.IsDBNull(7) ? null : reader.GetString(7),
                        Country = reader.IsDBNull(8) ? null : reader.GetString(8),
                        Phone = reader.IsDBNull(9) ? null : reader.GetString(9)
                    };

                    Lista.Add(customer);
                }

                conexion.Close();
            }

            return Lista;
        }

        public static List<Customers> BuscarRegistroContactName(string contactName)
        {
            List<Customers> Lista = new List<Customers>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "SELECT * FROM Customers WHERE ContactName LIKE @ContactName";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Usamos el parámetro y el LIKE para hacer una búsqueda parcial
                comando.Parameters.AddWithValue("@ContactName", "%" + contactName + "%");

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Customers customer = new Customers
                    {
                        CustomerID = reader.GetString(0),  // CustomerID es de tipo nchar(5)
                        CompanyName = reader.GetString(1),
                        ContactName = reader.IsDBNull(2) ? null : reader.GetString(2),
                        ContactTitle = reader.IsDBNull(3) ? null : reader.GetString(3),
                        Address = reader.IsDBNull(4) ? null : reader.GetString(4),
                        City = reader.IsDBNull(5) ? null : reader.GetString(5),
                        Region = reader.IsDBNull(6) ? null : reader.GetString(6),
                        PostalCode = reader.IsDBNull(7) ? null : reader.GetString(7),
                        Country = reader.IsDBNull(8) ? null : reader.GetString(8),
                        Phone = reader.IsDBNull(9) ? null : reader.GetString(9)
                    };

                    Lista.Add(customer);
                }

                conexion.Close();
            }

            return Lista;
        }

        public static List<Customers> BuscarRegistroContactTitle(string contactTitle)
        {
            List<Customers> Lista = new List<Customers>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "SELECT * FROM Customers WHERE ContactTitle LIKE @ContactTitle";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Usamos el parámetro y el LIKE para hacer una búsqueda parcial
                comando.Parameters.AddWithValue("@ContactTitle", "%" + contactTitle + "%");

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Customers customer = new Customers
                    {
                        CustomerID = reader.GetString(0),  // CustomerID es de tipo nchar(5)
                        CompanyName = reader.GetString(1),
                        ContactName = reader.IsDBNull(2) ? null : reader.GetString(2),
                        ContactTitle = reader.IsDBNull(3) ? null : reader.GetString(3),
                        Address = reader.IsDBNull(4) ? null : reader.GetString(4),
                        City = reader.IsDBNull(5) ? null : reader.GetString(5),
                        Region = reader.IsDBNull(6) ? null : reader.GetString(6),
                        PostalCode = reader.IsDBNull(7) ? null : reader.GetString(7),
                        Country = reader.IsDBNull(8) ? null : reader.GetString(8),
                        Phone = reader.IsDBNull(9) ? null : reader.GetString(9)
                    };

                    Lista.Add(customer);
                }

                conexion.Close();
            }

            return Lista;
        }

        public static List<Customers> BuscarRegistroAddress(string address)
        {
            List<Customers> Lista = new List<Customers>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL para buscar clientes cuyo campo 'Address' contenga el texto buscado
                string query = "SELECT * FROM Customers WHERE Address LIKE @Address";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Usamos el operador LIKE para permitir búsqueda parcial
                comando.Parameters.AddWithValue("@Address", "%" + address + "%");

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Customers customer = new Customers
                    {
                        CustomerID = reader.GetString(0),  // CustomerID es de tipo nchar(5)
                        CompanyName = reader.GetString(1),
                        ContactName = reader.IsDBNull(2) ? null : reader.GetString(2),
                        ContactTitle = reader.IsDBNull(3) ? null : reader.GetString(3),
                        Address = reader.IsDBNull(4) ? null : reader.GetString(4),
                        City = reader.IsDBNull(5) ? null : reader.GetString(5),
                        Region = reader.IsDBNull(6) ? null : reader.GetString(6),
                        PostalCode = reader.IsDBNull(7) ? null : reader.GetString(7),
                        Country = reader.IsDBNull(8) ? null : reader.GetString(8),
                        Phone = reader.IsDBNull(9) ? null : reader.GetString(9)
                    };

                    Lista.Add(customer);
                }

                conexion.Close();
            }

            return Lista;
        }

        public static List<Customers> BuscarRegistroCity(string city)
        {
            List<Customers> Lista = new List<Customers>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL para buscar clientes cuyo campo 'City' contenga el texto buscado
                string query = "SELECT * FROM Customers WHERE City LIKE @City";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Usamos el operador LIKE para permitir búsqueda parcial
                comando.Parameters.AddWithValue("@City", "%" + city + "%");

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Customers customer = new Customers
                    {
                        CustomerID = reader.GetString(0),  // CustomerID es de tipo nchar(5)
                        CompanyName = reader.GetString(1),
                        ContactName = reader.IsDBNull(2) ? null : reader.GetString(2),
                        ContactTitle = reader.IsDBNull(3) ? null : reader.GetString(3),
                        Address = reader.IsDBNull(4) ? null : reader.GetString(4),
                        City = reader.IsDBNull(5) ? null : reader.GetString(5),
                        Region = reader.IsDBNull(6) ? null : reader.GetString(6),
                        PostalCode = reader.IsDBNull(7) ? null : reader.GetString(7),
                        Country = reader.IsDBNull(8) ? null : reader.GetString(8),
                        Phone = reader.IsDBNull(9) ? null : reader.GetString(9)
                    };

                    Lista.Add(customer);
                }

                conexion.Close();
            }

            return Lista;
        }

        public static List<Customers> BuscarRegistroRegion(string region)
        {
            List<Customers> Lista = new List<Customers>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL para buscar clientes cuyo campo 'Region' contenga el texto buscado
                string query = "SELECT * FROM Customers WHERE Region LIKE @Region";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Usamos el operador LIKE para permitir búsqueda parcial
                comando.Parameters.AddWithValue("@Region", "%" + region + "%");

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Customers customer = new Customers
                    {
                        CustomerID = reader.GetString(0),  // CustomerID es de tipo nchar(5)
                        CompanyName = reader.GetString(1),
                        ContactName = reader.IsDBNull(2) ? null : reader.GetString(2),
                        ContactTitle = reader.IsDBNull(3) ? null : reader.GetString(3),
                        Address = reader.IsDBNull(4) ? null : reader.GetString(4),
                        City = reader.IsDBNull(5) ? null : reader.GetString(5),
                        Region = reader.IsDBNull(6) ? null : reader.GetString(6),
                        PostalCode = reader.IsDBNull(7) ? null : reader.GetString(7),
                        Country = reader.IsDBNull(8) ? null : reader.GetString(8),
                        Phone = reader.IsDBNull(9) ? null : reader.GetString(9)
                    };

                    Lista.Add(customer);
                }

                conexion.Close();
            }

            return Lista;
        }

        public static List<Customers> BuscarRegistroPostalCode(string postalCode)
        {
            List<Customers> Lista = new List<Customers>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL para buscar clientes cuyo campo 'PostalCode' contenga el texto buscado
                string query = "SELECT * FROM Customers WHERE PostalCode LIKE @PostalCode";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Usamos el operador LIKE para permitir búsqueda parcial
                comando.Parameters.AddWithValue("@PostalCode", "%" + postalCode + "%");

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Customers customer = new Customers
                    {
                        CustomerID = reader.GetString(0),  // CustomerID es de tipo nchar(5)
                        CompanyName = reader.GetString(1),
                        ContactName = reader.IsDBNull(2) ? null : reader.GetString(2),
                        ContactTitle = reader.IsDBNull(3) ? null : reader.GetString(3),
                        Address = reader.IsDBNull(4) ? null : reader.GetString(4),
                        City = reader.IsDBNull(5) ? null : reader.GetString(5),
                        Region = reader.IsDBNull(6) ? null : reader.GetString(6),
                        PostalCode = reader.IsDBNull(7) ? null : reader.GetString(7),
                        Country = reader.IsDBNull(8) ? null : reader.GetString(8),
                        Phone = reader.IsDBNull(9) ? null : reader.GetString(9)
                    };

                    Lista.Add(customer);
                }

                conexion.Close();
            }

            return Lista;
        }

        public static List<Customers> BuscarRegistroCountry(string country)
        {
            List<Customers> Lista = new List<Customers>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL para buscar clientes cuyo campo 'Country' contenga el texto buscado
                string query = "SELECT * FROM Customers WHERE Country LIKE @Country";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Usamos el operador LIKE para permitir búsqueda parcial
                comando.Parameters.AddWithValue("@Country", "%" + country + "%");

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Customers customer = new Customers
                    {
                        CustomerID = reader.GetString(0),  // CustomerID es de tipo nchar(5)
                        CompanyName = reader.GetString(1),
                        ContactName = reader.IsDBNull(2) ? null : reader.GetString(2),
                        ContactTitle = reader.IsDBNull(3) ? null : reader.GetString(3),
                        Address = reader.IsDBNull(4) ? null : reader.GetString(4),
                        City = reader.IsDBNull(5) ? null : reader.GetString(5),
                        Region = reader.IsDBNull(6) ? null : reader.GetString(6),
                        PostalCode = reader.IsDBNull(7) ? null : reader.GetString(7),
                        Country = reader.IsDBNull(8) ? null : reader.GetString(8),
                        Phone = reader.IsDBNull(9) ? null : reader.GetString(9)
                    };

                    Lista.Add(customer);
                }

                conexion.Close();
            }

            return Lista;
        }

        public static List<Customers> BuscarRegistroPhone(string phone)
        {
            List<Customers> Lista = new List<Customers>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL para buscar clientes cuyo campo 'Phone' contenga el texto buscado
                string query = "SELECT * FROM Customers WHERE Phone LIKE @Phone";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Usamos el operador LIKE para permitir búsqueda parcial
                comando.Parameters.AddWithValue("@Phone", "%" + phone + "%");

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Customers customer = new Customers
                    {
                        CustomerID = reader.GetString(0),  // CustomerID es de tipo nchar(5)
                        CompanyName = reader.GetString(1),
                        ContactName = reader.IsDBNull(2) ? null : reader.GetString(2),
                        ContactTitle = reader.IsDBNull(3) ? null : reader.GetString(3),
                        Address = reader.IsDBNull(4) ? null : reader.GetString(4),
                        City = reader.IsDBNull(5) ? null : reader.GetString(5),
                        Region = reader.IsDBNull(6) ? null : reader.GetString(6),
                        PostalCode = reader.IsDBNull(7) ? null : reader.GetString(7),
                        Country = reader.IsDBNull(8) ? null : reader.GetString(8),
                        Phone = reader.IsDBNull(9) ? null : reader.GetString(9)
                    };

                    Lista.Add(customer);
                }

                conexion.Close();
            }

            return Lista;
        }




    }
}
