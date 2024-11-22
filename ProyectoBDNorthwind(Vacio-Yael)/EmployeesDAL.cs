using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDNorthwind_Vacio_Yael_
{
    public class EmployeesDAL
    {

        public static int AgregarEmployee(Employees employee)
        {
            int retorna = 0;

            //try
            //{
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    string query = "INSERT INTO Employees (LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Notes, ReportsTo, PhotoPath) " +
                                   "VALUES (@LastName, @FirstName, @Title, @TitleOfCourtesy, @BirthDate, @HireDate, @Address, @City, @Region, @PostalCode, @Country, @HomePhone, @Extension, @Notes, @ReportsTo, @PhotoPath)";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@LastName", employee.LastName);
                    comando.Parameters.AddWithValue("@FirstName", employee.FirstName);
                    comando.Parameters.AddWithValue("@Title", employee.Title);
                    comando.Parameters.AddWithValue("@TitleOfCourtesy", employee.TitleOfCourtesy);
                    comando.Parameters.AddWithValue("@BirthDate", employee.BirthDate);
                    comando.Parameters.AddWithValue("@HireDate", employee.HireDate);
                    comando.Parameters.AddWithValue("@Address", employee.Address);
                    comando.Parameters.AddWithValue("@City", employee.City);
                    comando.Parameters.AddWithValue("@Region", employee.Region);
                    comando.Parameters.AddWithValue("@PostalCode", employee.PostalCode);
                    comando.Parameters.AddWithValue("@Country", employee.Country);
                    comando.Parameters.AddWithValue("@HomePhone", employee.HomePhone);
                    comando.Parameters.AddWithValue("@Extension", employee.Extension);

                    comando.Parameters.AddWithValue("@Notes", employee.Notes);
                    comando.Parameters.AddWithValue("@PhotoPath", employee.PhotoPath);

                    //// Si el campo Photo tiene una imagen, la agregamos como parámetro
                    //if (employee.Photo != null)
                    //    comando.Parameters.AddWithValue("@Photo", employee.Photo);
                    //else
                    //    comando.Parameters.AddWithValue("@Photo", DBNull.Value);

                    // Si el campo ReportsTo es nulo, lo agregamos como DBNull.Value, de lo contrario, pasamos el valor
                    if (employee.ReportsTo.HasValue)
                        comando.Parameters.AddWithValue("@ReportsTo", employee.ReportsTo.Value);
                    else
                        comando.Parameters.AddWithValue("@ReportsTo", DBNull.Value);

                    retorna = comando.ExecuteNonQuery();
                }

                return retorna;
            //}
            //catch (SqlException sqlEx)
            //{
            //    MessageBox.Show("Error al insertar: " + sqlEx.Message);
            //    return retorna;
            //}
        }

        public static List<Employees> PresentarRegistro()
        {
            List<Employees> Lista= new List<Employees>();

            try
            {
                // Abrimos la conexión con la base de datos
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Definimos la consulta SQL para obtener todos los empleados
                    string query = "SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, " +
                                   "Address, City, Region, PostalCode, Country, HomePhone, Extension, Photo, Notes, ReportsTo, PhotoPath " +
                                   "FROM Employees";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    // Ejecutamos la consulta
                    SqlDataReader reader = comando.ExecuteReader();

                    // Iteramos sobre cada fila del resultado
                    while (reader.Read())
                    {
                        Employees employees = new Employees();

                        // Mapeamos los valores obtenidos de la consulta a las propiedades del objeto 'Employee'
                        employees.EmployeeID = reader.GetInt32(0);
                        employees.LastName = reader.GetString(1);
                        employees.FirstName = reader.GetString(2);
                        employees.Title = reader.IsDBNull(3) ? null : reader.GetString(3);
                        employees.TitleOfCourtesy = reader.IsDBNull(4) ? null : reader.GetString(4);

                        DateTime? BirthDay = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                        DateTime? HireDate = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6);

                        employees.BirthDate = BirthDay.ToString();
                        employees.HireDate = HireDate.ToString();

                        employees.Address = reader.IsDBNull(7) ? null : reader.GetString(7);
                        employees.City = reader.IsDBNull(8) ? null : reader.GetString(8);
                        employees.Region = reader.IsDBNull(9) ? null : reader.GetString(9);
                        employees.PostalCode = reader.IsDBNull(10) ? null : reader.GetString(10);
                        employees.Country = reader.IsDBNull(11) ? null : reader.GetString(11);
                        employees.HomePhone = reader.IsDBNull(12) ? null : reader.GetString(12);
                        employees.Extension = reader.IsDBNull(13) ? null : reader.GetString(13);
                        employees.Photo = reader.IsDBNull(14) ? null : (byte[])reader["Photo"]; // Leer el campo de imagen
                        employees.Notes = reader.IsDBNull(15) ? null : reader.GetString(15);
                        employees.ReportsTo = reader.IsDBNull(16) ? (int?)null : reader.GetInt32(16);
                        employees.PhotoPath = reader.IsDBNull(17) ? null : reader.GetString(17);

                        Lista.Add(employees);
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error al recuperar los registros: " + sqlEx.Message);
            }
            return Lista;
        }

        public static int ModificarEmployee(Employees employee)
        {
            int result = 0;

            try
            {
                // Abrimos la conexión con la base de datos
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Definimos la consulta SQL para actualizar un registro en la tabla Employees
                    string query = "UPDATE Employees " +
                                   "SET LastName = @LastName, FirstName = @FirstName, Title = @Title, " +
                                   "TitleOfCourtesy = @TitleOfCourtesy, BirthDate = @BirthDate, HireDate = @HireDate, " +
                                   "Address = @Address, City = @City, Region = @Region, PostalCode = @PostalCode, " +
                                   "Country = @Country, HomePhone = @HomePhone, Extension = @Extension, " +
                                   "Notes = @Notes, ReportsTo = @ReportsTo, PhotoPath = @PhotoPath " +
                                   "WHERE EmployeeID = @EmployeeID";

                    // Creamos el comando SQL y añadimos los parámetros correspondientes
                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);
                    comando.Parameters.AddWithValue("@LastName", employee.LastName);
                    comando.Parameters.AddWithValue("@FirstName", employee.FirstName);
                    comando.Parameters.AddWithValue("@Title", employee.Title);
                    comando.Parameters.AddWithValue("@TitleOfCourtesy", employee.TitleOfCourtesy);
                    comando.Parameters.AddWithValue("@BirthDate", employee.BirthDate);
                    comando.Parameters.AddWithValue("@HireDate", employee.HireDate);
                    comando.Parameters.AddWithValue("@Address", employee.Address);
                    comando.Parameters.AddWithValue("@City", employee.City);
                    comando.Parameters.AddWithValue("@Region", employee.Region);
                    comando.Parameters.AddWithValue("@PostalCode", employee.PostalCode);
                    comando.Parameters.AddWithValue("@Country", employee.Country);
                    comando.Parameters.AddWithValue("@HomePhone", employee.HomePhone);
                    comando.Parameters.AddWithValue("@Extension", employee.Extension);
                    //comando.Parameters.AddWithValue("@Photo", employee.Photo ?? (object)DBNull.Value);
                    comando.Parameters.AddWithValue("@Notes", employee.Notes);
                    comando.Parameters.AddWithValue("@ReportsTo", employee.ReportsTo ?? (object)DBNull.Value);
                    comando.Parameters.AddWithValue("@PhotoPath", employee.PhotoPath);

                    // Ejecutamos la consulta
                    result = comando.ExecuteNonQuery();

                    conexion.Close();
                }
            }
            catch (SqlException sqlEx)
            {
                // Manejo de errores en caso de que ocurra una excepción SQL
                MessageBox.Show("Error al modificar el empleado: " + sqlEx.Message);
            }

            // Devolvemos el resultado de la operación (número de filas afectadas)
            return result;
        }

        public static int EliminarEmployee(int employeeID)
        {
            int result = 0;

            try
            {
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    string query = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@EmployeeID", employeeID);

                    result = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error al eliminar el empleado: " + sqlEx.Message);
            }
            return result;
        }

        // Busquedas

        public static List<Employees> BuscarRegistroEmployeeID(int employeeID)
        {
            List<Employees> Lista = new List<Employees>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Usamos una consulta parametrizada para evitar la inyección SQL
                string query = "SELECT * FROM Employees WHERE EmployeeID = @EmployeeID";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadimos el parámetro para evitar inyección SQL
                comando.Parameters.AddWithValue("@EmployeeID", employeeID);

                // Ejecutamos la consulta
                SqlDataReader reader = comando.ExecuteReader();

                // Leemos los resultados de la consulta
                while (reader.Read())
                {
                    Employees employee = new Employees();

                    // Asignamos los valores a las propiedades de Employee
                    employee.EmployeeID = reader.GetInt32(0);  // Asumimos que EmployeeID es el primer campo
                    employee.LastName = reader.GetString(1);
                    employee.FirstName = reader.GetString(2);
                    employee.Title = reader.IsDBNull(3) ? null : reader.GetString(3);  // Puede ser nulo
                    employee.TitleOfCourtesy = reader.IsDBNull(4) ? null : reader.GetString(4);  // Puede ser nulo

                    // Asignamos las fechas
                    DateTime? birthDate = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    employee.BirthDate = birthDate.ToString();

                    DateTime? hireDate = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6);
                    employee.HireDate = hireDate.ToString();

                    // Asignamos la dirección y otros datos
                    employee.Address = reader.IsDBNull(7) ? null : reader.GetString(7);  // Puede ser nulo
                    employee.City = reader.IsDBNull(8) ? null : reader.GetString(8);  // Puede ser nulo
                    employee.Region = reader.IsDBNull(9) ? null : reader.GetString(9);  // Puede ser nulo
                    employee.PostalCode = reader.IsDBNull(10) ? null : reader.GetString(10);  // Puede ser nulo
                    employee.Country = reader.IsDBNull(11) ? null : reader.GetString(11);  // Puede ser nulo
                    employee.HomePhone = reader.IsDBNull(12) ? null : reader.GetString(12);  // Puede ser nulo
                    employee.Extension = reader.IsDBNull(13) ? null : reader.GetString(13);  // Puede ser nulo

                    // Para las notas, manejamos un campo de tipo ntext, que podría ser nulo
                    employee.Notes = reader.IsDBNull(15) ? null : reader.GetString(15);  // Puede ser nulo

                    // Si el reporte a otro empleado (ReportsTo) es nulo, lo asignamos como null
                    employee.ReportsTo = reader.IsDBNull(16) ? (int?)null : reader.GetInt32(16);  // Puede ser nulo

                    employee.PhotoPath = reader.IsDBNull(17) ? null : reader.GetString(17);  // Puede ser nulo

                    // Añadimos el empleado a la lista
                    Lista.Add(employee);
                }

                // Cerramos la conexión
                conexion.Close();
            }

            // Retornamos la lista de empleados encontrados
            return Lista;
        }
        public static List<Employees> BuscarRegistroLastName(string LastName)
        {
            List<Employees> Lista = new List<Employees>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Usamos una consulta parametrizada para evitar la inyección SQL
                string query = "SELECT * FROM Employees WHERE LastName = @LastName";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadimos el parámetro para evitar inyección SQL
                comando.Parameters.AddWithValue("@LastName", LastName);

                // Ejecutamos la consulta
                SqlDataReader reader = comando.ExecuteReader();

                // Leemos los resultados de la consulta
                while (reader.Read())
                {
                    Employees employee = new Employees();

                    // Asignamos los valores a las propiedades de Employee
                    employee.EmployeeID = reader.GetInt32(0);  // Asumimos que EmployeeID es el primer campo
                    employee.LastName = reader.GetString(1);
                    employee.FirstName = reader.GetString(2);
                    employee.Title = reader.IsDBNull(3) ? null : reader.GetString(3);  // Puede ser nulo
                    employee.TitleOfCourtesy = reader.IsDBNull(4) ? null : reader.GetString(4);  // Puede ser nulo

                    // Asignamos las fechas
                    DateTime? birthDate = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    employee.BirthDate = birthDate.ToString();

                    DateTime? hireDate = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6);
                    employee.HireDate = hireDate.ToString();

                    // Asignamos la dirección y otros datos
                    employee.Address = reader.IsDBNull(7) ? null : reader.GetString(7);  // Puede ser nulo
                    employee.City = reader.IsDBNull(8) ? null : reader.GetString(8);  // Puede ser nulo
                    employee.Region = reader.IsDBNull(9) ? null : reader.GetString(9);  // Puede ser nulo
                    employee.PostalCode = reader.IsDBNull(10) ? null : reader.GetString(10);  // Puede ser nulo
                    employee.Country = reader.IsDBNull(11) ? null : reader.GetString(11);  // Puede ser nulo
                    employee.HomePhone = reader.IsDBNull(12) ? null : reader.GetString(12);  // Puede ser nulo
                    employee.Extension = reader.IsDBNull(13) ? null : reader.GetString(13);  // Puede ser nulo

                    // Para las notas, manejamos un campo de tipo ntext, que podría ser nulo
                    employee.Notes = reader.IsDBNull(15) ? null : reader.GetString(15);  // Puede ser nulo

                    // Si el reporte a otro empleado (ReportsTo) es nulo, lo asignamos como null
                    employee.ReportsTo = reader.IsDBNull(16) ? (int?)null : reader.GetInt32(16);  // Puede ser nulo

                    employee.PhotoPath = reader.IsDBNull(17) ? null : reader.GetString(17);  // Puede ser nulo

                    // Añadimos el empleado a la lista
                    Lista.Add(employee);
                }

                // Cerramos la conexión
                conexion.Close();
            }

            // Retornamos la lista de empleados encontrados
            return Lista;
        }
        public static List<Employees> BuscarRegistroFirstName(string FirstName)
        {
            List<Employees> Lista = new List<Employees>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Usamos una consulta parametrizada para evitar la inyección SQL
                string query = "SELECT * FROM Employees WHERE FirstName = @FirstName";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadimos el parámetro para evitar inyección SQL
                comando.Parameters.AddWithValue("@FirstName", FirstName);

                // Ejecutamos la consulta
                SqlDataReader reader = comando.ExecuteReader();

                // Leemos los resultados de la consulta
                while (reader.Read())
                {
                    Employees employee = new Employees();

                    // Asignamos los valores a las propiedades de Employee
                    employee.EmployeeID = reader.GetInt32(0);  // Asumimos que EmployeeID es el primer campo
                    employee.LastName = reader.GetString(1);
                    employee.FirstName = reader.GetString(2);
                    employee.Title = reader.IsDBNull(3) ? null : reader.GetString(3);  // Puede ser nulo
                    employee.TitleOfCourtesy = reader.IsDBNull(4) ? null : reader.GetString(4);  // Puede ser nulo

                    // Asignamos las fechas
                    DateTime? birthDate = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    employee.BirthDate = birthDate.ToString();

                    DateTime? hireDate = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6);
                    employee.HireDate = hireDate.ToString();

                    // Asignamos la dirección y otros datos
                    employee.Address = reader.IsDBNull(7) ? null : reader.GetString(7);  // Puede ser nulo
                    employee.City = reader.IsDBNull(8) ? null : reader.GetString(8);  // Puede ser nulo
                    employee.Region = reader.IsDBNull(9) ? null : reader.GetString(9);  // Puede ser nulo
                    employee.PostalCode = reader.IsDBNull(10) ? null : reader.GetString(10);  // Puede ser nulo
                    employee.Country = reader.IsDBNull(11) ? null : reader.GetString(11);  // Puede ser nulo
                    employee.HomePhone = reader.IsDBNull(12) ? null : reader.GetString(12);  // Puede ser nulo
                    employee.Extension = reader.IsDBNull(13) ? null : reader.GetString(13);  // Puede ser nulo

                    // Para las notas, manejamos un campo de tipo ntext, que podría ser nulo
                    employee.Notes = reader.IsDBNull(15) ? null : reader.GetString(15);  // Puede ser nulo

                    // Si el reporte a otro empleado (ReportsTo) es nulo, lo asignamos como null
                    employee.ReportsTo = reader.IsDBNull(16) ? (int?)null : reader.GetInt32(16);  // Puede ser nulo

                    employee.PhotoPath = reader.IsDBNull(17) ? null : reader.GetString(17);  // Puede ser nulo

                    // Añadimos el empleado a la lista
                    Lista.Add(employee);
                }

                // Cerramos la conexión
                conexion.Close();
            }

            // Retornamos la lista de empleados encontrados
            return Lista;
        }
        public static List<Employees> BuscarRegistroTitle(string Title)
        {
            List<Employees> Lista = new List<Employees>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Usamos una consulta parametrizada para evitar la inyección SQL
                string query = "SELECT * FROM Employees WHERE Title = @Title";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadimos el parámetro para evitar inyección SQL
                comando.Parameters.AddWithValue("@Title", Title);

                // Ejecutamos la consulta
                SqlDataReader reader = comando.ExecuteReader();

                // Leemos los resultados de la consulta
                while (reader.Read())
                {
                    Employees employee = new Employees();

                    // Asignamos los valores a las propiedades de Employee
                    employee.EmployeeID = reader.GetInt32(0);  // Asumimos que EmployeeID es el primer campo
                    employee.LastName = reader.GetString(1);
                    employee.FirstName = reader.GetString(2);
                    employee.Title = reader.IsDBNull(3) ? null : reader.GetString(3);  // Puede ser nulo
                    employee.TitleOfCourtesy = reader.IsDBNull(4) ? null : reader.GetString(4);  // Puede ser nulo

                    // Asignamos las fechas
                    DateTime? birthDate = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    employee.BirthDate = birthDate.ToString();

                    DateTime? hireDate = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6);
                    employee.HireDate = hireDate.ToString();

                    // Asignamos la dirección y otros datos
                    employee.Address = reader.IsDBNull(7) ? null : reader.GetString(7);  // Puede ser nulo
                    employee.City = reader.IsDBNull(8) ? null : reader.GetString(8);  // Puede ser nulo
                    employee.Region = reader.IsDBNull(9) ? null : reader.GetString(9);  // Puede ser nulo
                    employee.PostalCode = reader.IsDBNull(10) ? null : reader.GetString(10);  // Puede ser nulo
                    employee.Country = reader.IsDBNull(11) ? null : reader.GetString(11);  // Puede ser nulo
                    employee.HomePhone = reader.IsDBNull(12) ? null : reader.GetString(12);  // Puede ser nulo
                    employee.Extension = reader.IsDBNull(13) ? null : reader.GetString(13);  // Puede ser nulo

                    // Para las notas, manejamos un campo de tipo ntext, que podría ser nulo
                    employee.Notes = reader.IsDBNull(15) ? null : reader.GetString(15);  // Puede ser nulo

                    // Si el reporte a otro empleado (ReportsTo) es nulo, lo asignamos como null
                    employee.ReportsTo = reader.IsDBNull(16) ? (int?)null : reader.GetInt32(16);  // Puede ser nulo

                    employee.PhotoPath = reader.IsDBNull(17) ? null : reader.GetString(17);  // Puede ser nulo

                    // Añadimos el empleado a la lista
                    Lista.Add(employee);
                }

                // Cerramos la conexión
                conexion.Close();
            }

            // Retornamos la lista de empleados encontrados
            return Lista;
        }
        public static List<Employees> BuscarRegistroBirthDate(string BirthDate)
        {
            List<Employees> Lista = new List<Employees>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Usamos una consulta parametrizada para evitar la inyección SQL
                string query = "SELECT * FROM Employees WHERE BirthDate = @BirthDate";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadimos el parámetro para evitar inyección SQL
                comando.Parameters.AddWithValue("@BirthDate", BirthDate);

                // Ejecutamos la consulta
                SqlDataReader reader = comando.ExecuteReader();

                // Leemos los resultados de la consulta
                while (reader.Read())
                {
                    Employees employee = new Employees();

                    // Asignamos los valores a las propiedades de Employee
                    employee.EmployeeID = reader.GetInt32(0);  // Asumimos que EmployeeID es el primer campo
                    employee.LastName = reader.GetString(1);
                    employee.FirstName = reader.GetString(2);
                    employee.Title = reader.IsDBNull(3) ? null : reader.GetString(3);  // Puede ser nulo
                    employee.TitleOfCourtesy = reader.IsDBNull(4) ? null : reader.GetString(4);  // Puede ser nulo

                    // Asignamos las fechas
                    DateTime? birthDate = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    employee.BirthDate = birthDate.ToString();

                    DateTime? hireDate = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6);
                    employee.HireDate = hireDate.ToString();

                    // Asignamos la dirección y otros datos
                    employee.Address = reader.IsDBNull(7) ? null : reader.GetString(7);  // Puede ser nulo
                    employee.City = reader.IsDBNull(8) ? null : reader.GetString(8);  // Puede ser nulo
                    employee.Region = reader.IsDBNull(9) ? null : reader.GetString(9);  // Puede ser nulo
                    employee.PostalCode = reader.IsDBNull(10) ? null : reader.GetString(10);  // Puede ser nulo
                    employee.Country = reader.IsDBNull(11) ? null : reader.GetString(11);  // Puede ser nulo
                    employee.HomePhone = reader.IsDBNull(12) ? null : reader.GetString(12);  // Puede ser nulo
                    employee.Extension = reader.IsDBNull(13) ? null : reader.GetString(13);  // Puede ser nulo

                    // Para las notas, manejamos un campo de tipo ntext, que podría ser nulo
                    employee.Notes = reader.IsDBNull(15) ? null : reader.GetString(15);  // Puede ser nulo

                    // Si el reporte a otro empleado (ReportsTo) es nulo, lo asignamos como null
                    employee.ReportsTo = reader.IsDBNull(16) ? (int?)null : reader.GetInt32(16);  // Puede ser nulo

                    employee.PhotoPath = reader.IsDBNull(17) ? null : reader.GetString(17);  // Puede ser nulo

                    // Añadimos el empleado a la lista
                    Lista.Add(employee);
                }

                // Cerramos la conexión
                conexion.Close();
            }

            // Retornamos la lista de empleados encontrados
            return Lista;
        }
        public static List<Employees> BuscarRegistroHireDate(string HireDate)
        {
            List<Employees> Lista = new List<Employees>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Usamos una consulta parametrizada para evitar la inyección SQL
                string query = "SELECT * FROM Employees WHERE HireDate = @HireDate";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadimos el parámetro para evitar inyección SQL
                comando.Parameters.AddWithValue("@HireDate", HireDate);

                // Ejecutamos la consulta
                SqlDataReader reader = comando.ExecuteReader();

                // Leemos los resultados de la consulta
                while (reader.Read())
                {
                    Employees employee = new Employees();

                    // Asignamos los valores a las propiedades de Employee
                    employee.EmployeeID = reader.GetInt32(0);  // Asumimos que EmployeeID es el primer campo
                    employee.LastName = reader.GetString(1);
                    employee.FirstName = reader.GetString(2);
                    employee.Title = reader.IsDBNull(3) ? null : reader.GetString(3);  // Puede ser nulo
                    employee.TitleOfCourtesy = reader.IsDBNull(4) ? null : reader.GetString(4);  // Puede ser nulo

                    // Asignamos las fechas
                    DateTime? birthDate = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    employee.BirthDate = birthDate.ToString();

                    DateTime? hireDate = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6);
                    employee.HireDate = hireDate.ToString();

                    // Asignamos la dirección y otros datos
                    employee.Address = reader.IsDBNull(7) ? null : reader.GetString(7);  // Puede ser nulo
                    employee.City = reader.IsDBNull(8) ? null : reader.GetString(8);  // Puede ser nulo
                    employee.Region = reader.IsDBNull(9) ? null : reader.GetString(9);  // Puede ser nulo
                    employee.PostalCode = reader.IsDBNull(10) ? null : reader.GetString(10);  // Puede ser nulo
                    employee.Country = reader.IsDBNull(11) ? null : reader.GetString(11);  // Puede ser nulo
                    employee.HomePhone = reader.IsDBNull(12) ? null : reader.GetString(12);  // Puede ser nulo
                    employee.Extension = reader.IsDBNull(13) ? null : reader.GetString(13);  // Puede ser nulo

                    // Para las notas, manejamos un campo de tipo ntext, que podría ser nulo
                    employee.Notes = reader.IsDBNull(15) ? null : reader.GetString(15);  // Puede ser nulo

                    // Si el reporte a otro empleado (ReportsTo) es nulo, lo asignamos como null
                    employee.ReportsTo = reader.IsDBNull(16) ? (int?)null : reader.GetInt32(16);  // Puede ser nulo

                    employee.PhotoPath = reader.IsDBNull(17) ? null : reader.GetString(17);  // Puede ser nulo

                    // Añadimos el empleado a la lista
                    Lista.Add(employee);
                }

                // Cerramos la conexión
                conexion.Close();
            }

            // Retornamos la lista de empleados encontrados
            return Lista;
        }
        public static List<Employees> BuscarRegistroAddress(string Address)
        {
            List<Employees> Lista = new List<Employees>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Usamos una consulta parametrizada para evitar la inyección SQL
                string query = "SELECT * FROM Employees WHERE Address = @Address";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadimos el parámetro para evitar inyección SQL
                comando.Parameters.AddWithValue("@Address", Address);

                // Ejecutamos la consulta
                SqlDataReader reader = comando.ExecuteReader();

                // Leemos los resultados de la consulta
                while (reader.Read())
                {
                    Employees employee = new Employees();

                    // Asignamos los valores a las propiedades de Employee
                    employee.EmployeeID = reader.GetInt32(0);  // Asumimos que EmployeeID es el primer campo
                    employee.LastName = reader.GetString(1);
                    employee.FirstName = reader.GetString(2);
                    employee.Title = reader.IsDBNull(3) ? null : reader.GetString(3);  // Puede ser nulo
                    employee.TitleOfCourtesy = reader.IsDBNull(4) ? null : reader.GetString(4);  // Puede ser nulo

                    // Asignamos las fechas
                    DateTime? birthDate = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    employee.BirthDate = birthDate.ToString();

                    DateTime? hireDate = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6);
                    employee.HireDate = hireDate.ToString();

                    // Asignamos la dirección y otros datos
                    employee.Address = reader.IsDBNull(7) ? null : reader.GetString(7);  // Puede ser nulo
                    employee.City = reader.IsDBNull(8) ? null : reader.GetString(8);  // Puede ser nulo
                    employee.Region = reader.IsDBNull(9) ? null : reader.GetString(9);  // Puede ser nulo
                    employee.PostalCode = reader.IsDBNull(10) ? null : reader.GetString(10);  // Puede ser nulo
                    employee.Country = reader.IsDBNull(11) ? null : reader.GetString(11);  // Puede ser nulo
                    employee.HomePhone = reader.IsDBNull(12) ? null : reader.GetString(12);  // Puede ser nulo
                    employee.Extension = reader.IsDBNull(13) ? null : reader.GetString(13);  // Puede ser nulo

                    // Para las notas, manejamos un campo de tipo ntext, que podría ser nulo
                    employee.Notes = reader.IsDBNull(15) ? null : reader.GetString(15);  // Puede ser nulo

                    // Si el reporte a otro empleado (ReportsTo) es nulo, lo asignamos como null
                    employee.ReportsTo = reader.IsDBNull(16) ? (int?)null : reader.GetInt32(16);  // Puede ser nulo

                    employee.PhotoPath = reader.IsDBNull(17) ? null : reader.GetString(17);  // Puede ser nulo

                    // Añadimos el empleado a la lista
                    Lista.Add(employee);
                }

                // Cerramos la conexión
                conexion.Close();
            }

            // Retornamos la lista de empleados encontrados
            return Lista;
        }
        public static List<Employees> BuscarRegistroCity(string City)
        {
            List<Employees> Lista = new List<Employees>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Usamos una consulta parametrizada para evitar la inyección SQL
                string query = "SELECT * FROM Employees WHERE City = @City";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadimos el parámetro para evitar inyección SQL
                comando.Parameters.AddWithValue("@City", City);

                // Ejecutamos la consulta
                SqlDataReader reader = comando.ExecuteReader();

                // Leemos los resultados de la consulta
                while (reader.Read())
                {
                    Employees employee = new Employees();

                    // Asignamos los valores a las propiedades de Employee
                    employee.EmployeeID = reader.GetInt32(0);  // Asumimos que EmployeeID es el primer campo
                    employee.LastName = reader.GetString(1);
                    employee.FirstName = reader.GetString(2);
                    employee.Title = reader.IsDBNull(3) ? null : reader.GetString(3);  // Puede ser nulo
                    employee.TitleOfCourtesy = reader.IsDBNull(4) ? null : reader.GetString(4);  // Puede ser nulo

                    // Asignamos las fechas
                    DateTime? birthDate = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    employee.BirthDate = birthDate.ToString();

                    DateTime? hireDate = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6);
                    employee.HireDate = hireDate.ToString();

                    // Asignamos la dirección y otros datos
                    employee.Address = reader.IsDBNull(7) ? null : reader.GetString(7);  // Puede ser nulo
                    employee.City = reader.IsDBNull(8) ? null : reader.GetString(8);  // Puede ser nulo
                    employee.Region = reader.IsDBNull(9) ? null : reader.GetString(9);  // Puede ser nulo
                    employee.PostalCode = reader.IsDBNull(10) ? null : reader.GetString(10);  // Puede ser nulo
                    employee.Country = reader.IsDBNull(11) ? null : reader.GetString(11);  // Puede ser nulo
                    employee.HomePhone = reader.IsDBNull(12) ? null : reader.GetString(12);  // Puede ser nulo
                    employee.Extension = reader.IsDBNull(13) ? null : reader.GetString(13);  // Puede ser nulo

                    // Para las notas, manejamos un campo de tipo ntext, que podría ser nulo
                    employee.Notes = reader.IsDBNull(15) ? null : reader.GetString(15);  // Puede ser nulo

                    // Si el reporte a otro empleado (ReportsTo) es nulo, lo asignamos como null
                    employee.ReportsTo = reader.IsDBNull(16) ? (int?)null : reader.GetInt32(16);  // Puede ser nulo

                    employee.PhotoPath = reader.IsDBNull(17) ? null : reader.GetString(17);  // Puede ser nulo

                    // Añadimos el empleado a la lista
                    Lista.Add(employee);
                }

                // Cerramos la conexión
                conexion.Close();
            }

            // Retornamos la lista de empleados encontrados
            return Lista;
        }
        public static List<Employees> BuscarRegistroRegion(string Region)
        {
            List<Employees> Lista = new List<Employees>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Usamos una consulta parametrizada para evitar la inyección SQL
                string query = "SELECT * FROM Employees WHERE Region = @Region";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadimos el parámetro para evitar inyección SQL
                comando.Parameters.AddWithValue("@Region", Region);

                // Ejecutamos la consulta
                SqlDataReader reader = comando.ExecuteReader();

                // Leemos los resultados de la consulta
                while (reader.Read())
                {
                    Employees employee = new Employees();

                    // Asignamos los valores a las propiedades de Employee
                    employee.EmployeeID = reader.GetInt32(0);  // Asumimos que EmployeeID es el primer campo
                    employee.LastName = reader.GetString(1);
                    employee.FirstName = reader.GetString(2);
                    employee.Title = reader.IsDBNull(3) ? null : reader.GetString(3);  // Puede ser nulo
                    employee.TitleOfCourtesy = reader.IsDBNull(4) ? null : reader.GetString(4);  // Puede ser nulo

                    // Asignamos las fechas
                    DateTime? birthDate = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    employee.BirthDate = birthDate.ToString();

                    DateTime? hireDate = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6);
                    employee.HireDate = hireDate.ToString();

                    // Asignamos la dirección y otros datos
                    employee.Address = reader.IsDBNull(7) ? null : reader.GetString(7);  // Puede ser nulo
                    employee.City = reader.IsDBNull(8) ? null : reader.GetString(8);  // Puede ser nulo
                    employee.Region = reader.IsDBNull(9) ? null : reader.GetString(9);  // Puede ser nulo
                    employee.PostalCode = reader.IsDBNull(10) ? null : reader.GetString(10);  // Puede ser nulo
                    employee.Country = reader.IsDBNull(11) ? null : reader.GetString(11);  // Puede ser nulo
                    employee.HomePhone = reader.IsDBNull(12) ? null : reader.GetString(12);  // Puede ser nulo
                    employee.Extension = reader.IsDBNull(13) ? null : reader.GetString(13);  // Puede ser nulo

                    // Para las notas, manejamos un campo de tipo ntext, que podría ser nulo
                    employee.Notes = reader.IsDBNull(15) ? null : reader.GetString(15);  // Puede ser nulo

                    // Si el reporte a otro empleado (ReportsTo) es nulo, lo asignamos como null
                    employee.ReportsTo = reader.IsDBNull(16) ? (int?)null : reader.GetInt32(16);  // Puede ser nulo

                    employee.PhotoPath = reader.IsDBNull(17) ? null : reader.GetString(17);  // Puede ser nulo

                    // Añadimos el empleado a la lista
                    Lista.Add(employee);
                }

                // Cerramos la conexión
                conexion.Close();
            }

            // Retornamos la lista de empleados encontrados
            return Lista;
        }
        public static List<Employees> BuscarRegistroPostalCode(string PostalCode)
        {
            List<Employees> Lista = new List<Employees>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Usamos una consulta parametrizada para evitar la inyección SQL
                string query = "SELECT * FROM Employees WHERE PostalCode = @PostalCode";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadimos el parámetro para evitar inyección SQL
                comando.Parameters.AddWithValue("@PostalCode", PostalCode);

                // Ejecutamos la consulta
                SqlDataReader reader = comando.ExecuteReader();

                // Leemos los resultados de la consulta
                while (reader.Read())
                {
                    Employees employee = new Employees();

                    // Asignamos los valores a las propiedades de Employee
                    employee.EmployeeID = reader.GetInt32(0);  // Asumimos que EmployeeID es el primer campo
                    employee.LastName = reader.GetString(1);
                    employee.FirstName = reader.GetString(2);
                    employee.Title = reader.IsDBNull(3) ? null : reader.GetString(3);  // Puede ser nulo
                    employee.TitleOfCourtesy = reader.IsDBNull(4) ? null : reader.GetString(4);  // Puede ser nulo

                    // Asignamos las fechas
                    DateTime? birthDate = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    employee.BirthDate = birthDate.ToString();

                    DateTime? hireDate = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6);
                    employee.HireDate = hireDate.ToString();

                    // Asignamos la dirección y otros datos
                    employee.Address = reader.IsDBNull(7) ? null : reader.GetString(7);  // Puede ser nulo
                    employee.City = reader.IsDBNull(8) ? null : reader.GetString(8);  // Puede ser nulo
                    employee.Region = reader.IsDBNull(9) ? null : reader.GetString(9);  // Puede ser nulo
                    employee.PostalCode = reader.IsDBNull(10) ? null : reader.GetString(10);  // Puede ser nulo
                    employee.Country = reader.IsDBNull(11) ? null : reader.GetString(11);  // Puede ser nulo
                    employee.HomePhone = reader.IsDBNull(12) ? null : reader.GetString(12);  // Puede ser nulo
                    employee.Extension = reader.IsDBNull(13) ? null : reader.GetString(13);  // Puede ser nulo

                    // Para las notas, manejamos un campo de tipo ntext, que podría ser nulo
                    employee.Notes = reader.IsDBNull(15) ? null : reader.GetString(15);  // Puede ser nulo

                    // Si el reporte a otro empleado (ReportsTo) es nulo, lo asignamos como null
                    employee.ReportsTo = reader.IsDBNull(16) ? (int?)null : reader.GetInt32(16);  // Puede ser nulo

                    employee.PhotoPath = reader.IsDBNull(17) ? null : reader.GetString(17);  // Puede ser nulo

                    // Añadimos el empleado a la lista
                    Lista.Add(employee);
                }

                // Cerramos la conexión
                conexion.Close();
            }

            // Retornamos la lista de empleados encontrados
            return Lista;
        }
        public static List<Employees> BuscarRegistroCountry(string Country)
        {
            List<Employees> Lista = new List<Employees>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Usamos una consulta parametrizada para evitar la inyección SQL
                string query = "SELECT * FROM Employees WHERE Country = @Country";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadimos el parámetro para evitar inyección SQL
                comando.Parameters.AddWithValue("@Country", Country);

                // Ejecutamos la consulta
                SqlDataReader reader = comando.ExecuteReader();

                // Leemos los resultados de la consulta
                while (reader.Read())
                {
                    Employees employee = new Employees();

                    // Asignamos los valores a las propiedades de Employee
                    employee.EmployeeID = reader.GetInt32(0);  // Asumimos que EmployeeID es el primer campo
                    employee.LastName = reader.GetString(1);
                    employee.FirstName = reader.GetString(2);
                    employee.Title = reader.IsDBNull(3) ? null : reader.GetString(3);  // Puede ser nulo
                    employee.TitleOfCourtesy = reader.IsDBNull(4) ? null : reader.GetString(4);  // Puede ser nulo

                    // Asignamos las fechas
                    DateTime? birthDate = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    employee.BirthDate = birthDate.ToString();

                    DateTime? hireDate = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6);
                    employee.HireDate = hireDate.ToString();

                    // Asignamos la dirección y otros datos
                    employee.Address = reader.IsDBNull(7) ? null : reader.GetString(7);  // Puede ser nulo
                    employee.City = reader.IsDBNull(8) ? null : reader.GetString(8);  // Puede ser nulo
                    employee.Region = reader.IsDBNull(9) ? null : reader.GetString(9);  // Puede ser nulo
                    employee.PostalCode = reader.IsDBNull(10) ? null : reader.GetString(10);  // Puede ser nulo
                    employee.Country = reader.IsDBNull(11) ? null : reader.GetString(11);  // Puede ser nulo
                    employee.HomePhone = reader.IsDBNull(12) ? null : reader.GetString(12);  // Puede ser nulo
                    employee.Extension = reader.IsDBNull(13) ? null : reader.GetString(13);  // Puede ser nulo

                    // Para las notas, manejamos un campo de tipo ntext, que podría ser nulo
                    employee.Notes = reader.IsDBNull(15) ? null : reader.GetString(15);  // Puede ser nulo

                    // Si el reporte a otro empleado (ReportsTo) es nulo, lo asignamos como null
                    employee.ReportsTo = reader.IsDBNull(16) ? (int?)null : reader.GetInt32(16);  // Puede ser nulo

                    employee.PhotoPath = reader.IsDBNull(17) ? null : reader.GetString(17);  // Puede ser nulo

                    // Añadimos el empleado a la lista
                    Lista.Add(employee);
                }

                // Cerramos la conexión
                conexion.Close();
            }

            // Retornamos la lista de empleados encontrados
            return Lista;
        }
        public static List<Employees> BuscarRegistroHomePhone(string HomePhone)
        {
            List<Employees> Lista = new List<Employees>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Usamos una consulta parametrizada para evitar la inyección SQL
                string query = "SELECT * FROM Employees WHERE HomePhone = @HomePhone";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadimos el parámetro para evitar inyección SQL
                comando.Parameters.AddWithValue("@HomePhone", HomePhone);

                // Ejecutamos la consulta
                SqlDataReader reader = comando.ExecuteReader();

                // Leemos los resultados de la consulta
                while (reader.Read())
                {
                    Employees employee = new Employees();

                    // Asignamos los valores a las propiedades de Employee
                    employee.EmployeeID = reader.GetInt32(0);  // Asumimos que EmployeeID es el primer campo
                    employee.LastName = reader.GetString(1);
                    employee.FirstName = reader.GetString(2);
                    employee.Title = reader.IsDBNull(3) ? null : reader.GetString(3);  // Puede ser nulo
                    employee.TitleOfCourtesy = reader.IsDBNull(4) ? null : reader.GetString(4);  // Puede ser nulo

                    // Asignamos las fechas
                    DateTime? birthDate = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    employee.BirthDate = birthDate.ToString();

                    DateTime? hireDate = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6);
                    employee.HireDate = hireDate.ToString();

                    // Asignamos la dirección y otros datos
                    employee.Address = reader.IsDBNull(7) ? null : reader.GetString(7);  // Puede ser nulo
                    employee.City = reader.IsDBNull(8) ? null : reader.GetString(8);  // Puede ser nulo
                    employee.Region = reader.IsDBNull(9) ? null : reader.GetString(9);  // Puede ser nulo
                    employee.PostalCode = reader.IsDBNull(10) ? null : reader.GetString(10);  // Puede ser nulo
                    employee.Country = reader.IsDBNull(11) ? null : reader.GetString(11);  // Puede ser nulo
                    employee.HomePhone = reader.IsDBNull(12) ? null : reader.GetString(12);  // Puede ser nulo
                    employee.Extension = reader.IsDBNull(13) ? null : reader.GetString(13);  // Puede ser nulo

                    // Para las notas, manejamos un campo de tipo ntext, que podría ser nulo
                    employee.Notes = reader.IsDBNull(15) ? null : reader.GetString(15);  // Puede ser nulo

                    // Si el reporte a otro empleado (ReportsTo) es nulo, lo asignamos como null
                    employee.ReportsTo = reader.IsDBNull(16) ? (int?)null : reader.GetInt32(16);  // Puede ser nulo

                    employee.PhotoPath = reader.IsDBNull(17) ? null : reader.GetString(17);  // Puede ser nulo

                    // Añadimos el empleado a la lista
                    Lista.Add(employee);
                }

                // Cerramos la conexión
                conexion.Close();
            }

            // Retornamos la lista de empleados encontrados
            return Lista;
        }
        public static List<Employees> BuscarRegistroExtension(string Extension)
        {
            List<Employees> Lista = new List<Employees>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Usamos una consulta parametrizada para evitar la inyección SQL
                string query = "SELECT * FROM Employees WHERE Extension = @Extension";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadimos el parámetro para evitar inyección SQL
                comando.Parameters.AddWithValue("@Extension", Extension);

                // Ejecutamos la consulta
                SqlDataReader reader = comando.ExecuteReader();

                // Leemos los resultados de la consulta
                while (reader.Read())
                {
                    Employees employee = new Employees();

                    // Asignamos los valores a las propiedades de Employee
                    employee.EmployeeID = reader.GetInt32(0);  // Asumimos que EmployeeID es el primer campo
                    employee.LastName = reader.GetString(1);
                    employee.FirstName = reader.GetString(2);
                    employee.Title = reader.IsDBNull(3) ? null : reader.GetString(3);  // Puede ser nulo
                    employee.TitleOfCourtesy = reader.IsDBNull(4) ? null : reader.GetString(4);  // Puede ser nulo

                    // Asignamos las fechas
                    DateTime? birthDate = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    employee.BirthDate = birthDate.ToString();

                    DateTime? hireDate = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6);
                    employee.HireDate = hireDate.ToString();

                    // Asignamos la dirección y otros datos
                    employee.Address = reader.IsDBNull(7) ? null : reader.GetString(7);  // Puede ser nulo
                    employee.City = reader.IsDBNull(8) ? null : reader.GetString(8);  // Puede ser nulo
                    employee.Region = reader.IsDBNull(9) ? null : reader.GetString(9);  // Puede ser nulo
                    employee.PostalCode = reader.IsDBNull(10) ? null : reader.GetString(10);  // Puede ser nulo
                    employee.Country = reader.IsDBNull(11) ? null : reader.GetString(11);  // Puede ser nulo
                    employee.HomePhone = reader.IsDBNull(12) ? null : reader.GetString(12);  // Puede ser nulo
                    employee.Extension = reader.IsDBNull(13) ? null : reader.GetString(13);  // Puede ser nulo

                    // Para las notas, manejamos un campo de tipo ntext, que podría ser nulo
                    employee.Notes = reader.IsDBNull(15) ? null : reader.GetString(15);  // Puede ser nulo

                    // Si el reporte a otro empleado (ReportsTo) es nulo, lo asignamos como null
                    employee.ReportsTo = reader.IsDBNull(16) ? (int?)null : reader.GetInt32(16);  // Puede ser nulo

                    employee.PhotoPath = reader.IsDBNull(17) ? null : reader.GetString(17);  // Puede ser nulo

                    // Añadimos el empleado a la lista
                    Lista.Add(employee);
                }

                // Cerramos la conexión
                conexion.Close();
            }

            // Retornamos la lista de empleados encontrados
            return Lista;
        }
        public static List<Employees> BuscarRegistroReportsTo(int ReportsTo)
        {
            List<Employees> Lista = new List<Employees>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Usamos una consulta parametrizada para evitar la inyección SQL
                string query = "SELECT * FROM Employees WHERE ReportsTo = @ReportsTo";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadimos el parámetro para evitar inyección SQL
                comando.Parameters.AddWithValue("@ReportsTo", ReportsTo);

                // Ejecutamos la consulta
                SqlDataReader reader = comando.ExecuteReader();

                // Leemos los resultados de la consulta
                while (reader.Read())
                {
                    Employees employee = new Employees();

                    // Asignamos los valores a las propiedades de Employee
                    employee.EmployeeID = reader.GetInt32(0);  // Asumimos que EmployeeID es el primer campo
                    employee.LastName = reader.GetString(1);
                    employee.FirstName = reader.GetString(2);
                    employee.Title = reader.IsDBNull(3) ? null : reader.GetString(3);  // Puede ser nulo
                    employee.TitleOfCourtesy = reader.IsDBNull(4) ? null : reader.GetString(4);  // Puede ser nulo

                    // Asignamos las fechas
                    DateTime? birthDate = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    employee.BirthDate = birthDate.ToString();

                    DateTime? hireDate = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6);
                    employee.HireDate = hireDate.ToString();

                    // Asignamos la dirección y otros datos
                    employee.Address = reader.IsDBNull(7) ? null : reader.GetString(7);  // Puede ser nulo
                    employee.City = reader.IsDBNull(8) ? null : reader.GetString(8);  // Puede ser nulo
                    employee.Region = reader.IsDBNull(9) ? null : reader.GetString(9);  // Puede ser nulo
                    employee.PostalCode = reader.IsDBNull(10) ? null : reader.GetString(10);  // Puede ser nulo
                    employee.Country = reader.IsDBNull(11) ? null : reader.GetString(11);  // Puede ser nulo
                    employee.HomePhone = reader.IsDBNull(12) ? null : reader.GetString(12);  // Puede ser nulo
                    employee.Extension = reader.IsDBNull(13) ? null : reader.GetString(13);  // Puede ser nulo

                    // Para las notas, manejamos un campo de tipo ntext, que podría ser nulo
                    employee.Notes = reader.IsDBNull(15) ? null : reader.GetString(15);  // Puede ser nulo

                    // Si el reporte a otro empleado (ReportsTo) es nulo, lo asignamos como null
                    employee.ReportsTo = reader.IsDBNull(16) ? (int?)null : reader.GetInt32(16);  // Puede ser nulo

                    employee.PhotoPath = reader.IsDBNull(17) ? null : reader.GetString(17);  // Puede ser nulo

                    // Añadimos el empleado a la lista
                    Lista.Add(employee);
                }

                // Cerramos la conexión
                conexion.Close();
            }

            // Retornamos la lista de empleados encontrados
            return Lista;
        }
        public static List<Employees> BuscarRegistroPhotoPath(string PhotoPath)
        {
            List<Employees> Lista = new List<Employees>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Usamos una consulta parametrizada para evitar la inyección SQL
                string query = "SELECT * FROM Employees WHERE PhotoPath = @PhotoPath";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadimos el parámetro para evitar inyección SQL
                comando.Parameters.AddWithValue("@PhotoPath", PhotoPath);

                // Ejecutamos la consulta
                SqlDataReader reader = comando.ExecuteReader();

                // Leemos los resultados de la consulta
                while (reader.Read())
                {
                    Employees employee = new Employees();

                    // Asignamos los valores a las propiedades de Employee
                    employee.EmployeeID = reader.GetInt32(0);  // Asumimos que EmployeeID es el primer campo
                    employee.LastName = reader.GetString(1);
                    employee.FirstName = reader.GetString(2);
                    employee.Title = reader.IsDBNull(3) ? null : reader.GetString(3);  // Puede ser nulo
                    employee.TitleOfCourtesy = reader.IsDBNull(4) ? null : reader.GetString(4);  // Puede ser nulo

                    // Asignamos las fechas
                    DateTime? birthDate = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    employee.BirthDate = birthDate.ToString();

                    DateTime? hireDate = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6);
                    employee.HireDate = hireDate.ToString();

                    // Asignamos la dirección y otros datos
                    employee.Address = reader.IsDBNull(7) ? null : reader.GetString(7);  // Puede ser nulo
                    employee.City = reader.IsDBNull(8) ? null : reader.GetString(8);  // Puede ser nulo
                    employee.Region = reader.IsDBNull(9) ? null : reader.GetString(9);  // Puede ser nulo
                    employee.PostalCode = reader.IsDBNull(10) ? null : reader.GetString(10);  // Puede ser nulo
                    employee.Country = reader.IsDBNull(11) ? null : reader.GetString(11);  // Puede ser nulo
                    employee.HomePhone = reader.IsDBNull(12) ? null : reader.GetString(12);  // Puede ser nulo
                    employee.Extension = reader.IsDBNull(13) ? null : reader.GetString(13);  // Puede ser nulo

                    // Para las notas, manejamos un campo de tipo ntext, que podría ser nulo
                    employee.Notes = reader.IsDBNull(15) ? null : reader.GetString(15);  // Puede ser nulo

                    // Si el reporte a otro empleado (ReportsTo) es nulo, lo asignamos como null
                    employee.ReportsTo = reader.IsDBNull(16) ? (int?)null : reader.GetInt32(16);  // Puede ser nulo

                    employee.PhotoPath = reader.IsDBNull(17) ? null : reader.GetString(17);  // Puede ser nulo

                    // Añadimos el empleado a la lista
                    Lista.Add(employee);
                }

                // Cerramos la conexión
                conexion.Close();
            }

            // Retornamos la lista de empleados encontrados
            return Lista;
        }


    }
}
