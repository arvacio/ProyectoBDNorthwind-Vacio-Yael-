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

            try
            {
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL con dos JOINs: uno con Suppliers y otro con Categories
                    string query = @"
                SELECT p.ProductID, p.ProductName, p.SupplierID, p.CategoryID, p.QuantityPerUnit, 
                       p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder, p.ReorderLevel, p.Discontinued,
                       s.CompanyName, c.CategoryName
                FROM Products p
                INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID
                INNER JOIN Categories c ON p.CategoryID = c.CategoryID";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Products product = new Products
                            {
                                ProductID = reader.GetInt32(0),
                                ProductName = reader.GetString(1),
                                SupplierID = reader.GetInt32(2),
                                CategoryID = reader.GetInt32(3),
                                QuantityPerUnit = reader.GetString(4),
                                UnitPrice = reader.GetDecimal(5),
                                UnitsInStock = reader.GetInt16(6),
                                UnitsOnOrder = reader.GetInt16(7),
                                ReorderLevel = reader.GetInt16(8),
                                Discontinued = reader.GetBoolean(9),
                                CompanyName = reader.GetString(10),  // Obtener CompanyName de Suppliers
                                CategoryName = reader.GetString(11)  // Obtener CategoryName de Categories
                            };

                            Lista.Add(product);
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
                // Consulta SQL con INNER JOINs para obtener CompanyName y CategoryName
                string query = @"
            SELECT p.ProductID, p.ProductName, p.SupplierID, p.CategoryID, p.QuantityPerUnit, 
                   p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder, p.ReorderLevel, p.Discontinued,
                   s.CompanyName, c.CategoryName
            FROM Products p
            INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID
            INNER JOIN Categories c ON p.CategoryID = c.CategoryID
            WHERE p.ProductID = @ProductID";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@ProductID", ProductID);  // Usamos parámetros para evitar inyección SQL

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
                    products.CompanyName = reader.GetString(10);  // Obtener CompanyName de Suppliers
                    products.CategoryName = reader.GetString(11);  // Obtener CategoryName de Categories

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
                // Consulta SQL con INNER JOINs para obtener CompanyName y CategoryName
                string query = @"
            SELECT p.ProductID, p.ProductName, p.SupplierID, p.CategoryID, p.QuantityPerUnit, 
                   p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder, p.ReorderLevel, p.Discontinued,
                   s.CompanyName, c.CategoryName
            FROM Products p
            INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID
            INNER JOIN Categories c ON p.CategoryID = c.CategoryID
            WHERE p.ProductName = @ProductName";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@ProductName", ProductName);  // Usamos parámetros para evitar inyección SQL

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
                    products.CompanyName = reader.GetString(10);  // Obtener CompanyName de Suppliers
                    products.CategoryName = reader.GetString(11);  // Obtener CategoryName de Categories

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
                // Consulta SQL con INNER JOINs para obtener CompanyName y CategoryName
                string query = @"
            SELECT p.ProductID, p.ProductName, p.SupplierID, p.CategoryID, p.QuantityPerUnit, 
                   p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder, p.ReorderLevel, p.Discontinued,
                   s.CompanyName, c.CategoryName
            FROM Products p
            INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID
            INNER JOIN Categories c ON p.CategoryID = c.CategoryID
            WHERE p.SupplierID = @SupplierID";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@SupplierID", SupplierID);  // Usamos parámetros para evitar inyección SQL

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
                    products.CompanyName = reader.GetString(10);  // Obtener CompanyName de Suppliers
                    products.CategoryName = reader.GetString(11);  // Obtener CategoryName de Categories

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
                // Consulta SQL con INNER JOINs para obtener CompanyName y CategoryName
                string query = @"
            SELECT p.ProductID, p.ProductName, p.SupplierID, p.CategoryID, p.QuantityPerUnit, 
                   p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder, p.ReorderLevel, p.Discontinued,
                   s.CompanyName, c.CategoryName
            FROM Products p
            INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID
            INNER JOIN Categories c ON p.CategoryID = c.CategoryID
            WHERE p.CategoryID = @CategoryID";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@CategoryID", CategoryID);  // Usamos parámetros para evitar inyección SQL

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
                    products.CompanyName = reader.GetString(10);  // Obtener CompanyName de Suppliers
                    products.CategoryName = reader.GetString(11);  // Obtener CategoryName de Categories

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
                // Consulta SQL con INNER JOINs para obtener CompanyName y CategoryName
                string query = @"
            SELECT p.ProductID, p.ProductName, p.SupplierID, p.CategoryID, p.QuantityPerUnit, 
                   p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder, p.ReorderLevel, p.Discontinued,
                   s.CompanyName, c.CategoryName
            FROM Products p
            INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID
            INNER JOIN Categories c ON p.CategoryID = c.CategoryID
            WHERE p.QuantityPerUnit = @QuantityPerUnit";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@QuantityPerUnit", QuantityPerUnit);  // Usamos parámetros para evitar inyección SQL

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
                    products.CompanyName = reader.GetString(10);  // Obtener CompanyName de Suppliers
                    products.CategoryName = reader.GetString(11);  // Obtener CategoryName de Categories

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
                // Consulta SQL con INNER JOINs para obtener CompanyName y CategoryName
                string query = @"
            SELECT p.ProductID, p.ProductName, p.SupplierID, p.CategoryID, p.QuantityPerUnit, 
                   p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder, p.ReorderLevel, p.Discontinued,
                   s.CompanyName, c.CategoryName
            FROM Products p
            INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID
            INNER JOIN Categories c ON p.CategoryID = c.CategoryID
            WHERE p.UnitPrice = @UnitPrice";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@UnitPrice", UnitPrice);  // Usamos parámetros para evitar inyección SQL

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
                    products.CompanyName = reader.GetString(10);  // Obtener CompanyName de Suppliers
                    products.CategoryName = reader.GetString(11);  // Obtener CategoryName de Categories

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
                // Consulta SQL con INNER JOINs para obtener CompanyName y CategoryName
                string query = @"
            SELECT p.ProductID, p.ProductName, p.SupplierID, p.CategoryID, p.QuantityPerUnit, 
                   p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder, p.ReorderLevel, p.Discontinued,
                   s.CompanyName, c.CategoryName
            FROM Products p
            INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID
            INNER JOIN Categories c ON p.CategoryID = c.CategoryID
            WHERE p.UnitsInStock = @UnitsInStock";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@UnitsInStock", UnitsInStock);  // Usamos parámetros para evitar inyección SQL

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
                    products.CompanyName = reader.GetString(10);  // Obtener CompanyName de Suppliers
                    products.CategoryName = reader.GetString(11);  // Obtener CategoryName de Categories

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
                // Consulta SQL con INNER JOINs para obtener CompanyName y CategoryName
                string query = @"
            SELECT p.ProductID, p.ProductName, p.SupplierID, p.CategoryID, p.QuantityPerUnit, 
                   p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder, p.ReorderLevel, p.Discontinued,
                   s.CompanyName, c.CategoryName
            FROM Products p
            INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID
            INNER JOIN Categories c ON p.CategoryID = c.CategoryID
            WHERE p.UnitsOnOrder = @UnitsOnOrder";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@UnitsOnOrder", UnitsOnOrder);  // Usamos parámetros para evitar inyección SQL

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
                    products.CompanyName = reader.GetString(10);  // Obtener CompanyName de Suppliers
                    products.CategoryName = reader.GetString(11);  // Obtener CategoryName de Categories

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
                // Consulta SQL con INNER JOINs para obtener CompanyName y CategoryName
                string query = @"
            SELECT p.ProductID, p.ProductName, p.SupplierID, p.CategoryID, p.QuantityPerUnit, 
                   p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder, p.ReorderLevel, p.Discontinued,
                   s.CompanyName, c.CategoryName
            FROM Products p
            INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID
            INNER JOIN Categories c ON p.CategoryID = c.CategoryID
            WHERE p.ReorderLevel = @ReorderLevel";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@ReorderLevel", ReorderLevel);  // Usamos parámetros para evitar inyección SQL

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
                    products.CompanyName = reader.GetString(10);  // Obtener CompanyName de Suppliers
                    products.CategoryName = reader.GetString(11);  // Obtener CategoryName de Categories

                    Lista.Add(products);
                }
                conexion.Close();
                return Lista;
            }
        }


        public static List<Products> BuscarRegistroDiscontinued(string discontinued)
        {
            List<Products> Lista = new List<Products>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL con INNER JOINs para obtener CompanyName y CategoryName
                string query = @"
            SELECT p.ProductID, p.ProductName, p.SupplierID, p.CategoryID, p.QuantityPerUnit, 
                   p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder, p.ReorderLevel, p.Discontinued,
                   s.CompanyName, c.CategoryName
            FROM Products p
            INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID
            INNER JOIN Categories c ON p.CategoryID = c.CategoryID
            WHERE p.Discontinued = @Discontinued";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Discontinued", discontinued);  // Usamos parámetro para evitar inyección SQL

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
                    products.CompanyName = reader.GetString(10);  // Obtener CompanyName de Suppliers
                    products.CategoryName = reader.GetString(11);  // Obtener CategoryName de Categories

                    Lista.Add(products);
                }
                conexion.Close();
                return Lista;
            }
        }


        public static List<Products> BuscarRegistroNoDiscontinued(string nodiscontinued)
        {
            List<Products> Lista = new List<Products>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL con INNER JOINs para obtener CompanyName y CategoryName
                string query = @"
            SELECT p.ProductID, p.ProductName, p.SupplierID, p.CategoryID, p.QuantityPerUnit, 
                   p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder, p.ReorderLevel, p.Discontinued,
                   s.CompanyName, c.CategoryName
            FROM Products p
            INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID
            INNER JOIN Categories c ON p.CategoryID = c.CategoryID
            WHERE p.Discontinued = 0";  // 0 es false, lo que indica que no están discontinuados

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
                    products.CompanyName = reader.GetString(10);  // Obtener CompanyName de Suppliers
                    products.CategoryName = reader.GetString(11);  // Obtener CategoryName de Categories

                    Lista.Add(products);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static List<Products> BuscarRegistroPorCompanyName(string companyName)
        {
            List<Products> Lista = new List<Products>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL con INNER JOINs para obtener CompanyName y CategoryName
                string query = @"
            SELECT p.ProductID, p.ProductName, p.SupplierID, p.CategoryID, p.QuantityPerUnit, 
                   p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder, p.ReorderLevel, p.Discontinued,
                   s.CompanyName, c.CategoryName
            FROM Products p
            INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID
            INNER JOIN Categories c ON p.CategoryID = c.CategoryID
            WHERE s.CompanyName LIKE @CompanyName";  // Usamos LIKE para permitir coincidencias parciales

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@CompanyName", "%" + companyName + "%");  // Agregamos el comodín % para buscar coincidencias parciales

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
                    products.CompanyName = reader.GetString(10);  // Obtener CompanyName de Suppliers
                    products.CategoryName = reader.GetString(11);  // Obtener CategoryName de Categories

                    Lista.Add(products);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static List<Products> BuscarRegistroPorCategoryName(string categoryName)
        {
            List<Products> Lista = new List<Products>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL con INNER JOINs para obtener CompanyName y CategoryName
                string query = @"
            SELECT p.ProductID, p.ProductName, p.SupplierID, p.CategoryID, p.QuantityPerUnit, 
                   p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder, p.ReorderLevel, p.Discontinued,
                   s.CompanyName, c.CategoryName
            FROM Products p
            INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID
            INNER JOIN Categories c ON p.CategoryID = c.CategoryID
            WHERE c.CategoryName LIKE @CategoryName";  // Usamos LIKE para permitir coincidencias parciales

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@CategoryName", "%" + categoryName + "%");  // Comodín % para búsqueda parcial

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
                    products.CompanyName = reader.GetString(10);  // Obtener CompanyName de Suppliers
                    products.CategoryName = reader.GetString(11);  // Obtener CategoryName de Categories

                    Lista.Add(products);
                }
                conexion.Close();
                return Lista;
            }
        }

    }
}
