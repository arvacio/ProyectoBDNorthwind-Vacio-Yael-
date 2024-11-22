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

        // Codigo para mostrar toda la tabla de orders
        public static List<Orders> PresentarRegistro()
        {
            List<Orders> Lista = new List<Orders>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from orders";
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

                    Lista.Add(orders);
                }
                conexion.Close();
                return Lista;
            }
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
                string query = "select * from orders where OrderID =" + OrderID + "";
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
                    Lista.Add(orders);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static List<Orders> BuscarRegistroCustomerID(string CustomerID)
        {
            List<Orders> Lista = new List<Orders>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from orders where CustomerID ='" + CustomerID + "'";
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
                    Lista.Add(orders);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static List<Orders> BuscarRegistroEmployeeID(int EmployeeID)
        {
            List<Orders> Lista = new List<Orders>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from orders where EmployeeID =" + EmployeeID + "";
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
                    Lista.Add(orders);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static List<Orders> BuscarRegistroOrderDate(string OrderDate)
        {
            List<Orders> Lista = new List<Orders>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from orders where OrderDate ='" + OrderDate + "'";
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
                    Lista.Add(orders);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static List<Orders> BuscarRegistroRequiredDate(string RequiredDate)
        {
            List<Orders> Lista = new List<Orders>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from orders where RequiredDate ='" + RequiredDate + "'";
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
                    Lista.Add(orders);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static List<Orders> BuscarRegistroShippedDate(string ShippedDate)
        {
            List<Orders> Lista = new List<Orders>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from orders where ShippedDate ='" + ShippedDate + "'";
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
                    Lista.Add(orders);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static List<Orders> BuscarRegistroShipVia(int ShipVia)
        {
            List<Orders> Lista = new List<Orders>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from orders where ShipVia =" + ShipVia + "";
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
                    Lista.Add(orders);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static List<Orders> BuscarRegistroFreight(double Freight)
        {
            List<Orders> Lista = new List<Orders>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from orders where Freight=" + Freight + "";
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
                    Lista.Add(orders);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static List<Orders> BuscarRegistroShipName(string ShipName)
        {
            List<Orders> Lista = new List<Orders>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from orders where ShipName ='" + ShipName + "'";
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
                    Lista.Add(orders);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static List<Orders> BuscarRegistroShipAddress(string ShipAddress)
        {
            List<Orders> Lista = new List<Orders>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from orders where ShipAddress ='" + ShipAddress + "'";
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
                    Lista.Add(orders);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static List<Orders> BuscarRegistroShipCity(string ShipCity)
        {
            List<Orders> Lista = new List<Orders>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from orders where ShipCity ='" + ShipCity + "'";
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
                    Lista.Add(orders);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static List<Orders> BuscarRegistroShipRegion(string ShipRegion)
        {
            List<Orders> Lista = new List<Orders>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from orders where ShipRegion ='" + ShipRegion + "'";
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
                    Lista.Add(orders);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static List<Orders> BuscarRegistroShipPostalCode(string ShipPostalCode)
        {
            List<Orders> Lista = new List<Orders>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from orders where ShipPostalCode ='" + ShipPostalCode + "'";
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
                    Lista.Add(orders);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static List<Orders> BuscarRegistroShipCountry(string ShipCountry)
        {
            List<Orders> Lista = new List<Orders>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from orders where ShipCountry ='" + ShipCountry + "'";
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
                    Lista.Add(orders);
                }
                conexion.Close();
                return Lista;
            }
        }
    }
}
