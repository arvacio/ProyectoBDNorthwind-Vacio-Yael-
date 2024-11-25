using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDNorthwind_Vacio_Yael_
{
    public class OrdersDAL
    {
        // Codigo para agregar un Order
        public static int AgregarOrders(Orders orders)
        {
            int retorna = 0;

            try
            {
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {

                    string query = "INSERT INTO orders (CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry) " +
               "VALUES (@CustomerID, @EmployeeID, @OrderDate, @RequiredDate, @ShippedDate, @ShipVia, @Freight, @ShipName, @ShipAddress, @ShipCity, @ShipRegion, @ShipPostalCode, @ShipCountry)";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@CustomerID", orders.CustomerID);
                    comando.Parameters.AddWithValue("@EmployeeID", orders.EmployeeID);
                    comando.Parameters.AddWithValue("@OrderDate", orders.OrderDate);
                    comando.Parameters.AddWithValue("@RequiredDate", orders.RequiredDate);
                    comando.Parameters.AddWithValue("@ShippedDate", orders.ShippedDate);
                    comando.Parameters.AddWithValue("@ShipVia", orders.ShipVia);
                    comando.Parameters.AddWithValue("@Freight", orders.Freight);
                    comando.Parameters.AddWithValue("@ShipName", orders.ShipName);
                    comando.Parameters.AddWithValue("@ShipAddress", orders.ShipAddress);
                    comando.Parameters.AddWithValue("@ShipCity", orders.ShipCity);
                    comando.Parameters.AddWithValue("@ShipRegion", orders.ShipRegion);
                    comando.Parameters.AddWithValue("@ShipPostalCode", orders.ShipPostalCode);
                    comando.Parameters.AddWithValue("@ShipCountry", orders.ShipCountry);

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

        public static List<Orders> PresentarRegistro()
        {
            List<Orders> Lista = new List<Orders>();

            try
            {
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    string query = @"
                SELECT 
                    o.OrderID,
                    o.CustomerID,
                    o.EmployeeID,
                    o.OrderDate,
                    o.RequiredDate,
                    o.ShippedDate,
                    o.ShipVia,
                    o.Freight,
                    o.ShipName,
                    o.ShipAddress,
                    o.ShipCity,
                    o.ShipRegion,
                    o.ShipPostalCode,
                    o.ShipCountry,
                    c.CompanyName,
                    e.FirstName
                FROM Orders o
                INNER JOIN Customers c ON o.CustomerID = c.CustomerID
                INNER JOIN Employees e ON o.EmployeeID = e.EmployeeID";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Orders orders = new Orders();

                        orders.OrderID = reader.GetInt32(0);
                        orders.CustomerID = reader.GetString(1);
                        orders.EmployeeID = reader.GetInt32(2);

                        DateTime? OrderDatep = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3);
                        DateTime? RequiredDatep = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4);
                        DateTime? ShippedDatep = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                        orders.OrderDate = OrderDatep.ToString();
                        orders.RequiredDate = RequiredDatep.ToString();
                        orders.ShippedDate = ShippedDatep.ToString();

                        orders.ShipVia = reader.GetInt32(6);
                        orders.Freight = reader.GetDecimal(7);
                        orders.ShipName = reader.GetString(8);
                        orders.ShipAddress = reader.GetString(9);
                        orders.ShipCity = reader.GetString(10);
                        orders.ShipRegion = reader.IsDBNull(11) ? null : reader.GetString(11);
                        orders.ShipPostalCode = reader.IsDBNull(12) ? null : reader.GetString(12);
                        orders.ShipCountry = reader.GetString(13);
                        orders.CompanyName = reader.IsDBNull(14) ? null : reader.GetString(14);
                        orders.FirstName = reader.IsDBNull(15) ? null : reader.GetString(15);


                        Lista.Add(orders);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al obtener los registros: " + ex.Message);
            }

            return Lista;
        }


        // Codigo para modificar un Order
        public static int ModificarOrders(Orders orders)
        {
            int result = 0;
            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {

                string query = "UPDATE orders SET CustomerID = @CustomerID, EmployeeID = @EmployeeID, OrderDate = @OrderDate, RequiredDate = @RequiredDate, ShippedDate = @ShippedDate, ShipVia = @ShipVia, Freight = @Freight, ShipName = @ShipName, ShipAddress = @ShipAddress, ShipCity = @ShipCity, ShipRegion = @ShipRegion, ShipPostalCode = @ShipPostalCode, ShipCountry = @ShipCountry WHERE OrderID = @OrderID";

                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@CustomerID", orders.CustomerID);
                comando.Parameters.AddWithValue("@EmployeeID", orders.EmployeeID);
                comando.Parameters.AddWithValue("@OrderDate", orders.OrderDate);
                comando.Parameters.AddWithValue("@RequiredDate", orders.RequiredDate);
                comando.Parameters.AddWithValue("@ShippedDate", orders.ShippedDate);
                comando.Parameters.AddWithValue("@ShipVia", orders.ShipVia);
                comando.Parameters.AddWithValue("@Freight", orders.Freight);
                comando.Parameters.AddWithValue("@ShipName", orders.ShipName);
                comando.Parameters.AddWithValue("@ShipAddress", orders.ShipAddress);
                comando.Parameters.AddWithValue("@ShipCity", orders.ShipCity);
                comando.Parameters.AddWithValue("@ShipRegion", orders.ShipRegion);
                comando.Parameters.AddWithValue("@ShipPostalCode", orders.ShipPostalCode);
                comando.Parameters.AddWithValue("@ShipCountry", orders.ShipCountry);
                comando.Parameters.AddWithValue("@OrderID", orders.OrderID);

                result = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return result;
        }

        public static int EliminarOrders(int id)
        {
            int retorna = 0;

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Usamos parámetros para evitar inyección SQL
                string query = "DELETE FROM orders WHERE OrderID = @OrderID";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadimos el parámetro que se usará en la consulta
                comando.Parameters.AddWithValue("@OrderID", id);

                // Ejecutamos la consulta y obtenemos el número de filas afectadas
                retorna = comando.ExecuteNonQuery();
            }

            return retorna;
        }


        // Codigos de Buscar Registro con: OrderID,CustomerID,EmployeeID,ShipVia,Freight,ShipName,ShipAddress,ShipCity,ShipRegion,ShipPostalCode,ShipCountry
        public static List<Orders> BuscarRegistroOrderID(int OrderID)
        {
            List<Orders> Lista = new List<Orders>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Modified SQL query to select the specific columns, including CompanyName and FirstName
                string query = @"
            SELECT 
                o.OrderID,
                o.CustomerID,
                o.EmployeeID,
                o.OrderDate,
                o.RequiredDate,
                o.ShippedDate,
                o.ShipVia,
                o.Freight,
                o.ShipName,
                o.ShipAddress,
                o.ShipCity,
                o.ShipRegion,
                o.ShipPostalCode,
                o.ShipCountry,
                c.CompanyName,
                e.FirstName
            FROM Orders o
            INNER JOIN Customers c ON o.CustomerID = c.CustomerID
            INNER JOIN Employees e ON o.EmployeeID = e.EmployeeID
            WHERE o.OrderID = @OrderID"; // Using parameterized query

                SqlCommand comando = new SqlCommand(query, conexion);

                // Add parameter to prevent SQL injection
                comando.Parameters.AddWithValue("@OrderID", OrderID);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Orders orders = new Orders();

                    // Populate the Orders object with the selected columns
                    orders.OrderID = reader.GetInt32(0);
                    orders.CustomerID = reader.GetString(1);
                    orders.EmployeeID = reader.GetInt32(2);

                    // Handle nullable DateTime fields as string, keeping your original logic
                    DateTime? OrderDatep = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3);
                    DateTime? RequiredDatep = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4);
                    DateTime? ShippedDatep = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    orders.OrderDate = OrderDatep.ToString();
                    orders.RequiredDate = RequiredDatep.ToString();
                    orders.ShippedDate = ShippedDatep.ToString();

                    // Populate other fields
                    orders.ShipVia = reader.GetInt32(6);
                    orders.Freight = reader.GetDecimal(7);
                    orders.ShipName = reader.GetString(8);
                    orders.ShipAddress = reader.GetString(9);
                    orders.ShipCity = reader.GetString(10);
                    orders.ShipRegion = reader.IsDBNull(11) ? null : reader.GetString(11);
                    orders.ShipPostalCode = reader.IsDBNull(12) ? null : reader.GetString(12);
                    orders.ShipCountry = reader.GetString(13);

                    // Add the new columns (CompanyName and FirstName) to the Orders object
                    orders.CompanyName = reader.IsDBNull(14) ? null : reader.GetString(14);
                    orders.FirstName = reader.IsDBNull(15) ? null : reader.GetString(15);

                    // Add the order to the list
                    Lista.Add(orders);
                }

                // Close the connection (handled by 'using' for SqlConnection)
                conexion.Close();
            }

            return Lista;
        }

        public static List<Orders> BuscarRegistroCustomerID(string CustomerID)
        {
            List<Orders> Lista = new List<Orders>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Use a parameterized query to prevent SQL injection
                string query = @"
            SELECT 
                o.OrderID,
                o.CustomerID,
                o.EmployeeID,
                o.OrderDate,
                o.RequiredDate,
                o.ShippedDate,
                o.ShipVia,
                o.Freight,
                o.ShipName,
                o.ShipAddress,
                o.ShipCity,
                o.ShipRegion,
                o.ShipPostalCode,
                o.ShipCountry,
                c.CompanyName,        -- Agregado: CompanyName de la tabla Customers
                e.FirstName           -- Agregado: FirstName de la tabla Employees
            FROM Orders o
            INNER JOIN Customers c ON o.CustomerID = c.CustomerID
            INNER JOIN Employees e ON o.EmployeeID = e.EmployeeID
            WHERE o.CustomerID = @CustomerID";

                SqlCommand comando = new SqlCommand(query, conexion);

                // Add the parameter to the SQL command
                comando.Parameters.AddWithValue("@CustomerID", CustomerID);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Orders orders = new Orders();

                    // Populate the Orders object
                    orders.OrderID = reader.GetInt32(0);
                    orders.CustomerID = reader.GetString(1);
                    orders.EmployeeID = reader.GetInt32(2);

                    // Handle nullable DateTime fields
                    DateTime? OrderDatep = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3);
                    DateTime? RequiredDatep = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4);
                    DateTime? ShippedDatep = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    orders.OrderDate = OrderDatep.HasValue ? OrderDatep.Value.ToString("yyyy-MM-dd") : null;
                    orders.RequiredDate = RequiredDatep.HasValue ? RequiredDatep.Value.ToString("yyyy-MM-dd") : null;
                    orders.ShippedDate = ShippedDatep.HasValue ? ShippedDatep.Value.ToString("yyyy-MM-dd") : null;

                    // Populate other fields
                    orders.ShipVia = reader.GetInt32(6);
                    orders.Freight = reader.GetDecimal(7);
                    orders.ShipName = reader.GetString(8);
                    orders.ShipAddress = reader.GetString(9);
                    orders.ShipCity = reader.GetString(10);
                    orders.ShipRegion = reader.IsDBNull(11) ? null : reader.GetString(11);
                    orders.ShipPostalCode = reader.IsDBNull(12) ? null : reader.GetString(12);
                    orders.ShipCountry = reader.GetString(13);
                    orders.CompanyName = reader.IsDBNull(14) ? null : reader.GetString(14);
                    orders.FirstName = reader.IsDBNull(15) ? null : reader.GetString(15);

                    // Add the order to the list
                    Lista.Add(orders);
                }
            }

            return Lista;
        }


        public static List<Orders> BuscarRegistroEmployeeID(int EmployeeID)
        {
            List<Orders> Lista = new List<Orders>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Modified query using parameterized query to prevent SQL injection
                string query = @"
        SELECT 
            o.OrderID,
            o.CustomerID,
            o.EmployeeID,
            o.OrderDate,
            o.RequiredDate,
            o.ShippedDate,
            o.ShipVia,
            o.Freight,
            o.ShipName,
            o.ShipAddress,
            o.ShipCity,
            o.ShipRegion,
            o.ShipPostalCode,
            o.ShipCountry,
            c.CompanyName,  -- New column for CompanyName
            e.FirstName     -- New column for FirstName
        FROM Orders o
        INNER JOIN Customers c ON o.CustomerID = c.CustomerID
        INNER JOIN Employees e ON o.EmployeeID = e.EmployeeID
        WHERE o.EmployeeID = @EmployeeID";

                SqlCommand comando = new SqlCommand(query, conexion);

                // Add parameter to SQL command to safely inject the EmployeeID value
                comando.Parameters.AddWithValue("@EmployeeID", EmployeeID);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Orders orders = new Orders();

                    // Populate the Orders object with the selected columns
                    orders.OrderID = reader.GetInt32(0);
                    orders.CustomerID = reader.GetString(1);
                    orders.EmployeeID = reader.GetInt32(2);

                    // Handle nullable DateTime fields as string
                    DateTime? OrderDatep = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3);
                    DateTime? RequiredDatep = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4);
                    DateTime? ShippedDatep = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    orders.OrderDate = OrderDatep.ToString();
                    orders.RequiredDate = RequiredDatep.ToString();
                    orders.ShippedDate = ShippedDatep.ToString();

                    // Populate other fields
                    orders.ShipVia = reader.GetInt32(6);
                    orders.Freight = reader.GetDecimal(7);
                    orders.ShipName = reader.GetString(8);
                    orders.ShipAddress = reader.GetString(9);
                    orders.ShipCity = reader.GetString(10);
                    orders.ShipRegion = reader.IsDBNull(11) ? null : reader.GetString(11);
                    orders.ShipPostalCode = reader.IsDBNull(12) ? null : reader.GetString(12);
                    orders.ShipCountry = reader.GetString(13);

                    // New fields: CompanyName and FirstName
                    orders.CompanyName = reader.IsDBNull(14) ? null : reader.GetString(14);
                    orders.FirstName = reader.IsDBNull(15) ? null : reader.GetString(15);

                    // Add the order to the list
                    Lista.Add(orders);
                }

                // Close the connection (handled by 'using' for SqlConnection)
                conexion.Close();
            }

            return Lista;
        }
        public static List<Orders> BuscarRegistroOrderDate(string OrderDate)
        {
            List<Orders> Lista = new List<Orders>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Query parametrizada para evitar SQL injection
                string query = @"
        SELECT 
            o.OrderID,
            o.CustomerID,
            o.EmployeeID,
            o.OrderDate,
            o.RequiredDate,
            o.ShippedDate,
            o.ShipVia,
            o.Freight,
            o.ShipName,
            o.ShipAddress,
            o.ShipCity,
            o.ShipRegion,
            o.ShipPostalCode,
            o.ShipCountry,
            c.CompanyName,  -- Nueva columna CompanyName
            e.FirstName     -- Nueva columna FirstName
        FROM Orders o
        INNER JOIN Customers c ON o.CustomerID = c.CustomerID
        INNER JOIN Employees e ON o.EmployeeID = e.EmployeeID
        WHERE o.OrderDate = @OrderDate";

                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadir el parámetro a la consulta para evitar la inyección de SQL
                comando.Parameters.AddWithValue("@OrderDate", OrderDate);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Orders orders = new Orders();

                    // Asignar valores a la propiedad Orders
                    orders.OrderID = reader.GetInt32(0);
                    orders.CustomerID = reader.GetString(1);
                    orders.EmployeeID = reader.GetInt32(2);

                    // Manejar campos DateTime nulos
                    DateTime? OrderDatep = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3);
                    DateTime? RequiredDatep = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4);
                    DateTime? ShippedDatep = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    orders.OrderDate = OrderDatep.ToString();
                    orders.RequiredDate = RequiredDatep.ToString();
                    orders.ShippedDate = ShippedDatep.ToString();

                    // Asignar otros campos
                    orders.ShipVia = reader.GetInt32(6);
                    orders.Freight = reader.GetDecimal(7);
                    orders.ShipName = reader.GetString(8);
                    orders.ShipAddress = reader.GetString(9);
                    orders.ShipCity = reader.GetString(10);
                    orders.ShipRegion = reader.IsDBNull(11) ? null : reader.GetString(11);
                    orders.ShipPostalCode = reader.IsDBNull(12) ? null : reader.GetString(12);
                    orders.ShipCountry = reader.GetString(13);

                    // Nuevas columnas: CompanyName y FirstName
                    orders.CompanyName = reader.IsDBNull(14) ? null : reader.GetString(14);
                    orders.FirstName = reader.IsDBNull(15) ? null : reader.GetString(15);

                    // Añadir el objeto orders a la lista
                    Lista.Add(orders);
                }

                // Cerrar la conexión (gestionado por 'using' para SqlConnection)
                conexion.Close();
            }

            return Lista;
        }


        public static List<Orders> BuscarRegistroRequiredDate(string RequiredDate)
        {
            List<Orders> Lista = new List<Orders>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Query parametrizada para evitar SQL injection
                string query = @"
        SELECT 
            o.OrderID,
            o.CustomerID,
            o.EmployeeID,
            o.OrderDate,
            o.RequiredDate,
            o.ShippedDate,
            o.ShipVia,
            o.Freight,
            o.ShipName,
            o.ShipAddress,
            o.ShipCity,
            o.ShipRegion,
            o.ShipPostalCode,
            o.ShipCountry,
            c.CompanyName,  -- Nueva columna CompanyName
            e.FirstName     -- Nueva columna FirstName
        FROM Orders o
        INNER JOIN Customers c ON o.CustomerID = c.CustomerID
        INNER JOIN Employees e ON o.EmployeeID = e.EmployeeID
        WHERE o.RequiredDate = @RequiredDate";

                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadir el parámetro a la consulta para evitar la inyección de SQL
                comando.Parameters.AddWithValue("@RequiredDate", RequiredDate);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Orders orders = new Orders();

                    // Asignar valores a la propiedad Orders
                    orders.OrderID = reader.GetInt32(0);
                    orders.CustomerID = reader.GetString(1);
                    orders.EmployeeID = reader.GetInt32(2);

                    // Manejar campos DateTime nulos
                    DateTime? OrderDatep = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3);
                    DateTime? RequiredDatep = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4);
                    DateTime? ShippedDatep = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    orders.OrderDate = OrderDatep.ToString();
                    orders.RequiredDate = RequiredDatep.ToString();
                    orders.ShippedDate = ShippedDatep.ToString();

                    // Asignar otros campos
                    orders.ShipVia = reader.GetInt32(6);
                    orders.Freight = reader.GetDecimal(7);
                    orders.ShipName = reader.GetString(8);
                    orders.ShipAddress = reader.GetString(9);
                    orders.ShipCity = reader.GetString(10);
                    orders.ShipRegion = reader.IsDBNull(11) ? null : reader.GetString(11);
                    orders.ShipPostalCode = reader.IsDBNull(12) ? null : reader.GetString(12);
                    orders.ShipCountry = reader.GetString(13);

                    // Nuevas columnas: CompanyName y FirstName
                    orders.CompanyName = reader.IsDBNull(14) ? null : reader.GetString(14);
                    orders.FirstName = reader.IsDBNull(15) ? null : reader.GetString(15);

                    // Añadir el objeto orders a la lista
                    Lista.Add(orders);
                }

                // Cerrar la conexión (gestionado por 'using' para SqlConnection)
                conexion.Close();
            }

            return Lista;
        }

        public static List<Orders> BuscarRegistroShippedDate(string ShippedDate)
        {
            List<Orders> Lista = new List<Orders>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Query parametrizada para evitar SQL injection
                string query = @"
        SELECT 
            o.OrderID,
            o.CustomerID,
            o.EmployeeID,
            o.OrderDate,
            o.RequiredDate,
            o.ShippedDate,
            o.ShipVia,
            o.Freight,
            o.ShipName,
            o.ShipAddress,
            o.ShipCity,
            o.ShipRegion,
            o.ShipPostalCode,
            o.ShipCountry,
            c.CompanyName,  -- Nueva columna CompanyName
            e.FirstName     -- Nueva columna FirstName
        FROM Orders o
        INNER JOIN Customers c ON o.CustomerID = c.CustomerID
        INNER JOIN Employees e ON o.EmployeeID = e.EmployeeID
        WHERE o.ShippedDate = @ShippedDate";

                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadir el parámetro a la consulta para evitar la inyección de SQL
                comando.Parameters.AddWithValue("@ShippedDate", ShippedDate);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Orders orders = new Orders();

                    // Asignar valores a la propiedad Orders
                    orders.OrderID = reader.GetInt32(0);
                    orders.CustomerID = reader.GetString(1);
                    orders.EmployeeID = reader.GetInt32(2);

                    // Manejar campos DateTime nulos
                    DateTime? OrderDatep = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3);
                    DateTime? RequiredDatep = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4);
                    DateTime? ShippedDatep = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    orders.OrderDate = OrderDatep.ToString();
                    orders.RequiredDate = RequiredDatep.ToString();
                    orders.ShippedDate = ShippedDatep.ToString();

                    // Asignar otros campos
                    orders.ShipVia = reader.GetInt32(6);
                    orders.Freight = reader.GetDecimal(7);
                    orders.ShipName = reader.GetString(8);
                    orders.ShipAddress = reader.GetString(9);
                    orders.ShipCity = reader.GetString(10);
                    orders.ShipRegion = reader.IsDBNull(11) ? null : reader.GetString(11);
                    orders.ShipPostalCode = reader.IsDBNull(12) ? null : reader.GetString(12);
                    orders.ShipCountry = reader.GetString(13);

                    // Nuevas columnas: CompanyName y FirstName
                    orders.CompanyName = reader.IsDBNull(14) ? null : reader.GetString(14);
                    orders.FirstName = reader.IsDBNull(15) ? null : reader.GetString(15);

                    // Añadir el objeto orders a la lista
                    Lista.Add(orders);
                }

                // Cerrar la conexión (gestionado por 'using' para SqlConnection)
                conexion.Close();
            }

            return Lista;
        }


        public static List<Orders> BuscarRegistroShipVia(int ShipVia)
        {
            List<Orders> Lista = new List<Orders>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Query parametrizada para evitar SQL injection
                string query = @"
        SELECT 
            o.OrderID,
            o.CustomerID,
            o.EmployeeID,
            o.OrderDate,
            o.RequiredDate,
            o.ShippedDate,
            o.ShipVia,
            o.Freight,
            o.ShipName,
            o.ShipAddress,
            o.ShipCity,
            o.ShipRegion,
            o.ShipPostalCode,
            o.ShipCountry,
            c.CompanyName,  -- Nueva columna CompanyName
            e.FirstName     -- Nueva columna FirstName
        FROM Orders o
        INNER JOIN Customers c ON o.CustomerID = c.CustomerID
        INNER JOIN Employees e ON o.EmployeeID = e.EmployeeID
        WHERE o.ShipVia = @ShipVia";

                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadir el parámetro a la consulta para evitar la inyección de SQL
                comando.Parameters.AddWithValue("@ShipVia", ShipVia);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Orders orders = new Orders();

                    // Asignar valores a la propiedad Orders
                    orders.OrderID = reader.GetInt32(0);
                    orders.CustomerID = reader.GetString(1);
                    orders.EmployeeID = reader.GetInt32(2);

                    // Manejar campos DateTime nulos
                    DateTime? OrderDatep = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3);
                    DateTime? RequiredDatep = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4);
                    DateTime? ShippedDatep = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    orders.OrderDate = OrderDatep.ToString();
                    orders.RequiredDate = RequiredDatep.ToString();
                    orders.ShippedDate = ShippedDatep.ToString();

                    // Asignar otros campos
                    orders.ShipVia = reader.GetInt32(6);
                    orders.Freight = reader.GetDecimal(7);
                    orders.ShipName = reader.GetString(8);
                    orders.ShipAddress = reader.GetString(9);
                    orders.ShipCity = reader.GetString(10);
                    orders.ShipRegion = reader.IsDBNull(11) ? null : reader.GetString(11);
                    orders.ShipPostalCode = reader.IsDBNull(12) ? null : reader.GetString(12);
                    orders.ShipCountry = reader.GetString(13);

                    // Nuevas columnas: CompanyName y FirstName
                    orders.CompanyName = reader.IsDBNull(14) ? null : reader.GetString(14);
                    orders.FirstName = reader.IsDBNull(15) ? null : reader.GetString(15);

                    // Añadir el objeto orders a la lista
                    Lista.Add(orders);
                }

                // Cerrar la conexión (gestionado por 'using' para SqlConnection)
                conexion.Close();
            }

            return Lista;
        }


        public static List<Orders> BuscarRegistroFreight(double Freight)
        {
            List<Orders> Lista = new List<Orders>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Query parametrizada para evitar SQL injection
                string query = @"
        SELECT 
            o.OrderID,
            o.CustomerID,
            o.EmployeeID,
            o.OrderDate,
            o.RequiredDate,
            o.ShippedDate,
            o.ShipVia,
            o.Freight,
            o.ShipName,
            o.ShipAddress,
            o.ShipCity,
            o.ShipRegion,
            o.ShipPostalCode,
            o.ShipCountry,
            c.CompanyName,  -- Nueva columna CompanyName
            e.FirstName     -- Nueva columna FirstName
        FROM Orders o
        INNER JOIN Customers c ON o.CustomerID = c.CustomerID
        INNER JOIN Employees e ON o.EmployeeID = e.EmployeeID
        WHERE o.Freight = @Freight";

                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadir el parámetro a la consulta para evitar la inyección de SQL
                comando.Parameters.AddWithValue("@Freight", Freight);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Orders orders = new Orders();

                    // Asignar valores a la propiedad Orders
                    orders.OrderID = reader.GetInt32(0);
                    orders.CustomerID = reader.GetString(1);
                    orders.EmployeeID = reader.GetInt32(2);

                    // Manejar campos DateTime nulos
                    DateTime? OrderDatep = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3);
                    DateTime? RequiredDatep = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4);
                    DateTime? ShippedDatep = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    orders.OrderDate = OrderDatep.ToString();
                    orders.RequiredDate = RequiredDatep.ToString();
                    orders.ShippedDate = ShippedDatep.ToString();

                    // Asignar otros campos
                    orders.ShipVia = reader.GetInt32(6);
                    orders.Freight = reader.GetDecimal(7);
                    orders.ShipName = reader.GetString(8);
                    orders.ShipAddress = reader.GetString(9);
                    orders.ShipCity = reader.GetString(10);
                    orders.ShipRegion = reader.IsDBNull(11) ? null : reader.GetString(11);
                    orders.ShipPostalCode = reader.IsDBNull(12) ? null : reader.GetString(12);
                    orders.ShipCountry = reader.GetString(13);

                    // Nuevas columnas: CompanyName y FirstName
                    orders.CompanyName = reader.IsDBNull(14) ? null : reader.GetString(14);
                    orders.FirstName = reader.IsDBNull(15) ? null : reader.GetString(15);

                    // Añadir el objeto orders a la lista
                    Lista.Add(orders);
                }

                // Cerrar la conexión (gestionado por 'using' para SqlConnection)
                conexion.Close();
            }

            return Lista;
        }


        public static List<Orders> BuscarRegistroShipName(string ShipName)
        {
            List<Orders> Lista = new List<Orders>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Query parametrizada para evitar SQL injection
                string query = @"
        SELECT 
            o.OrderID,
            o.CustomerID,
            o.EmployeeID,
            o.OrderDate,
            o.RequiredDate,
            o.ShippedDate,
            o.ShipVia,
            o.Freight,
            o.ShipName,
            o.ShipAddress,
            o.ShipCity,
            o.ShipRegion,
            o.ShipPostalCode,
            o.ShipCountry,
            c.CompanyName,  -- Nueva columna CompanyName
            e.FirstName     -- Nueva columna FirstName
        FROM Orders o
        INNER JOIN Customers c ON o.CustomerID = c.CustomerID
        INNER JOIN Employees e ON o.EmployeeID = e.EmployeeID
        WHERE o.ShipName = @ShipName";

                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadir el parámetro a la consulta para evitar la inyección de SQL
                comando.Parameters.AddWithValue("@ShipName", ShipName);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Orders orders = new Orders();

                    // Asignar valores a la propiedad Orders
                    orders.OrderID = reader.GetInt32(0);
                    orders.CustomerID = reader.GetString(1);
                    orders.EmployeeID = reader.GetInt32(2);

                    // Manejar campos DateTime nulos
                    DateTime? OrderDatep = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3);
                    DateTime? RequiredDatep = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4);
                    DateTime? ShippedDatep = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    orders.OrderDate = OrderDatep.ToString();
                    orders.RequiredDate = RequiredDatep.ToString();
                    orders.ShippedDate = ShippedDatep.ToString();

                    // Asignar otros campos
                    orders.ShipVia = reader.GetInt32(6);
                    orders.Freight = reader.GetDecimal(7);
                    orders.ShipName = reader.GetString(8);
                    orders.ShipAddress = reader.GetString(9);
                    orders.ShipCity = reader.GetString(10);
                    orders.ShipRegion = reader.IsDBNull(11) ? null : reader.GetString(11);
                    orders.ShipPostalCode = reader.IsDBNull(12) ? null : reader.GetString(12);
                    orders.ShipCountry = reader.GetString(13);

                    // Nuevas columnas: CompanyName y FirstName
                    orders.CompanyName = reader.IsDBNull(14) ? null : reader.GetString(14);
                    orders.FirstName = reader.IsDBNull(15) ? null : reader.GetString(15);

                    // Añadir el objeto orders a la lista
                    Lista.Add(orders);
                }

                // Cerrar la conexión (gestionado por 'using' para SqlConnection)
                conexion.Close();
            }

            return Lista;
        }

        public static List<Orders> BuscarRegistroShipAddress(string ShipAddress)
        {
            List<Orders> Lista = new List<Orders>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Query parametrizada para evitar SQL injection
                string query = @"
        SELECT 
            o.OrderID,
            o.CustomerID,
            o.EmployeeID,
            o.OrderDate,
            o.RequiredDate,
            o.ShippedDate,
            o.ShipVia,
            o.Freight,
            o.ShipName,
            o.ShipAddress,
            o.ShipCity,
            o.ShipRegion,
            o.ShipPostalCode,
            o.ShipCountry,
            c.CompanyName,  -- Nueva columna CompanyName
            e.FirstName     -- Nueva columna FirstName
        FROM Orders o
        INNER JOIN Customers c ON o.CustomerID = c.CustomerID
        INNER JOIN Employees e ON o.EmployeeID = e.EmployeeID
        WHERE o.ShipAddress = @ShipAddress";

                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadir el parámetro a la consulta para evitar la inyección de SQL
                comando.Parameters.AddWithValue("@ShipAddress", ShipAddress);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Orders orders = new Orders();

                    // Asignar valores a la propiedad Orders
                    orders.OrderID = reader.GetInt32(0);
                    orders.CustomerID = reader.GetString(1);
                    orders.EmployeeID = reader.GetInt32(2);

                    // Manejar campos DateTime nulos
                    DateTime? OrderDatep = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3);
                    DateTime? RequiredDatep = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4);
                    DateTime? ShippedDatep = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    orders.OrderDate = OrderDatep.ToString();
                    orders.RequiredDate = RequiredDatep.ToString();
                    orders.ShippedDate = ShippedDatep.ToString();

                    // Asignar otros campos
                    orders.ShipVia = reader.GetInt32(6);
                    orders.Freight = reader.GetDecimal(7);
                    orders.ShipName = reader.GetString(8);
                    orders.ShipAddress = reader.GetString(9);
                    orders.ShipCity = reader.GetString(10);
                    orders.ShipRegion = reader.IsDBNull(11) ? null : reader.GetString(11);
                    orders.ShipPostalCode = reader.IsDBNull(12) ? null : reader.GetString(12);
                    orders.ShipCountry = reader.GetString(13);

                    // Nuevas columnas: CompanyName y FirstName
                    orders.CompanyName = reader.IsDBNull(14) ? null : reader.GetString(14);
                    orders.FirstName = reader.IsDBNull(15) ? null : reader.GetString(15);

                    // Añadir el objeto orders a la lista
                    Lista.Add(orders);
                }

                // Cerrar la conexión (gestionado por 'using' para SqlConnection)
                conexion.Close();
            }

            return Lista;
        }


        public static List<Orders> BuscarRegistroShipCity(string ShipCity)
        {
            List<Orders> Lista = new List<Orders>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta parametrizada para evitar SQL injection
                string query = @"
        SELECT 
            o.OrderID,
            o.CustomerID,
            o.EmployeeID,
            o.OrderDate,
            o.RequiredDate,
            o.ShippedDate,
            o.ShipVia,
            o.Freight,
            o.ShipName,
            o.ShipAddress,
            o.ShipCity,
            o.ShipRegion,
            o.ShipPostalCode,
            o.ShipCountry,
            c.CompanyName,  -- Nueva columna CompanyName
            e.FirstName     -- Nueva columna FirstName
        FROM Orders o
        INNER JOIN Customers c ON o.CustomerID = c.CustomerID
        INNER JOIN Employees e ON o.EmployeeID = e.EmployeeID
        WHERE o.ShipCity = @ShipCity";

                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadir el parámetro a la consulta para evitar la inyección de SQL
                comando.Parameters.AddWithValue("@ShipCity", ShipCity);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Orders orders = new Orders();

                    // Asignar valores a las propiedades del objeto Orders
                    orders.OrderID = reader.GetInt32(0);
                    orders.CustomerID = reader.GetString(1);
                    orders.EmployeeID = reader.GetInt32(2);

                    // Manejar campos de fecha (nullable)
                    DateTime? OrderDatep = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3);
                    DateTime? RequiredDatep = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4);
                    DateTime? ShippedDatep = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    orders.OrderDate = OrderDatep.ToString();
                    orders.RequiredDate = RequiredDatep.ToString();
                    orders.ShippedDate = ShippedDatep.ToString();

                    // Asignar los demás campos
                    orders.ShipVia = reader.GetInt32(6);
                    orders.Freight = reader.GetDecimal(7);
                    orders.ShipName = reader.GetString(8);
                    orders.ShipAddress = reader.GetString(9);
                    orders.ShipCity = reader.GetString(10);
                    orders.ShipRegion = reader.IsDBNull(11) ? null : reader.GetString(11);
                    orders.ShipPostalCode = reader.IsDBNull(12) ? null : reader.GetString(12);
                    orders.ShipCountry = reader.GetString(13);

                    // Nuevas columnas: CompanyName y FirstName
                    orders.CompanyName = reader.IsDBNull(14) ? null : reader.GetString(14);
                    orders.FirstName = reader.IsDBNull(15) ? null : reader.GetString(15);

                    // Añadir el objeto orders a la lista
                    Lista.Add(orders);
                }

                // Cerrar la conexión (gestionado por 'using' para SqlConnection)
                conexion.Close();
            }

            return Lista;
        }


        public static List<Orders> BuscarRegistroShipRegion(string ShipRegion)
        {
            List<Orders> Lista = new List<Orders>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta parametrizada para evitar SQL injection
                string query = @"
        SELECT 
            o.OrderID,
            o.CustomerID,
            o.EmployeeID,
            o.OrderDate,
            o.RequiredDate,
            o.ShippedDate,
            o.ShipVia,
            o.Freight,
            o.ShipName,
            o.ShipAddress,
            o.ShipCity,
            o.ShipRegion,
            o.ShipPostalCode,
            o.ShipCountry,
            c.CompanyName,  -- Nueva columna CompanyName
            e.FirstName     -- Nueva columna FirstName
        FROM Orders o
        INNER JOIN Customers c ON o.CustomerID = c.CustomerID
        INNER JOIN Employees e ON o.EmployeeID = e.EmployeeID
        WHERE o.ShipRegion = @ShipRegion";

                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadir el parámetro a la consulta para evitar la inyección de SQL
                comando.Parameters.AddWithValue("@ShipRegion", ShipRegion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Orders orders = new Orders();

                    // Asignar valores a las propiedades del objeto Orders
                    orders.OrderID = reader.GetInt32(0);
                    orders.CustomerID = reader.GetString(1);
                    orders.EmployeeID = reader.GetInt32(2);

                    // Manejar campos de fecha (nullable)
                    DateTime? OrderDatep = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3);
                    DateTime? RequiredDatep = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4);
                    DateTime? ShippedDatep = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    orders.OrderDate = OrderDatep.ToString();
                    orders.RequiredDate = RequiredDatep.ToString();
                    orders.ShippedDate = ShippedDatep.ToString();

                    // Asignar los demás campos
                    orders.ShipVia = reader.GetInt32(6);
                    orders.Freight = reader.GetDecimal(7);
                    orders.ShipName = reader.GetString(8);
                    orders.ShipAddress = reader.GetString(9);
                    orders.ShipCity = reader.GetString(10);
                    orders.ShipRegion = reader.GetString(11);  // Columna ShipRegion
                    orders.ShipPostalCode = reader.IsDBNull(12) ? null : reader.GetString(12);
                    orders.ShipCountry = reader.GetString(13);

                    // Nuevas columnas: CompanyName y FirstName
                    orders.CompanyName = reader.IsDBNull(14) ? null : reader.GetString(14);
                    orders.FirstName = reader.IsDBNull(15) ? null : reader.GetString(15);

                    // Añadir el objeto orders a la lista
                    Lista.Add(orders);
                }

                // Cerrar la conexión (gestionado por 'using' para SqlConnection)
                conexion.Close();
            }

            return Lista;
        }


        public static List<Orders> BuscarRegistroShipPostalCode(string ShipPostalCode)
        {
            List<Orders> Lista = new List<Orders>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta parametrizada para evitar SQL injection
                string query = @"
        SELECT 
            o.OrderID,
            o.CustomerID,
            o.EmployeeID,
            o.OrderDate,
            o.RequiredDate,
            o.ShippedDate,
            o.ShipVia,
            o.Freight,
            o.ShipName,
            o.ShipAddress,
            o.ShipCity,
            o.ShipRegion,
            o.ShipPostalCode,
            o.ShipCountry,
            c.CompanyName,  -- Nueva columna CompanyName
            e.FirstName     -- Nueva columna FirstName
        FROM Orders o
        INNER JOIN Customers c ON o.CustomerID = c.CustomerID
        INNER JOIN Employees e ON o.EmployeeID = e.EmployeeID
        WHERE o.ShipPostalCode = @ShipPostalCode";

                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadir el parámetro a la consulta para evitar la inyección de SQL
                comando.Parameters.AddWithValue("@ShipPostalCode", ShipPostalCode);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Orders orders = new Orders();

                    // Asignar valores a las propiedades del objeto Orders
                    orders.OrderID = reader.GetInt32(0);
                    orders.CustomerID = reader.GetString(1);
                    orders.EmployeeID = reader.GetInt32(2);

                    // Manejar campos de fecha (nullable)
                    DateTime? OrderDatep = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3);
                    DateTime? RequiredDatep = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4);
                    DateTime? ShippedDatep = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    orders.OrderDate = OrderDatep.ToString();
                    orders.RequiredDate = RequiredDatep.ToString();
                    orders.ShippedDate = ShippedDatep.ToString();

                    // Asignar los demás campos
                    orders.ShipVia = reader.GetInt32(6);
                    orders.Freight = reader.GetDecimal(7);
                    orders.ShipName = reader.GetString(8);
                    orders.ShipAddress = reader.GetString(9);
                    orders.ShipCity = reader.GetString(10);
                    orders.ShipRegion = reader.IsDBNull(11) ? null : reader.GetString(11);  // Puede ser nulo
                    orders.ShipPostalCode = reader.IsDBNull(12) ? null : reader.GetString(12); // Campo de postal code
                    orders.ShipCountry = reader.GetString(13);

                    // Nuevas columnas: CompanyName y FirstName
                    orders.CompanyName = reader.IsDBNull(14) ? null : reader.GetString(14);
                    orders.FirstName = reader.IsDBNull(15) ? null : reader.GetString(15);

                    // Añadir el objeto orders a la lista
                    Lista.Add(orders);
                }

                // Cerrar la conexión (gestionado por 'using' para SqlConnection)
                conexion.Close();
            }

            return Lista;
        }


        public static List<Orders> BuscarRegistroShipCountry(string ShipCountry)
        {
            List<Orders> Lista = new List<Orders>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta parametrizada para evitar SQL injection
                string query = @"
        SELECT 
            o.OrderID,
            o.CustomerID,
            o.EmployeeID,
            o.OrderDate,
            o.RequiredDate,
            o.ShippedDate,
            o.ShipVia,
            o.Freight,
            o.ShipName,
            o.ShipAddress,
            o.ShipCity,
            o.ShipRegion,
            o.ShipPostalCode,
            o.ShipCountry,
            c.CompanyName,  -- Nueva columna CompanyName
            e.FirstName     -- Nueva columna FirstName
        FROM Orders o
        INNER JOIN Customers c ON o.CustomerID = c.CustomerID
        INNER JOIN Employees e ON o.EmployeeID = e.EmployeeID
        WHERE o.ShipCountry = @ShipCountry";

                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadir el parámetro a la consulta para evitar la inyección de SQL
                comando.Parameters.AddWithValue("@ShipCountry", ShipCountry);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Orders orders = new Orders();

                    // Asignar valores a las propiedades del objeto Orders
                    orders.OrderID = reader.GetInt32(0);
                    orders.CustomerID = reader.GetString(1);
                    orders.EmployeeID = reader.GetInt32(2);

                    // Manejar campos de fecha (nullable)
                    DateTime? OrderDatep = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3);
                    DateTime? RequiredDatep = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4);
                    DateTime? ShippedDatep = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    orders.OrderDate = OrderDatep.ToString();
                    orders.RequiredDate = RequiredDatep.ToString();
                    orders.ShippedDate = ShippedDatep.ToString();

                    // Asignar los demás campos
                    orders.ShipVia = reader.GetInt32(6);
                    orders.Freight = reader.GetDecimal(7);
                    orders.ShipName = reader.GetString(8);
                    orders.ShipAddress = reader.GetString(9);
                    orders.ShipCity = reader.GetString(10);
                    orders.ShipRegion = reader.IsDBNull(11) ? null : reader.GetString(11);  // Puede ser nulo
                    orders.ShipPostalCode = reader.IsDBNull(12) ? null : reader.GetString(12); // Campo de postal code
                    orders.ShipCountry = reader.GetString(13);

                    // Nuevas columnas: CompanyName y FirstName
                    orders.CompanyName = reader.IsDBNull(14) ? null : reader.GetString(14);
                    orders.FirstName = reader.IsDBNull(15) ? null : reader.GetString(15);

                    // Añadir el objeto orders a la lista
                    Lista.Add(orders);
                }

                // Cerrar la conexión (gestionado por 'using' para SqlConnection)
                conexion.Close();
            }

            return Lista;
        }

        public static List<Orders> BuscarRegistroFirstName(string FirstName)
        {
            List<Orders> Lista = new List<Orders>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta parametrizada para evitar SQL injection
                string query = @"
        SELECT 
            o.OrderID,
            o.CustomerID,
            o.EmployeeID,
            o.OrderDate,
            o.RequiredDate,
            o.ShippedDate,
            o.ShipVia,
            o.Freight,
            o.ShipName,
            o.ShipAddress,
            o.ShipCity,
            o.ShipRegion,
            o.ShipPostalCode,
            o.ShipCountry,
            c.CompanyName,  -- Nueva columna CompanyName
            e.FirstName     -- Nueva columna FirstName
        FROM Orders o
        INNER JOIN Customers c ON o.CustomerID = c.CustomerID
        INNER JOIN Employees e ON o.EmployeeID = e.EmployeeID
        WHERE e.FirstName = @FirstName";

                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadir el parámetro a la consulta para evitar la inyección de SQL
                comando.Parameters.AddWithValue("@FirstName", FirstName);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Orders orders = new Orders();

                    // Asignar valores a las propiedades del objeto Orders
                    orders.OrderID = reader.GetInt32(0);
                    orders.CustomerID = reader.GetString(1);
                    orders.EmployeeID = reader.GetInt32(2);

                    // Manejar campos de fecha (nullable)
                    DateTime? OrderDatep = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3);
                    DateTime? RequiredDatep = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4);
                    DateTime? ShippedDatep = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    orders.OrderDate = OrderDatep.ToString();
                    orders.RequiredDate = RequiredDatep.ToString();
                    orders.ShippedDate = ShippedDatep.ToString();

                    // Asignar los demás campos
                    orders.ShipVia = reader.GetInt32(6);
                    orders.Freight = reader.GetDecimal(7);
                    orders.ShipName = reader.GetString(8);
                    orders.ShipAddress = reader.GetString(9);
                    orders.ShipCity = reader.GetString(10);
                    orders.ShipRegion = reader.IsDBNull(11) ? null : reader.GetString(11);  // Puede ser nulo
                    orders.ShipPostalCode = reader.IsDBNull(12) ? null : reader.GetString(12); // Campo de postal code
                    orders.ShipCountry = reader.GetString(13);

                    // Nuevas columnas: CompanyName y FirstName
                    orders.CompanyName = reader.IsDBNull(14) ? null : reader.GetString(14);
                    orders.FirstName = reader.IsDBNull(15) ? null : reader.GetString(15);

                    // Añadir el objeto orders a la lista
                    Lista.Add(orders);
                }

                // Cerrar la conexión (gestionado por 'using' para SqlConnection)
                conexion.Close();
            }

            return Lista;
        }

        public static List<Orders> BuscarRegistroCompanyName(string CompanyName)
        {
            List<Orders> Lista = new List<Orders>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta parametrizada para evitar SQL injection
                string query = @"
        SELECT 
            o.OrderID,
            o.CustomerID,
            o.EmployeeID,
            o.OrderDate,
            o.RequiredDate,
            o.ShippedDate,
            o.ShipVia,
            o.Freight,
            o.ShipName,
            o.ShipAddress,
            o.ShipCity,
            o.ShipRegion,
            o.ShipPostalCode,
            o.ShipCountry,
            c.CompanyName,  -- Nueva columna CompanyName
            e.FirstName     -- Nueva columna FirstName
        FROM Orders o
        INNER JOIN Customers c ON o.CustomerID = c.CustomerID
        INNER JOIN Employees e ON o.EmployeeID = e.EmployeeID
        WHERE c.CompanyName = @CompanyName";

                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadir el parámetro a la consulta para evitar la inyección de SQL
                comando.Parameters.AddWithValue("@CompanyName", CompanyName);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Orders orders = new Orders();

                    // Asignar valores a las propiedades del objeto Orders
                    orders.OrderID = reader.GetInt32(0);
                    orders.CustomerID = reader.GetString(1);
                    orders.EmployeeID = reader.GetInt32(2);

                    // Manejar campos de fecha (nullable)
                    DateTime? OrderDatep = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3);
                    DateTime? RequiredDatep = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4);
                    DateTime? ShippedDatep = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    orders.OrderDate = OrderDatep.ToString();
                    orders.RequiredDate = RequiredDatep.ToString();
                    orders.ShippedDate = ShippedDatep.ToString();

                    // Asignar los demás campos
                    orders.ShipVia = reader.GetInt32(6);
                    orders.Freight = reader.GetDecimal(7);
                    orders.ShipName = reader.GetString(8);
                    orders.ShipAddress = reader.GetString(9);
                    orders.ShipCity = reader.GetString(10);
                    orders.ShipRegion = reader.IsDBNull(11) ? null : reader.GetString(11);  // Puede ser nulo
                    orders.ShipPostalCode = reader.IsDBNull(12) ? null : reader.GetString(12); // Campo de postal code
                    orders.ShipCountry = reader.GetString(13);

                    // Nuevas columnas: CompanyName y FirstName
                    orders.CompanyName = reader.IsDBNull(14) ? null : reader.GetString(14);
                    orders.FirstName = reader.IsDBNull(15) ? null : reader.GetString(15);

                    // Añadir el objeto orders a la lista
                    Lista.Add(orders);
                }

                // Cerrar la conexión (gestionado por 'using' para SqlConnection)
                conexion.Close();
            }

            return Lista;
        }

    }
}
