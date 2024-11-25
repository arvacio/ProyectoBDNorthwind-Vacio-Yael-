using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDNorthwind_Vacio_Yael_
{
    public class OrderDetailsDAL
    {
        public static int AgregarOrderDetailsDAL(OrderDetails orderDetails)
        {
            int retorna = 0;

            try
            {
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    string query = "INSERT INTO [Order Details] (OrderID, ProductID, UnitPrice, Quantity, Discount) " +
                                   "VALUES (@OrderID, @ProductID, @UnitPrice, @Quantity, @Discount)";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@OrderID", orderDetails.OrderID);
                    comando.Parameters.AddWithValue("@ProductID", orderDetails.ProductID);
                    comando.Parameters.AddWithValue("@UnitPrice", orderDetails.UnitPrice);
                    comando.Parameters.AddWithValue("@Quantity", orderDetails.Quantity);
                    comando.Parameters.AddWithValue("@Discount", orderDetails.Discount);

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
        public static List<OrderDetails> PresentarRegistro()
        {
            List<OrderDetails> Lista = new List<OrderDetails>();

            try
            {
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL con un JOIN entre Order Details y Products
                    string query = @"
                SELECT od.OrderID, od.ProductID, od.UnitPrice, od.Quantity, od.Discount, p.ProductName
                FROM [Order Details] od
                INNER JOIN Products p ON od.ProductID = p.ProductID";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OrderDetails orderDetails = new OrderDetails
                            {
                                OrderID = reader.GetInt32(0),
                                ProductID = reader.GetInt32(1),
                                UnitPrice = reader.GetDecimal(2),
                                Quantity = reader.GetInt16(3),
                                Discount = reader.GetFloat(4),
                                ProductName = reader.GetString(5) // Agregar el ProductName desde la consulta
                            };

                            Lista.Add(orderDetails);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Manejo de excepciones de base de datos
                Console.WriteLine("Error al consultar la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejo de otras excepciones
                Console.WriteLine("Error inesperado: " + ex.Message);
            }

            return Lista;
        }

        public static int ModificarOrderDetails(OrderDetails orderDetails)
        {
            int result = 0;

            try
            {

                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // La consulta SQL ahora actualiza la tabla "Order Details"
                    string query = "UPDATE [Order Details] SET ProductID = @ProductID, UnitPrice = @UnitPrice, Quantity = @Quantity, Discount = @Discount WHERE OrderID = @OrderID AND ProductID = @ProductID";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    // Agregar parámetros al comando
                    comando.Parameters.AddWithValue("@OrderID", orderDetails.OrderID);
                    comando.Parameters.AddWithValue("@ProductID", orderDetails.ProductID);
                    comando.Parameters.AddWithValue("@UnitPrice", orderDetails.UnitPrice);
                    comando.Parameters.AddWithValue("@Quantity", orderDetails.Quantity);
                    comando.Parameters.AddWithValue("@Discount", orderDetails.Discount);

                    // Ejecutar el comando y obtener el número de filas afectadas
                    result = comando.ExecuteNonQuery();

                    conexion.Close();
                }
                return result;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error al insertar: " + sqlEx.Message);
                return result;
            }
        }
        public static int EliminarOrderDetails(int orderId, int productId)
        {
            int retorna = 0;

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Usamos parámetros para evitar la inyección SQL
                string query = "DELETE FROM [Order Details] WHERE OrderID = @OrderID AND ProductID = @ProductID";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadimos los parámetros que se usarán en la consulta
                comando.Parameters.AddWithValue("@OrderID", orderId);
                comando.Parameters.AddWithValue("@ProductID", productId);

                // Ejecutamos la consulta y obtenemos el número de filas afectadas
                retorna = comando.ExecuteNonQuery();
            }

            return retorna;
        }

        // Codigos de buscar
        public static List<OrderDetails> BuscarRegistroOrderID(int OrderID)
        {
            List<OrderDetails> Lista = new List<OrderDetails>();

            try
            {
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL con JOIN entre Order Details y Products, para obtener ProductName
                    string query = @"
                SELECT od.OrderID, od.ProductID, od.UnitPrice, od.Quantity, od.Discount, p.ProductName
                FROM [Order Details] od
                INNER JOIN Products p ON od.ProductID = p.ProductID
                WHERE od.OrderID = @OrderID";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@OrderID", OrderID); // Usamos parámetros para evitar SQL Injection

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OrderDetails orderDetails = new OrderDetails
                            {
                                OrderID = reader.GetInt32(0),
                                ProductID = reader.GetInt32(1),
                                UnitPrice = reader.GetDecimal(2),
                                Quantity = reader.GetInt16(3),
                                Discount = reader.GetFloat(4),
                                ProductName = reader.GetString(5) // Agregar ProductName desde la consulta
                            };

                            Lista.Add(orderDetails);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Manejo de excepciones de base de datos
                Console.WriteLine("Error al consultar la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejo de otras excepciones
                Console.WriteLine("Error inesperado: " + ex.Message);
            }

            return Lista;
        }

        public static List<OrderDetails> BuscarRegistroProductID(int ProductID)
        {
            List<OrderDetails> Lista = new List<OrderDetails>();

            try
            {
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL con JOIN entre Order Details y Products para obtener ProductName
                    string query = @"
                SELECT od.OrderID, od.ProductID, od.UnitPrice, od.Quantity, od.Discount, p.ProductName
                FROM [Order Details] od
                INNER JOIN Products p ON od.ProductID = p.ProductID
                WHERE od.ProductID = @ProductID";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@ProductID", ProductID); // Usamos parámetros para evitar SQL Injection

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OrderDetails orderDetails = new OrderDetails
                            {
                                OrderID = reader.GetInt32(0),
                                ProductID = reader.GetInt32(1),
                                UnitPrice = reader.GetDecimal(2),
                                Quantity = reader.GetInt16(3),
                                Discount = reader.GetFloat(4),
                                ProductName = reader.GetString(5) // Obtener ProductName desde la consulta
                            };

                            Lista.Add(orderDetails);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Manejo de excepciones de base de datos
                Console.WriteLine("Error al consultar la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejo de otras excepciones
                Console.WriteLine("Error inesperado: " + ex.Message);
            }

            return Lista;
        }

        public static List<OrderDetails> BuscarRegistroUnitPrice(decimal UnitPrice)
        {
            List<OrderDetails> Lista = new List<OrderDetails>();

            try
            {
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL con JOIN entre Order Details y Products para obtener ProductName
                    string query = @"
                SELECT od.OrderID, od.ProductID, od.UnitPrice, od.Quantity, od.Discount, p.ProductName
                FROM [Order Details] od
                INNER JOIN Products p ON od.ProductID = p.ProductID
                WHERE od.UnitPrice = @UnitPrice";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@UnitPrice", UnitPrice); // Usamos parámetros para evitar SQL Injection

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OrderDetails orderDetails = new OrderDetails
                            {
                                OrderID = reader.GetInt32(0),
                                ProductID = reader.GetInt32(1),
                                UnitPrice = reader.GetDecimal(2),
                                Quantity = reader.GetInt16(3),
                                Discount = reader.GetFloat(4),
                                ProductName = reader.GetString(5) // Obtener ProductName desde la consulta
                            };

                            Lista.Add(orderDetails);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Manejo de excepciones de base de datos
                Console.WriteLine("Error al consultar la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejo de otras excepciones
                Console.WriteLine("Error inesperado: " + ex.Message);
            }

            return Lista;
        }

        public static List<OrderDetails> BuscarRegistroQuantity(int Quantity)
        {
            List<OrderDetails> Lista = new List<OrderDetails>();

            try
            {
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL con JOIN entre Order Details y Products para obtener ProductName
                    string query = @"
                SELECT od.OrderID, od.ProductID, od.UnitPrice, od.Quantity, od.Discount, p.ProductName
                FROM [Order Details] od
                INNER JOIN Products p ON od.ProductID = p.ProductID
                WHERE od.Quantity = @Quantity";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Quantity", Quantity); // Usamos parámetros para evitar SQL Injection

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OrderDetails orderDetails = new OrderDetails
                            {
                                OrderID = reader.GetInt32(0),
                                ProductID = reader.GetInt32(1),
                                UnitPrice = reader.GetDecimal(2),
                                Quantity = reader.GetInt16(3),
                                Discount = reader.GetFloat(4),
                                ProductName = reader.GetString(5) // Obtener ProductName desde la consulta
                            };

                            Lista.Add(orderDetails);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Manejo de excepciones de base de datos
                Console.WriteLine("Error al consultar la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejo de otras excepciones
                Console.WriteLine("Error inesperado: " + ex.Message);
            }

            return Lista;
        }

        public static List<OrderDetails> BuscarRegistroDiscount(float Discount)
        {
            List<OrderDetails> Lista = new List<OrderDetails>();

            try
            {
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL con JOIN entre Order Details y Products para obtener ProductName
                    string query = @"
                SELECT od.OrderID, od.ProductID, od.UnitPrice, od.Quantity, od.Discount, p.ProductName
                FROM [Order Details] od
                INNER JOIN Products p ON od.ProductID = p.ProductID
                WHERE od.Discount = @Discount";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Discount", Discount); // Usamos parámetros para evitar SQL Injection

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OrderDetails orderDetails = new OrderDetails
                            {
                                OrderID = reader.GetInt32(0),
                                ProductID = reader.GetInt32(1),
                                UnitPrice = reader.GetDecimal(2),
                                Quantity = reader.GetInt16(3),
                                Discount = reader.GetFloat(4),
                                ProductName = reader.GetString(5) // Obtener ProductName desde la consulta
                            };

                            Lista.Add(orderDetails);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Manejo de excepciones de base de datos
                Console.WriteLine("Error al consultar la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejo de otras excepciones
                Console.WriteLine("Error inesperado: " + ex.Message);
            }

            return Lista;
        }

        public static List<OrderDetails> BuscarRegistroProductName(string productName)
        {
            List<OrderDetails> Lista = new List<OrderDetails>();

            try
            {
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL con JOIN entre Order Details y Products para obtener ProductName
                    string query = @"
                SELECT od.OrderID, od.ProductID, od.UnitPrice, od.Quantity, od.Discount, p.ProductName
                FROM [Order Details] od
                INNER JOIN Products p ON od.ProductID = p.ProductID
                WHERE p.ProductName = @ProductName";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@ProductName", productName); // Usamos parámetros para evitar SQL Injection

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OrderDetails orderDetails = new OrderDetails
                            {
                                OrderID = reader.GetInt32(0),
                                ProductID = reader.GetInt32(1),
                                UnitPrice = reader.GetDecimal(2),
                                Quantity = reader.GetInt16(3),
                                Discount = reader.GetFloat(4),
                                ProductName = reader.GetString(5) // Obtener ProductName desde la consulta
                            };

                            Lista.Add(orderDetails);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Manejo de excepciones de base de datos
                Console.WriteLine("Error al consultar la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejo de otras excepciones
                Console.WriteLine("Error inesperado: " + ex.Message);
            }

            return Lista;
        }
    }
}
