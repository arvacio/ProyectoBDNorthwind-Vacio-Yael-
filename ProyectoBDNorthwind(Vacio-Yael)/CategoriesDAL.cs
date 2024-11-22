using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDNorthwind_Vacio_Yael_
{
    public class CategoriesDAL
    {

        public static int AgregarCategories(Categories categoria)
        {
            int result = 0; // Variable para almacenar el resultado de la operación

            using (SqlConnection conexion = BDGeneral.ObtenerConexion()) // Obtener conexión a la base de datos
            {
                // Consulta SQL para insertar una nueva categoría
                string query = "INSERT INTO Categories (CategoryName, Description) " +
                               "VALUES (@CategoryName, @Description)";

                SqlCommand comando = new SqlCommand(query, conexion);

                // Agregar los parámetros al comando
                comando.Parameters.AddWithValue("@CategoryName", categoria.CategoryName);
                comando.Parameters.AddWithValue("@Description", categoria.Description ?? (object)DBNull.Value); // Usar DBNull para valores null
               /* comando.Parameters.AddWithValue("@Picture", categoria.Picture ?? (object)DBNull.Value);*/ // Usar DBNull si Picture es nulo

                try
                {
                    // Ejecutar el comando SQL y obtener el número de filas afectadas
                    result = comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    MessageBox.Show("Error al agregar categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return result; // Devuelve el número de filas afectadas
        }

        public static List<Categories> PresentarRegistro()
        {
            List<Categories> Lista = new List<Categories>();

            try
            {
                // Abrimos la conexión con la base de datos
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Definimos la consulta SQL para obtener todos los registros de Categories
                    string query = "SELECT CategoryID, CategoryName, Description, Picture FROM Categories";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    // Ejecutamos la consulta
                    SqlDataReader reader = comando.ExecuteReader();

                    // Iteramos sobre cada fila del resultado
                    while (reader.Read())
                    {
                        Categories category = new Categories();

                        // Mapeamos los valores obtenidos de la consulta a las propiedades del objeto 'Categories'
                        category.CategoryID = reader.GetInt32(0);
                        category.CategoryName = reader.GetString(1);
                        category.Description = reader.IsDBNull(2) ? null : reader.GetString(2);
                        category.Picture = reader.IsDBNull(3) ? null : (byte[])reader["Picture"]; // Si la columna Picture tiene un valor de tipo imagen

                        // Añadimos el objeto Category a la lista
                        Lista.Add(category);
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error al recuperar los registros: " + sqlEx.Message);
            }

            return Lista;
        }

        public static int ModificarCategory(Categories category)
        {
            int result = 0;

            try
            {
                // Abrimos la conexión con la base de datos
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Definimos la consulta SQL para actualizar un registro en la tabla Categories
                    string query = "UPDATE Categories " +
                                   "SET CategoryName = @CategoryName, Description = @Description " +
                                   "WHERE CategoryID = @CategoryID";

                    // Creamos el comando SQL y añadimos los parámetros correspondientes
                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@CategoryID", category.CategoryID);
                    comando.Parameters.AddWithValue("@CategoryName", category.CategoryName);
                    comando.Parameters.AddWithValue("@Description", category.Description ?? (object)DBNull.Value); // Usamos DBNull si Description es null
                   /* comando.Parameters.AddWithValue("@Picture", category.Picture ?? (object)DBNull.Value)*/; // Usamos DBNull si Picture es null

                    // Ejecutamos la consulta
                    result = comando.ExecuteNonQuery();

                    conexion.Close();
                }
            }
            catch (SqlException sqlEx)
            {
                // Manejo de errores en caso de que ocurra una excepción SQL
                MessageBox.Show("Error al modificar la categoría: " + sqlEx.Message);
            }

            // Devolvemos el resultado de la operación (número de filas afectadas)
            return result;
        }

        public static int EliminarCategory(int categoryID)
        {
            int result = 0;

            try
            {
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Definimos la consulta SQL para eliminar un registro de la tabla Categories
                    string query = "DELETE FROM Categories WHERE CategoryID = @CategoryID";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    // Añadimos el parámetro que se usará en la consulta
                    comando.Parameters.AddWithValue("@CategoryID", categoryID);

                    // Ejecutamos la consulta y obtenemos el número de filas afectadas
                    result = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                // Manejo de excepciones si ocurre un error SQL
                MessageBox.Show("Error al eliminar la categoría: " + sqlEx.Message);
            }

            return result; // Devolvemos el número de filas afectadas (debería ser 1 si se eliminó correctamente)
        }

        // Busquedas

        public static List<Categories> BuscarRegistroCategoryID(int categoryID)
        {
            List<Categories> Lista = new List<Categories>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL para buscar por CategoryID
                string query = "SELECT * FROM Categories WHERE CategoryID = @CategoryID";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Se agrega el parámetro CategoryID para evitar inyección SQL
                comando.Parameters.AddWithValue("@CategoryID", categoryID);

                // Ejecutamos la consulta y obtenemos el lector de datos
                SqlDataReader reader = comando.ExecuteReader();

                // Mientras haya registros
                while (reader.Read())
                {
                    Categories category = new Categories();

                    // Asignar valores de cada columna al objeto Category
                    category.CategoryID = reader.GetInt32(0);
                    category.CategoryName = reader.GetString(1);
                    category.Description = reader.IsDBNull(2) ? null : reader.GetString(2);
                    category.Picture = reader.IsDBNull(3) ? null : (byte[])reader["Picture"];

                    // Añadir la categoría a la lista
                    Lista.Add(category);
                }

                conexion.Close();
                return Lista;
            }
        }

        public static List<Categories> BuscarRegistroCategoryName(string categoryName)
        {
            List<Categories> Lista = new List<Categories>();

            try
            {
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL para buscar por CategoryName
                    string query = "SELECT * FROM Categories WHERE CategoryName LIKE @CategoryName";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    // Se agrega el parámetro CategoryName para evitar inyección SQL
                    comando.Parameters.AddWithValue("@CategoryName", "%" + categoryName + "%");

                    // Ejecutamos la consulta y obtenemos el lector de datos
                    SqlDataReader reader = comando.ExecuteReader();

                    // Mientras haya registros
                    while (reader.Read())
                    {
                        Categories category = new Categories();

                        // Asignar valores de cada columna al objeto Category
                        category.CategoryID = reader.GetInt32(0); // CategoryID
                        category.CategoryName = reader.GetString(1); // CategoryName
                        category.Description = reader.IsDBNull(2) ? null : reader.GetString(2); // Description
                        category.Picture = reader.IsDBNull(3) ? null : (byte[])reader["Picture"]; // Picture (si aplica)

                        // Añadir la categoría a la lista
                        Lista.Add(category);
                    }

                    conexion.Close();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error al buscar categoría: " + sqlEx.Message);
            }

            return Lista;
        }

        public static List<Categories> BuscarRegistroDescription(string description)
        {
            List<Categories> Lista = new List<Categories>();

            try
            {
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL para buscar por Description
                    string query = "SELECT * FROM Categories WHERE Description LIKE @Description";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    // Se agrega el parámetro Description para evitar inyección SQL
                    comando.Parameters.AddWithValue("@Description", "%" + description + "%");

                    // Ejecutamos la consulta y obtenemos el lector de datos
                    SqlDataReader reader = comando.ExecuteReader();

                    // Mientras haya registros
                    while (reader.Read())
                    {
                        Categories category = new Categories();

                        // Asignar valores de cada columna al objeto Category
                        category.CategoryID = reader.GetInt32(0); // CategoryID
                        category.CategoryName = reader.GetString(1); // CategoryName
                        category.Description = reader.IsDBNull(2) ? null : reader.GetString(2); // Description
                        category.Picture = reader.IsDBNull(3) ? null : (byte[])reader["Picture"]; // Picture (si aplica)

                        // Añadir la categoría a la lista
                        Lista.Add(category);
                    }

                    conexion.Close();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error al buscar categoría: " + sqlEx.Message);
            }

            return Lista;
        }





    }
}
