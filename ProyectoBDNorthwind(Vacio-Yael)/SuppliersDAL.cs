using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDNorthwind_Vacio_Yael_
{
    public class SuppliersDAL
    {

        // Código para agregar un Supplier
        public static int AgregarSupplier(Suppliers supplier)
            {
                int retorna = 0;

                try
                {
                    using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                    {
                        // Sentencia SQL para insertar un nuevo proveedor en la tabla Suppliers
                        string query = "INSERT INTO Suppliers (CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage) " +
                                       "VALUES (@CompanyName, @ContactName, @ContactTitle, @Address, @City, @Region, @PostalCode, @Country, @Phone, @Fax, @HomePage)";

                        SqlCommand comando = new SqlCommand(query, conexion);
                        comando.Parameters.AddWithValue("@CompanyName", supplier.CompanyName);
                        comando.Parameters.AddWithValue("@ContactName", supplier.ContactName ?? (object)DBNull.Value);  // Usar DBNull para valores null
                        comando.Parameters.AddWithValue("@ContactTitle", supplier.ContactTitle ?? (object)DBNull.Value);
                        comando.Parameters.AddWithValue("@Address", supplier.Address ?? (object)DBNull.Value);
                        comando.Parameters.AddWithValue("@City", supplier.City ?? (object)DBNull.Value);
                        comando.Parameters.AddWithValue("@Region", supplier.Region ?? (object)DBNull.Value);
                        comando.Parameters.AddWithValue("@PostalCode", supplier.PostalCode ?? (object)DBNull.Value);
                        comando.Parameters.AddWithValue("@Country", supplier.Country ?? (object)DBNull.Value);
                        comando.Parameters.AddWithValue("@Phone", supplier.Phone ?? (object)DBNull.Value);
                        comando.Parameters.AddWithValue("@Fax", supplier.Fax ?? (object)DBNull.Value);
                        comando.Parameters.AddWithValue("@HomePage", supplier.HomePage ?? (object)DBNull.Value);

                        // Ejecutar la consulta y retornar el número de filas afectadas
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

        public static List<Suppliers> PresentarRegistro()
        {
            List<Suppliers> Lista = new List<Suppliers>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Sentencia SQL para seleccionar todos los registros de la tabla Suppliers
                string query = "SELECT * FROM Suppliers";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Suppliers supplier = new Suppliers();

                    // Recuperar datos de las columnas de la tabla Suppliers
                    supplier.SupplierID = reader.GetInt32(0);  // SupplierID es de tipo int
                    supplier.CompanyName = reader.GetString(1);  // CompanyName es de tipo nvarchar(40)
                    supplier.ContactName = reader.IsDBNull(2) ? null : reader.GetString(2);  // ContactName es nullable
                    supplier.ContactTitle = reader.IsDBNull(3) ? null : reader.GetString(3);  // ContactTitle es nullable
                    supplier.Address = reader.IsDBNull(4) ? null : reader.GetString(4);  // Address es nullable
                    supplier.City = reader.IsDBNull(5) ? null : reader.GetString(5);  // City es nullable
                    supplier.Region = reader.IsDBNull(6) ? null : reader.GetString(6);  // Region es nullable
                    supplier.PostalCode = reader.IsDBNull(7) ? null : reader.GetString(7);  // PostalCode es nullable
                    supplier.Country = reader.IsDBNull(8) ? null : reader.GetString(8);  // Country es nullable
                    supplier.Phone = reader.IsDBNull(9) ? null : reader.GetString(9);  // Phone es nullable
                    supplier.Fax = reader.IsDBNull(10) ? null : reader.GetString(10);  // Fax es nullable
                    supplier.HomePage = reader.IsDBNull(11) ? null : reader.GetString(11);  // HomePage es nullable

                    // Agregar el objeto Supplier a la lista
                    Lista.Add(supplier);
                }

                conexion.Close();
                return Lista;
            }
        }

        public static int ModificarSupplier(Suppliers supplier)
        {
            int result = 0;

            // Establecer la conexión con la base de datos
            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Sentencia SQL para actualizar un proveedor en la tabla Suppliers
                string query = "UPDATE Suppliers SET CompanyName = @CompanyName, ContactName = @ContactName, ContactTitle = @ContactTitle, " +
                               "Address = @Address, City = @City, Region = @Region, PostalCode = @PostalCode, Country = @Country, " +
                               "Phone = @Phone, Fax = @Fax, HomePage = @HomePage WHERE SupplierID = @SupplierID";

                // Crear el comando SQL
                SqlCommand comando = new SqlCommand(query, conexion);

                // Agregar los parámetros con valores del objeto Supplier
                comando.Parameters.AddWithValue("@CompanyName", supplier.CompanyName);

                // Usamos DBNull.Value para manejar los valores nulos en los campos opcionales
                comando.Parameters.AddWithValue("@ContactName", supplier.ContactName ?? (object)DBNull.Value);
                comando.Parameters.AddWithValue("@ContactTitle", supplier.ContactTitle ?? (object)DBNull.Value);
                comando.Parameters.AddWithValue("@Address", supplier.Address ?? (object)DBNull.Value);
                comando.Parameters.AddWithValue("@City", supplier.City ?? (object)DBNull.Value);
                comando.Parameters.AddWithValue("@Region", supplier.Region ?? (object)DBNull.Value);
                comando.Parameters.AddWithValue("@PostalCode", supplier.PostalCode ?? (object)DBNull.Value);
                comando.Parameters.AddWithValue("@Country", supplier.Country ?? (object)DBNull.Value);
                comando.Parameters.AddWithValue("@Phone", supplier.Phone ?? (object)DBNull.Value);
                comando.Parameters.AddWithValue("@Fax", supplier.Fax ?? (object)DBNull.Value);
                comando.Parameters.AddWithValue("@HomePage", supplier.HomePage ?? (object)DBNull.Value);

                // Para identificar el proveedor que se va a modificar, pasamos el SupplierID
                comando.Parameters.AddWithValue("@SupplierID", supplier.SupplierID);

                try
                {
                    // Ejecutar la consulta y obtener el número de filas afectadas
                    result = comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // En caso de error, puedes registrar el error o manejarlo de alguna manera
                    Console.WriteLine($"Error al modificar proveedor: {ex.Message}");
                    MessageBox.Show($"Error al modificar proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Asegurarse de cerrar la conexión
                    conexion.Close();
                }
            }

            return result;  // Retorna el número de filas afectadas por la actualización
        }


        public static int EliminarSupplier(int id)
        {
            int retorna = 0;

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Usamos parámetros para evitar inyección SQL
                string query = "DELETE FROM Suppliers WHERE SupplierID = @SupplierID";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadimos el parámetro que se usará en la consulta
                comando.Parameters.AddWithValue("@SupplierID", id);

                // Ejecutamos la consulta y obtenemos el número de filas afectadas
                retorna = comando.ExecuteNonQuery();
            }

            return retorna;
        }

        // Busquedas

        public static List<Suppliers> BuscarRegistroSupplierID(int SupplierID)
        {
            List<Suppliers> Lista = new List<Suppliers>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL para buscar por SupplierID
                string query = "SELECT * FROM Suppliers WHERE SupplierID = @SupplierID";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Se agrega el parámetro SupplierID para evitar inyección SQL
                comando.Parameters.AddWithValue("@SupplierID", SupplierID);

                // Ejecutamos la consulta y obtenemos el lector de datos
                SqlDataReader reader = comando.ExecuteReader();

                // Mientras haya registros
                while (reader.Read())
                {
                    Suppliers supplier = new Suppliers();

                    // Asignar valores de cada columna al objeto Supplier
                    supplier.SupplierID = reader.GetInt32(0);
                    supplier.CompanyName = reader.GetString(1);
                    supplier.ContactName = reader.IsDBNull(2) ? null : reader.GetString(2);
                    supplier.ContactTitle = reader.IsDBNull(3) ? null : reader.GetString(3);
                    supplier.Address = reader.IsDBNull(4) ? null : reader.GetString(4);
                    supplier.City = reader.IsDBNull(5) ? null : reader.GetString(5);
                    supplier.Region = reader.IsDBNull(6) ? null : reader.GetString(6);
                    supplier.PostalCode = reader.IsDBNull(7) ? null : reader.GetString(7);
                    supplier.Country = reader.IsDBNull(8) ? null : reader.GetString(8);
                    supplier.Phone = reader.IsDBNull(9) ? null : reader.GetString(9);
                    supplier.Fax = reader.IsDBNull(10) ? null : reader.GetString(10);
                    supplier.HomePage = reader.IsDBNull(11) ? null : reader.GetString(11);

                    // Añadir el proveedor a la lista
                    Lista.Add(supplier);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static List<Suppliers> BuscarRegistroCompanyName(string companyName)
        {
            List<Suppliers> Lista = new List<Suppliers>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL para buscar por CompanyName
                string query = "SELECT * FROM Suppliers WHERE CompanyName LIKE @CompanyName";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Usamos LIKE con un comodín '%' para buscar coincidencias parciales en el nombre de la empresa
                comando.Parameters.AddWithValue("@CompanyName", "%" + companyName + "%");

                // Ejecutamos la consulta y obtenemos el lector de datos
                SqlDataReader reader = comando.ExecuteReader();

                // Mientras haya registros
                while (reader.Read())
                {
                    Suppliers supplier = new Suppliers();

                    // Asignar valores de cada columna al objeto Supplier
                    supplier.SupplierID = reader.GetInt32(0);
                    supplier.CompanyName = reader.GetString(1);
                    supplier.ContactName = reader.IsDBNull(2) ? null : reader.GetString(2);
                    supplier.ContactTitle = reader.IsDBNull(3) ? null : reader.GetString(3);
                    supplier.Address = reader.IsDBNull(4) ? null : reader.GetString(4);
                    supplier.City = reader.IsDBNull(5) ? null : reader.GetString(5);
                    supplier.Region = reader.IsDBNull(6) ? null : reader.GetString(6);
                    supplier.PostalCode = reader.IsDBNull(7) ? null : reader.GetString(7);
                    supplier.Country = reader.IsDBNull(8) ? null : reader.GetString(8);
                    supplier.Phone = reader.IsDBNull(9) ? null : reader.GetString(9);
                    supplier.Fax = reader.IsDBNull(10) ? null : reader.GetString(10);
                    supplier.HomePage = reader.IsDBNull(11) ? null : reader.GetString(11);

                    // Añadir el proveedor a la lista
                    Lista.Add(supplier);
                }
                conexion.Close();
                return Lista;
            }
        }


        public static List<Suppliers> BuscarRegistroContactName(string contactName)
        {
            List<Suppliers> Lista = new List<Suppliers>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL para buscar por ContactName
                string query = "SELECT * FROM Suppliers WHERE ContactName LIKE @ContactName";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Usamos LIKE con un comodín '%' para buscar coincidencias parciales en el nombre de contacto
                comando.Parameters.AddWithValue("@ContactName", "%" + contactName + "%");

                // Ejecutamos la consulta y obtenemos el lector de datos
                SqlDataReader reader = comando.ExecuteReader();

                // Mientras haya registros
                while (reader.Read())
                {
                    Suppliers supplier = new Suppliers();

                    // Asignar valores de cada columna al objeto Supplier
                    supplier.SupplierID = reader.GetInt32(0);
                    supplier.CompanyName = reader.GetString(1);
                    supplier.ContactName = reader.IsDBNull(2) ? null : reader.GetString(2);
                    supplier.ContactTitle = reader.IsDBNull(3) ? null : reader.GetString(3);
                    supplier.Address = reader.IsDBNull(4) ? null : reader.GetString(4);
                    supplier.City = reader.IsDBNull(5) ? null : reader.GetString(5);
                    supplier.Region = reader.IsDBNull(6) ? null : reader.GetString(6);
                    supplier.PostalCode = reader.IsDBNull(7) ? null : reader.GetString(7);
                    supplier.Country = reader.IsDBNull(8) ? null : reader.GetString(8);
                    supplier.Phone = reader.IsDBNull(9) ? null : reader.GetString(9);
                    supplier.Fax = reader.IsDBNull(10) ? null : reader.GetString(10);
                    supplier.HomePage = reader.IsDBNull(11) ? null : reader.GetString(11);

                    // Añadir el proveedor a la lista
                    Lista.Add(supplier);
                }
                conexion.Close();
                return Lista;
            }
        }


        public static List<Suppliers> BuscarRegistroContactTitle(string contactTitle)
        {
            List<Suppliers> Lista = new List<Suppliers>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL para buscar por ContactTitle
                string query = "SELECT * FROM Suppliers WHERE ContactTitle LIKE @ContactTitle";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Usamos LIKE con un comodín '%' para buscar coincidencias parciales en el título de contacto
                comando.Parameters.AddWithValue("@ContactTitle", "%" + contactTitle + "%");

                // Ejecutamos la consulta y obtenemos el lector de datos
                SqlDataReader reader = comando.ExecuteReader();

                // Mientras haya registros
                while (reader.Read())
                {
                    Suppliers supplier = new Suppliers();

                    // Asignar valores de cada columna al objeto Supplier
                    supplier.SupplierID = reader.GetInt32(0);
                    supplier.CompanyName = reader.GetString(1);
                    supplier.ContactName = reader.IsDBNull(2) ? null : reader.GetString(2);
                    supplier.ContactTitle = reader.IsDBNull(3) ? null : reader.GetString(3);
                    supplier.Address = reader.IsDBNull(4) ? null : reader.GetString(4);
                    supplier.City = reader.IsDBNull(5) ? null : reader.GetString(5);
                    supplier.Region = reader.IsDBNull(6) ? null : reader.GetString(6);
                    supplier.PostalCode = reader.IsDBNull(7) ? null : reader.GetString(7);
                    supplier.Country = reader.IsDBNull(8) ? null : reader.GetString(8);
                    supplier.Phone = reader.IsDBNull(9) ? null : reader.GetString(9);
                    supplier.Fax = reader.IsDBNull(10) ? null : reader.GetString(10);
                    supplier.HomePage = reader.IsDBNull(11) ? null : reader.GetString(11);

                    // Añadir el proveedor a la lista
                    Lista.Add(supplier);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static List<Suppliers> BuscarRegistroAddress(string address)
        {
            List<Suppliers> Lista = new List<Suppliers>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL para buscar por Address
                string query = "SELECT * FROM Suppliers WHERE Address LIKE @Address";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Usamos LIKE con un comodín '%' para buscar coincidencias parciales en la dirección
                comando.Parameters.AddWithValue("@Address", "%" + address + "%");

                // Ejecutamos la consulta y obtenemos el lector de datos
                SqlDataReader reader = comando.ExecuteReader();

                // Mientras haya registros
                while (reader.Read())
                {
                    Suppliers supplier = new Suppliers();

                    // Asignar valores de cada columna al objeto Supplier
                    supplier.SupplierID = reader.GetInt32(0);
                    supplier.CompanyName = reader.GetString(1);
                    supplier.ContactName = reader.IsDBNull(2) ? null : reader.GetString(2);
                    supplier.ContactTitle = reader.IsDBNull(3) ? null : reader.GetString(3);
                    supplier.Address = reader.IsDBNull(4) ? null : reader.GetString(4);
                    supplier.City = reader.IsDBNull(5) ? null : reader.GetString(5);
                    supplier.Region = reader.IsDBNull(6) ? null : reader.GetString(6);
                    supplier.PostalCode = reader.IsDBNull(7) ? null : reader.GetString(7);
                    supplier.Country = reader.IsDBNull(8) ? null : reader.GetString(8);
                    supplier.Phone = reader.IsDBNull(9) ? null : reader.GetString(9);
                    supplier.Fax = reader.IsDBNull(10) ? null : reader.GetString(10);
                    supplier.HomePage = reader.IsDBNull(11) ? null : reader.GetString(11);

                    // Añadir el proveedor a la lista
                    Lista.Add(supplier);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static List<Suppliers> BuscarRegistroCity(string city)
        {
            List<Suppliers> Lista = new List<Suppliers>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL para buscar por City
                string query = "SELECT * FROM Suppliers WHERE City LIKE @City";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Usamos LIKE con un comodín '%' para buscar coincidencias parciales en la ciudad
                comando.Parameters.AddWithValue("@City", "%" + city + "%");

                // Ejecutamos la consulta y obtenemos el lector de datos
                SqlDataReader reader = comando.ExecuteReader();

                // Mientras haya registros
                while (reader.Read())
                {
                    Suppliers supplier = new Suppliers();

                    // Asignar valores de cada columna al objeto Supplier
                    supplier.SupplierID = reader.GetInt32(0);
                    supplier.CompanyName = reader.GetString(1);
                    supplier.ContactName = reader.IsDBNull(2) ? null : reader.GetString(2);
                    supplier.ContactTitle = reader.IsDBNull(3) ? null : reader.GetString(3);
                    supplier.Address = reader.IsDBNull(4) ? null : reader.GetString(4);
                    supplier.City = reader.IsDBNull(5) ? null : reader.GetString(5);
                    supplier.Region = reader.IsDBNull(6) ? null : reader.GetString(6);
                    supplier.PostalCode = reader.IsDBNull(7) ? null : reader.GetString(7);
                    supplier.Country = reader.IsDBNull(8) ? null : reader.GetString(8);
                    supplier.Phone = reader.IsDBNull(9) ? null : reader.GetString(9);
                    supplier.Fax = reader.IsDBNull(10) ? null : reader.GetString(10);
                    supplier.HomePage = reader.IsDBNull(11) ? null : reader.GetString(11);

                    // Añadir el proveedor a la lista
                    Lista.Add(supplier);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static List<Suppliers> BuscarRegistroRegion(string region)
        {
            List<Suppliers> Lista = new List<Suppliers>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL para buscar por Region
                string query = "SELECT * FROM Suppliers WHERE Region LIKE @Region";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Usamos LIKE con un comodín '%' para buscar coincidencias parciales en la región
                comando.Parameters.AddWithValue("@Region", "%" + region + "%");

                // Ejecutamos la consulta y obtenemos el lector de datos
                SqlDataReader reader = comando.ExecuteReader();

                // Mientras haya registros
                while (reader.Read())
                {
                    Suppliers supplier = new Suppliers();

                    // Asignar valores de cada columna al objeto Supplier
                    supplier.SupplierID = reader.GetInt32(0);
                    supplier.CompanyName = reader.GetString(1);
                    supplier.ContactName = reader.IsDBNull(2) ? null : reader.GetString(2);
                    supplier.ContactTitle = reader.IsDBNull(3) ? null : reader.GetString(3);
                    supplier.Address = reader.IsDBNull(4) ? null : reader.GetString(4);
                    supplier.City = reader.IsDBNull(5) ? null : reader.GetString(5);
                    supplier.Region = reader.IsDBNull(6) ? null : reader.GetString(6);
                    supplier.PostalCode = reader.IsDBNull(7) ? null : reader.GetString(7);
                    supplier.Country = reader.IsDBNull(8) ? null : reader.GetString(8);
                    supplier.Phone = reader.IsDBNull(9) ? null : reader.GetString(9);
                    supplier.Fax = reader.IsDBNull(10) ? null : reader.GetString(10);
                    supplier.HomePage = reader.IsDBNull(11) ? null : reader.GetString(11);

                    // Añadir el proveedor a la lista
                    Lista.Add(supplier);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static List<Suppliers> BuscarRegistroPostalCode(string postalCode)
        {
            List<Suppliers> Lista = new List<Suppliers>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL para buscar por PostalCode
                string query = "SELECT * FROM Suppliers WHERE PostalCode LIKE @PostalCode";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Usamos LIKE con un comodín '%' para buscar coincidencias parciales en el código postal
                comando.Parameters.AddWithValue("@PostalCode", "%" + postalCode + "%");

                // Ejecutamos la consulta y obtenemos el lector de datos
                SqlDataReader reader = comando.ExecuteReader();

                // Mientras haya registros
                while (reader.Read())
                {
                    Suppliers supplier = new Suppliers();

                    // Asignar valores de cada columna al objeto Supplier
                    supplier.SupplierID = reader.GetInt32(0);
                    supplier.CompanyName = reader.GetString(1);
                    supplier.ContactName = reader.IsDBNull(2) ? null : reader.GetString(2);
                    supplier.ContactTitle = reader.IsDBNull(3) ? null : reader.GetString(3);
                    supplier.Address = reader.IsDBNull(4) ? null : reader.GetString(4);
                    supplier.City = reader.IsDBNull(5) ? null : reader.GetString(5);
                    supplier.Region = reader.IsDBNull(6) ? null : reader.GetString(6);
                    supplier.PostalCode = reader.IsDBNull(7) ? null : reader.GetString(7);
                    supplier.Country = reader.IsDBNull(8) ? null : reader.GetString(8);
                    supplier.Phone = reader.IsDBNull(9) ? null : reader.GetString(9);
                    supplier.Fax = reader.IsDBNull(10) ? null : reader.GetString(10);
                    supplier.HomePage = reader.IsDBNull(11) ? null : reader.GetString(11);

                    // Añadir el proveedor a la lista
                    Lista.Add(supplier);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static List<Suppliers> BuscarRegistroCountry(string country)
        {
            List<Suppliers> Lista = new List<Suppliers>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL para buscar por Country
                string query = "SELECT * FROM Suppliers WHERE Country LIKE @Country";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Usamos LIKE con un comodín '%' para buscar coincidencias parciales en el país
                comando.Parameters.AddWithValue("@Country", "%" + country + "%");

                // Ejecutamos la consulta y obtenemos el lector de datos
                SqlDataReader reader = comando.ExecuteReader();

                // Mientras haya registros
                while (reader.Read())
                {
                    Suppliers supplier = new Suppliers();

                    // Asignar valores de cada columna al objeto Supplier
                    supplier.SupplierID = reader.GetInt32(0);
                    supplier.CompanyName = reader.GetString(1);
                    supplier.ContactName = reader.IsDBNull(2) ? null : reader.GetString(2);
                    supplier.ContactTitle = reader.IsDBNull(3) ? null : reader.GetString(3);
                    supplier.Address = reader.IsDBNull(4) ? null : reader.GetString(4);
                    supplier.City = reader.IsDBNull(5) ? null : reader.GetString(5);
                    supplier.Region = reader.IsDBNull(6) ? null : reader.GetString(6);
                    supplier.PostalCode = reader.IsDBNull(7) ? null : reader.GetString(7);
                    supplier.Country = reader.IsDBNull(8) ? null : reader.GetString(8);
                    supplier.Phone = reader.IsDBNull(9) ? null : reader.GetString(9);
                    supplier.Fax = reader.IsDBNull(10) ? null : reader.GetString(10);
                    supplier.HomePage = reader.IsDBNull(11) ? null : reader.GetString(11);

                    // Añadir el proveedor a la lista
                    Lista.Add(supplier);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static List<Suppliers> BuscarRegistroPhone(string phone)
        {
            List<Suppliers> Lista = new List<Suppliers>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL para buscar por Phone
                string query = "SELECT * FROM Suppliers WHERE Phone LIKE @Phone";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Usamos LIKE con un comodín '%' para buscar coincidencias parciales en el teléfono
                comando.Parameters.AddWithValue("@Phone", "%" + phone + "%");

                // Ejecutamos la consulta y obtenemos el lector de datos
                SqlDataReader reader = comando.ExecuteReader();

                // Mientras haya registros
                while (reader.Read())
                {
                    Suppliers supplier = new Suppliers();

                    // Asignar valores de cada columna al objeto Supplier
                    supplier.SupplierID = reader.GetInt32(0);
                    supplier.CompanyName = reader.GetString(1);
                    supplier.ContactName = reader.IsDBNull(2) ? null : reader.GetString(2);
                    supplier.ContactTitle = reader.IsDBNull(3) ? null : reader.GetString(3);
                    supplier.Address = reader.IsDBNull(4) ? null : reader.GetString(4);
                    supplier.City = reader.IsDBNull(5) ? null : reader.GetString(5);
                    supplier.Region = reader.IsDBNull(6) ? null : reader.GetString(6);
                    supplier.PostalCode = reader.IsDBNull(7) ? null : reader.GetString(7);
                    supplier.Country = reader.IsDBNull(8) ? null : reader.GetString(8);
                    supplier.Phone = reader.IsDBNull(9) ? null : reader.GetString(9);
                    supplier.Fax = reader.IsDBNull(10) ? null : reader.GetString(10);
                    supplier.HomePage = reader.IsDBNull(11) ? null : reader.GetString(11);

                    // Añadir el proveedor a la lista
                    Lista.Add(supplier);
                }
                conexion.Close();
                return Lista;
            }
        }








    }
}
