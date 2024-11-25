using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDNorthwind_Vacio_Yael_
{
    public class TerritoriesDAL
    {

        public static int AgregarTerritory(Territories territory)
        {
            int retorna = 0;

            try
            {
                // Abrimos la conexión con la base de datos
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL para insertar un nuevo registro en la tabla Territories
                    string query = "INSERT INTO Territories (TerritoryID, TerritoryDescription, RegionID) " +
                                   "VALUES (@TerritoryID, @TerritoryDescription, @RegionID)";

                    // Creamos el comando SQL
                    SqlCommand comando = new SqlCommand(query, conexion);

                    // Añadimos los parámetros con los valores proporcionados
                    comando.Parameters.AddWithValue("@TerritoryID", territory.TerritoryID);
                    comando.Parameters.AddWithValue("@TerritoryDescription", territory.TerritoryDescription);
                    comando.Parameters.AddWithValue("@RegionID", territory.RegionID);

                    // Ejecutamos la consulta y obtenemos el número de filas afectadas
                    retorna = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                // Si ocurre un error SQL, mostramos el mensaje de error
                MessageBox.Show("Error al insertar: " + sqlEx.Message);
            }
            finally
            {
                // Aquí podemos realizar alguna acción adicional si es necesario, como cerrar recursos explícitos.
            }

            // Retornamos el número de filas afectadas (0 si no se insertó nada)
            return retorna;
        }

        public static List<Territories> PresentarRegistroTerritories()
        {
            List<Territories> lista = new List<Territories>();

            try
            {
                // Abrimos la conexión a la base de datos
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL para obtener los registros de la tabla Territories y Region
                    string query = @"
                SELECT 
                    t.TerritoryID, 
                    t.TerritoryDescription, 
                    t.RegionID, 
                    r.RegionDescription 
                FROM 
                    Territories t
                INNER JOIN 
                    Region r ON t.RegionID = r.RegionID";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        // Ejecutamos la consulta y obtenemos el lector de datos
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Iteramos sobre los registros obtenidos
                            while (reader.Read())
                            {
                                // Creamos un nuevo objeto de tipo Territories
                                Territories territory = new Territories
                                {
                                    TerritoryID = reader.GetString(0),   // TerritoryID (nvarchar)
                                    TerritoryDescription = reader.GetString(1),  // TerritoryDescription (nchar)
                                    RegionID = reader.GetInt32(2),  // RegionID (int)
                                    RegionDescription = reader.GetString(3)  // RegionDescription (nchar)
                                };

                                // Añadimos el objeto a la lista
                                lista.Add(territory);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) // Capturamos una excepción general
            {
                // Si ocurre un error, mostramos el mensaje correspondiente
                MessageBox.Show("Error al obtener los registros: " + ex.Message);
            }

            // Retornamos la lista de registros obtenidos
            return lista;
        }


        public static int ModificarTerritories(Territories territory)
        {
            int result = 0;

            try
            {
                // Abrimos la conexión a la base de datos
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL para actualizar un registro en la tabla Territories
                    string query = "UPDATE Territories SET " +
                                   "TerritoryDescription = @TerritoryDescription, " +
                                   "RegionID = @RegionID " +
                                   "WHERE TerritoryID = @TerritoryID";

                    // Creamos el comando SQL y añadimos los parámetros
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@TerritoryID", territory.TerritoryID);
                    comando.Parameters.AddWithValue("@TerritoryDescription", territory.TerritoryDescription);
                    comando.Parameters.AddWithValue("@RegionID", territory.RegionID);

                    // Ejecutamos el comando
                    result = comando.ExecuteNonQuery();

                    // Cerramos la conexión
                    conexion.Close();
                }
            }
            catch (SqlException sqlEx)
            {
                // Si ocurre una excepción, mostramos un mensaje con el error
                MessageBox.Show("Error al modificar el registro: " + sqlEx.Message);
            }

            // Retornamos el número de filas afectadas
            return result;
        }

        public static int EliminarTerritory(string territoryId)
        {
            int result = 0;

            try
            {
                // Establecemos la conexión con la base de datos
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL para eliminar el registro en la tabla Territories donde el TerritoryID coincida
                    string query = "DELETE FROM Territories WHERE TerritoryID = @TerritoryID";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    // Añadimos el parámetro para evitar inyecciones SQL
                    comando.Parameters.AddWithValue("@TerritoryID", territoryId);

                    // Ejecutamos la consulta
                    result = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                // Si ocurre un error, mostramos el mensaje correspondiente
                MessageBox.Show("Error al eliminar el territorio: " + sqlEx.Message);
            }

            // Devolvemos el número de filas afectadas (0 si no se eliminó ningún registro, 1 si se eliminó correctamente)
            return result;
        }

        // Busquedas

        public static List<Territories> BuscarRegistroTerritoryID(string TerritoryID)
        {
            List<Territories> lista = new List<Territories>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL para buscar por TerritoryID con JOIN a la tabla Region
                string query = @"
            SELECT 
                t.TerritoryID, 
                t.TerritoryDescription, 
                t.RegionID, 
                r.RegionDescription
            FROM 
                Territories t
            INNER JOIN 
                Region r ON t.RegionID = r.RegionID
            WHERE 
                t.TerritoryID = @TerritoryID";

                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadir el parámetro para evitar inyección SQL
                comando.Parameters.AddWithValue("@TerritoryID", TerritoryID);

                try
                {
                    // Ejecutar la consulta
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Territories territory = new Territories();

                            // Asignar valores de cada columna al objeto Territories
                            territory.TerritoryID = reader.GetString(0);  // TerritoryID
                            territory.TerritoryDescription = reader.GetString(1);  // TerritoryDescription
                            territory.RegionID = reader.GetInt32(2);  // RegionID
                            territory.RegionDescription = reader.GetString(3);  // RegionDescription

                            // Añadir el objeto a la lista
                            lista.Add(territory);
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    // Manejo de errores
                    MessageBox.Show("Error al realizar la búsqueda: " + sqlEx.Message);
                }

                return lista;
            }
        }


        public static List<Territories> BuscarRegistroTerritoryDescription(string TerritoryDescription)
        {
            List<Territories> lista = new List<Territories>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL para buscar por TerritoryDescription con JOIN a la tabla Region
                string query = @"
            SELECT 
                t.TerritoryID, 
                t.TerritoryDescription, 
                t.RegionID, 
                r.RegionDescription
            FROM 
                Territories t
            INNER JOIN 
                Region r ON t.RegionID = r.RegionID
            WHERE 
                t.TerritoryDescription LIKE @TerritoryDescription";

                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadir el parámetro para evitar inyección SQL
                comando.Parameters.AddWithValue("@TerritoryDescription", "%" + TerritoryDescription + "%");

                try
                {
                    // Ejecutar la consulta
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Territories territory = new Territories();

                            // Asignar valores de cada columna al objeto Territories
                            territory.TerritoryID = reader.GetString(0);  // TerritoryID
                            territory.TerritoryDescription = reader.GetString(1);  // TerritoryDescription
                            territory.RegionID = reader.GetInt32(2);  // RegionID
                            territory.RegionDescription = reader.GetString(3);  // RegionDescription

                            // Añadir el objeto a la lista
                            lista.Add(territory);
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    // Manejo de errores
                    MessageBox.Show("Error al realizar la búsqueda: " + sqlEx.Message);
                }

                return lista;
            }
        }


        public static List<Territories> BuscarRegistroRegionID(int RegionID)
        {
            List<Territories> lista = new List<Territories>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL para buscar por RegionID con JOIN a la tabla Region
                string query = @"
            SELECT 
                t.TerritoryID, 
                t.TerritoryDescription, 
                t.RegionID, 
                r.RegionDescription
            FROM 
                Territories t
            INNER JOIN 
                Region r ON t.RegionID = r.RegionID
            WHERE 
                t.RegionID = @RegionID";

                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadir el parámetro para evitar inyección SQL
                comando.Parameters.AddWithValue("@RegionID", RegionID);

                try
                {
                    // Ejecutar la consulta
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Territories territory = new Territories();

                            // Asignar valores de cada columna al objeto Territories
                            territory.TerritoryID = reader.GetString(0);  // TerritoryID
                            territory.TerritoryDescription = reader.GetString(1);  // TerritoryDescription
                            territory.RegionID = reader.GetInt32(2);  // RegionID
                            territory.RegionDescription = reader.GetString(3);  // RegionDescription

                            // Añadir el objeto a la lista
                            lista.Add(territory);
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    // Manejo de errores
                    MessageBox.Show("Error al realizar la búsqueda: " + sqlEx.Message);
                }

                return lista;
            }
        }

        public static List<Territories> BuscarRegistroRegionDescription(string RegionDescription)
        {
            List<Territories> lista = new List<Territories>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL para buscar por RegionDescription con JOIN a la tabla Territories
                string query = @"
            SELECT 
                t.TerritoryID, 
                t.TerritoryDescription, 
                t.RegionID, 
                r.RegionDescription
            FROM 
                Territories t
            INNER JOIN 
                Region r ON t.RegionID = r.RegionID
            WHERE 
                r.RegionDescription LIKE @RegionDescription";

                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadir el parámetro para evitar inyección SQL
                comando.Parameters.AddWithValue("@RegionDescription", "%" + RegionDescription + "%");

                try
                {
                    // Ejecutar la consulta
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Territories territory = new Territories();

                            // Asignar valores de cada columna al objeto Territories
                            territory.TerritoryID = reader.GetString(0);  // TerritoryID
                            territory.TerritoryDescription = reader.GetString(1);  // TerritoryDescription
                            territory.RegionID = reader.GetInt32(2);  // RegionID
                            territory.RegionDescription = reader.GetString(3);  // RegionDescription

                            // Añadir el objeto a la lista
                            lista.Add(territory);
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    // Manejo de errores
                    MessageBox.Show("Error al realizar la búsqueda: " + sqlEx.Message);
                }

                return lista;
            }
        }
    }
}
