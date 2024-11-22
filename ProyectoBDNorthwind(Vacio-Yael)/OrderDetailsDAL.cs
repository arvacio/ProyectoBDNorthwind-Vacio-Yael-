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

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "SELECT * FROM [Order Details]";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    OrderDetails orderDetails = new OrderDetails();

                    orderDetails.OrderID = reader.GetInt32(0);
                    orderDetails.ProductID = reader.GetInt32(1);
                    orderDetails.UnitPrice = reader.GetDecimal(2);
                    orderDetails.Quantity = reader.GetInt16(3);
                    orderDetails.Discount = reader.GetFloat(4);

                    Lista.Add(orderDetails);
                }

                conexion.Close();
                return Lista;
            }
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

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from [Order Details] where OrderID =" + OrderID + "";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    OrderDetails orderDetails = new OrderDetails();

                    orderDetails.OrderID = reader.GetInt32(0);
                    orderDetails.ProductID = reader.GetInt32(1);
                    orderDetails.UnitPrice = reader.GetDecimal(2);
                    orderDetails.Quantity = reader.GetInt16(3);
                    orderDetails.Discount = reader.GetFloat(4);

                    Lista.Add(orderDetails);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static List<OrderDetails> BuscarRegistroProductID(int ProductID)
        {
            List<OrderDetails> Lista = new List<OrderDetails>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from [Order Details] where ProductID =" + ProductID + "";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    OrderDetails orderDetails = new OrderDetails();

                    orderDetails.OrderID = reader.GetInt32(0);
                    orderDetails.ProductID = reader.GetInt32(1);
                    orderDetails.UnitPrice = reader.GetDecimal(2);
                    orderDetails.Quantity = reader.GetInt16(3);
                    orderDetails.Discount = reader.GetFloat(4);

                    Lista.Add(orderDetails);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static List<OrderDetails> BuscarRegistroUnitPrice(Decimal UnitPrice)
        {
            List<OrderDetails> Lista = new List<OrderDetails>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from [Order Details] where UnitPrice =" + UnitPrice + "";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    OrderDetails orderDetails = new OrderDetails();

                    orderDetails.OrderID = reader.GetInt32(0);
                    orderDetails.ProductID = reader.GetInt32(1);
                    orderDetails.UnitPrice = reader.GetDecimal(2);
                    orderDetails.Quantity = reader.GetInt16(3);
                    orderDetails.Discount = reader.GetFloat(4);

                    Lista.Add(orderDetails);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static List<OrderDetails> BuscarRegistroQuantity(int Quantity)
        {
            List<OrderDetails> Lista = new List<OrderDetails>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from [Order Details] where Quantity =" + Quantity + "";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    OrderDetails orderDetails = new OrderDetails();

                    orderDetails.OrderID = reader.GetInt32(0);
                    orderDetails.ProductID = reader.GetInt32(1);
                    orderDetails.UnitPrice = reader.GetDecimal(2);
                    orderDetails.Quantity = reader.GetInt16(3);
                    orderDetails.Discount = reader.GetFloat(4);

                    Lista.Add(orderDetails);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static List<OrderDetails> BuscarRegistroDiscount(float Discount)
        {
            List<OrderDetails> Lista = new List<OrderDetails>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from [Order Details] where Discount =" + Discount + "";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    OrderDetails orderDetails = new OrderDetails();

                    orderDetails.OrderID = reader.GetInt32(0);
                    orderDetails.ProductID = reader.GetInt32(1);
                    orderDetails.UnitPrice = reader.GetDecimal(2);
                    orderDetails.Quantity = reader.GetInt16(3);
                    orderDetails.Discount = reader.GetFloat(4);

                    Lista.Add(orderDetails);
                }
                conexion.Close();
                return Lista;
            }
        }

    }
    }
