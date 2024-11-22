using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDNorthwind_Vacio_Yael_
{
    public class ProductsDAL
    {
        // Codigo para agregar un Products
        public static int AgregarProducts(Products products)
        {
            int retorna = 0;

            try
            {
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    string dis = products.Discontinued ? "1" : "0"; 

                    string query = "INSERT INTO products (ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) " +
                                   "VALUES (@ProductName, @SupplierID, @CategoryID, @QuantityPerUnit, @UnitPrice, @UnitsInStock, @UnitsOnOrder, @ReorderLevel, @Discontinued)";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@ProductName", products.ProductName);
                    comando.Parameters.AddWithValue("@SupplierID", products.SupplierID);
                    comando.Parameters.AddWithValue("@CategoryID", products.CategoryID);
                    comando.Parameters.AddWithValue("@QuantityPerUnit", products.QuantityPerUnit);
                    comando.Parameters.AddWithValue("@UnitPrice", products.UnitPrice);
                    comando.Parameters.AddWithValue("@UnitsInStock", products.UnitsInStock);
                    comando.Parameters.AddWithValue("@UnitsOnOrder", products.UnitsOnOrder);
                    comando.Parameters.AddWithValue("@ReorderLevel", products.ReorderLevel);
                    comando.Parameters.AddWithValue("@Discontinued", dis); 
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

        // Codigo para mostrar toda la tabla de Products
        public static List<Products> PresentarRegistro()
        {
            List<Products> Lista = new List<Products>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from products";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Products products = new Products();

                    products.ProductID = reader.GetInt32(0);
                    products.ProductName = reader.GetString(1);
                    products.SupplierID = reader.GetInt32(2);
                    products.CategoryID = reader.GetInt32(3);
                    products.QuantityPerUnit = reader.GetString(4);
                    products.UnitPrice = reader.GetDecimal(5);
                    products.UnitsInStock= reader.GetInt16(6);
                    products.UnitsOnOrder= reader.GetInt16(7);
                    products.ReorderLevel = reader.GetInt16(8);
                    products.Discontinued = reader.GetBoolean(9);


                    Lista.Add(products);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static int ModificarProducts(Products products)
        {
            int result = 0;
            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "UPDATE Products SET ProductName = @ProductName, SupplierID = @SupplierID, CategoryID = @CategoryID, QuantityPerUnit = @QuantityPerUnit, UnitPrice = @UnitPrice, UnitsInStock = @UnitsInStock, UnitsOnOrder = @UnitsOnOrder, ReorderLevel = @ReorderLevel, Discontinued = @Discontinued WHERE ProductID = @ProductID";

                SqlCommand comando = new SqlCommand(query, conexion);

                // Agregar los parámetros con los valores correspondientes del objeto `products`
                comando.Parameters.AddWithValue("@ProductName", products.ProductName);
                comando.Parameters.AddWithValue("@SupplierID", products.SupplierID);
                comando.Parameters.AddWithValue("@CategoryID", products.CategoryID);
                comando.Parameters.AddWithValue("@QuantityPerUnit", products.QuantityPerUnit);
                comando.Parameters.AddWithValue("@UnitPrice", products.UnitPrice);
                comando.Parameters.AddWithValue("@UnitsInStock", products.UnitsInStock);
                comando.Parameters.AddWithValue("@UnitsOnOrder", products.UnitsOnOrder);
                comando.Parameters.AddWithValue("@ReorderLevel", products.ReorderLevel);
                comando.Parameters.AddWithValue("@Discontinued", products.Discontinued);
                comando.Parameters.AddWithValue("@ProductID", products.ProductID);

                result = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return result;
        }

        public static int EliminarProducts(int id)
        {
            int retorna = 0;

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Usamos parámetros para evitar la inyección SQL
                string query = "DELETE FROM products WHERE ProductID = @ProductID";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadimos el parámetro que se usará en la consulta
                comando.Parameters.AddWithValue("@ProductID", id);

                // Ejecutamos la consulta y obtenemos el número de filas afectadas
                retorna = comando.ExecuteNonQuery();
            }

            return retorna;
        }


        // Busquedas

        public static List<Products> BuscarRegistroProductID(int ProductID)
        {
            List<Products> Lista = new List<Products>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from products where ProductID =" + ProductID + "";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Products products = new Products();

                    products.ProductID = reader.GetInt32(0);
                    products.ProductName = reader.GetString(1);
                    products.SupplierID = reader.GetInt32(2);
                    products.CategoryID = reader.GetInt32(3);
                    products.QuantityPerUnit = reader.GetString(4);
                    products.UnitPrice = reader.GetDecimal(5);
                    products.UnitsInStock = reader.GetInt16(6);
                    products.UnitsOnOrder = reader.GetInt16(7);
                    products.ReorderLevel = reader.GetInt16(8);
                    products.Discontinued = reader.GetBoolean(9);
                    Lista.Add(products);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static List<Products> BuscarRegistroProductName(string ProductName)
        {
            List<Products> Lista = new List<Products>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from products where ProductName ='" + ProductName + "'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Products products = new Products();

                    products.ProductID = reader.GetInt32(0);
                    products.ProductName = reader.GetString(1);
                    products.SupplierID = reader.GetInt32(2);
                    products.CategoryID = reader.GetInt32(3);
                    products.QuantityPerUnit = reader.GetString(4);
                    products.UnitPrice = reader.GetDecimal(5);
                    products.UnitsInStock = reader.GetInt16(6);
                    products.UnitsOnOrder = reader.GetInt16(7);
                    products.ReorderLevel = reader.GetInt16(8);
                    products.Discontinued = reader.GetBoolean(9);
                    Lista.Add(products);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static List<Products> BuscarRegistroSupplierID(int SupplierID)
        {
            List<Products> Lista = new List<Products>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from products where SupplierID =" + SupplierID + "";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Products products = new Products();

                    products.ProductID = reader.GetInt32(0);
                    products.ProductName = reader.GetString(1);
                    products.SupplierID = reader.GetInt32(2);
                    products.CategoryID = reader.GetInt32(3);
                    products.QuantityPerUnit = reader.GetString(4);
                    products.UnitPrice = reader.GetDecimal(5);
                    products.UnitsInStock = reader.GetInt16(6);
                    products.UnitsOnOrder = reader.GetInt16(7);
                    products.ReorderLevel = reader.GetInt16(8);
                    products.Discontinued = reader.GetBoolean(9);
                    Lista.Add(products);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static List<Products> BuscarRegistroCategoryID(int CategoryID)
        {
            List<Products> Lista = new List<Products>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from products where CategoryID =" + CategoryID + "";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Products products = new Products();

                    products.ProductID = reader.GetInt32(0);
                    products.ProductName = reader.GetString(1);
                    products.SupplierID = reader.GetInt32(2);
                    products.CategoryID = reader.GetInt32(3);
                    products.QuantityPerUnit = reader.GetString(4);
                    products.UnitPrice = reader.GetDecimal(5);
                    products.UnitsInStock = reader.GetInt16(6);
                    products.UnitsOnOrder = reader.GetInt16(7);
                    products.ReorderLevel = reader.GetInt16(8);
                    products.Discontinued = reader.GetBoolean(9);
                    Lista.Add(products);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static List<Products> BuscarRegistroQuantityPerUnit(string QuantityPerUnit)
        {
            List<Products> Lista = new List<Products>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from products where QuantityPerUnit ='" + QuantityPerUnit + "'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Products products = new Products();

                    products.ProductID = reader.GetInt32(0);
                    products.ProductName = reader.GetString(1);
                    products.SupplierID = reader.GetInt32(2);
                    products.CategoryID = reader.GetInt32(3);
                    products.QuantityPerUnit = reader.GetString(4);
                    products.UnitPrice = reader.GetDecimal(5);
                    products.UnitsInStock = reader.GetInt16(6);
                    products.UnitsOnOrder = reader.GetInt16(7);
                    products.ReorderLevel = reader.GetInt16(8);
                    products.Discontinued = reader.GetBoolean(9);
                    Lista.Add(products);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static List<Products> BuscarRegistroUnitPrice(decimal UnitPrice)
        {
            List<Products> Lista = new List<Products>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from products where UnitPrice =" + UnitPrice + "";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Products products = new Products();

                    products.ProductID = reader.GetInt32(0);
                    products.ProductName = reader.GetString(1);
                    products.SupplierID = reader.GetInt32(2);
                    products.CategoryID = reader.GetInt32(3);
                    products.QuantityPerUnit = reader.GetString(4);
                    products.UnitPrice = reader.GetDecimal(5);
                    products.UnitsInStock = reader.GetInt16(6);
                    products.UnitsOnOrder = reader.GetInt16(7);
                    products.ReorderLevel = reader.GetInt16(8);
                    products.Discontinued = reader.GetBoolean(9);
                    Lista.Add(products);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static List<Products> BuscarRegistroUnitsInStock(int UnitsInStock)
        {
            List<Products> Lista = new List<Products>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from products where UnitsInStock =" + UnitsInStock + "";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Products products = new Products();

                    products.ProductID = reader.GetInt32(0);
                    products.ProductName = reader.GetString(1);
                    products.SupplierID = reader.GetInt32(2);
                    products.CategoryID = reader.GetInt32(3);
                    products.QuantityPerUnit = reader.GetString(4);
                    products.UnitPrice = reader.GetDecimal(5);
                    products.UnitsInStock = reader.GetInt16(6);
                    products.UnitsOnOrder = reader.GetInt16(7);
                    products.ReorderLevel = reader.GetInt16(8);
                    products.Discontinued = reader.GetBoolean(9);
                    Lista.Add(products);
                }
                conexion.Close();
                return Lista;
            }
        }
       
        public static List<Products> BuscarRegistroUnitsOnOrder(int UnitsOnOrder)
        {
            List<Products> Lista = new List<Products>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from products where UnitsOnOrder =" + UnitsOnOrder + "";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Products products = new Products();

                    products.ProductID = reader.GetInt32(0);
                    products.ProductName = reader.GetString(1);
                    products.SupplierID = reader.GetInt32(2);
                    products.CategoryID = reader.GetInt32(3);
                    products.QuantityPerUnit = reader.GetString(4);
                    products.UnitPrice = reader.GetDecimal(5);
                    products.UnitsInStock = reader.GetInt16(6);
                    products.UnitsOnOrder = reader.GetInt16(7);
                    products.ReorderLevel = reader.GetInt16(8);
                    products.Discontinued = reader.GetBoolean(9);
                    Lista.Add(products);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static List<Products> BuscarRegistroReorderLevel(int ReorderLevel)
        {
            List<Products> Lista = new List<Products>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from products where ReorderLevel =" + ReorderLevel + "";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Products products = new Products();

                    products.ProductID = reader.GetInt32(0);
                    products.ProductName = reader.GetString(1);
                    products.SupplierID = reader.GetInt32(2);
                    products.CategoryID = reader.GetInt32(3);
                    products.QuantityPerUnit = reader.GetString(4);
                    products.UnitPrice = reader.GetDecimal(5);
                    products.UnitsInStock = reader.GetInt16(6);
                    products.UnitsOnOrder = reader.GetInt16(7);
                    products.ReorderLevel = reader.GetInt16(8);
                    products.Discontinued = reader.GetBoolean(9);
                    Lista.Add(products);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static List<Products> BuscarRegistroDiscontinued(string Discontinued)
        {
            List<Products> Lista = new List<Products>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {

                string query = "select * from products where Discontinued =" + Discontinued + "";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Products products = new Products();

                    products.ProductID = reader.GetInt32(0);
                    products.ProductName = reader.GetString(1);
                    products.SupplierID = reader.GetInt32(2);
                    products.CategoryID = reader.GetInt32(3);
                    products.QuantityPerUnit = reader.GetString(4);
                    products.UnitPrice = reader.GetDecimal(5);
                    products.UnitsInStock = reader.GetInt16(6);
                    products.UnitsOnOrder = reader.GetInt16(7);
                    products.ReorderLevel = reader.GetInt16(8);
                    products.Discontinued = reader.GetBoolean(9);
                    Lista.Add(products);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static List<Products> BuscarRegistroNoDiscontinued(string NoDiscontinued)
        {
            List<Products> Lista = new List<Products>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {

                string query = "select * from products where Discontinued =" + NoDiscontinued + "";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Products products = new Products();

                    products.ProductID = reader.GetInt32(0);
                    products.ProductName = reader.GetString(1);
                    products.SupplierID = reader.GetInt32(2);
                    products.CategoryID = reader.GetInt32(3);
                    products.QuantityPerUnit = reader.GetString(4);
                    products.UnitPrice = reader.GetDecimal(5);
                    products.UnitsInStock = reader.GetInt16(6);
                    products.UnitsOnOrder = reader.GetInt16(7);
                    products.ReorderLevel = reader.GetInt16(8);
                    products.Discontinued = reader.GetBoolean(9);
                    Lista.Add(products);
                }
                conexion.Close();
                return Lista;
            }
        }







    }
}
