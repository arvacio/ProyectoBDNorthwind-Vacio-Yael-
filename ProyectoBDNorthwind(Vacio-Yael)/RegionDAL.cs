using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDNorthwind_Vacio_Yael_
{
    public class RegionDAL
    {
        public static int AgregarRegion(Region region)
        {
            int retorna = 0;

            try
            {
                // Abrimos la conexión con la base de datos
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL para insertar un nuevo registro en la tabla Region
                    string query = "INSERT INTO Region (RegionID, RegionDescription) " +
                                   "VALUES (@RegionID, @RegionDescription)";

                    // Creamos el comando SQL
                    SqlCommand comando = new SqlCommand(query, conexion);

                    // Añadimos los parámetros con los valores proporcionados
                    comando.Parameters.AddWithValue("@RegionID", region.RegionID);
                    comando.Parameters.AddWithValue("@RegionDescription", region.RegionDescription);

                    // Ejecutamos la consulta y obtenemos el número de filas afectadas
                    retorna = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                // Si ocurre un error SQL, mostramos el mensaje de error
                MessageBox.Show("Error al insertar la región: " + sqlEx.Message);
            }
            finally
            {
                // Aquí podemos realizar alguna acción adicional si es necesario, como cerrar recursos explícitos.
            }

            // Retornamos el número de filas afectadas (0 si no se insertó nada)
            return retorna;
        }

        public static List<Region> PresentarRegistroRegion()
        {
            List<Region> lista = new List<Region>();

            try
            {
                // Abrimos la conexión a la base de datos
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL para obtener todos los registros de la tabla Region
                    string query = "SELECT RegionID, RegionDescription FROM Region";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    // Ejecutamos la consulta y obtenemos el lector de datos
                    SqlDataReader reader = comando.ExecuteReader();

                    // Iteramos sobre los registros obtenidos
                    while (reader.Read())
                    {
                        // Creamos un nuevo objeto de tipo Region
                        Region region = new Region();

                        // Asignamos los valores obtenidos a las propiedades del objeto
                        region.RegionID = reader.GetInt32(0);  // RegionID (int)
                        region.RegionDescription = reader.GetString(1);  // RegionDescription (nchar)

                        // Añadimos el objeto a la lista
                        lista.Add(region);
                    }

                    // Cerramos la conexión después de usarla
                    conexion.Close();
                }
            }
            catch (SqlException sqlEx)
            {
                // Si ocurre un error, mostramos el mensaje correspondiente
                MessageBox.Show("Error al obtener los registros: " + sqlEx.Message);
            }

            // Retornamos la lista de registros obtenidos
            return lista;
        }

        public static int ModificarRegion(Region region)
        {
            int result = 0;

            try
            {
                // Abrimos la conexión a la base de datos
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL para actualizar un registro en la tabla Region
                    string query = "UPDATE Region SET " +
                                   "RegionDescription = @RegionDescription " +
                                   "WHERE RegionID = @RegionID";

                    // Creamos el comando SQL y añadimos los parámetros
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@RegionID", region.RegionID);
                    comando.Parameters.AddWithValue("@RegionDescription", region.RegionDescription);

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


        public static int EliminarRegion(int regionId)
        {
            int result = 0;

            try
            {
                // Establecemos la conexión con la base de datos
                using (SqlConnection conexion = BDGeneral.ObtenerConexion())
                {
                    // Consulta SQL para eliminar el registro en la tabla Region donde el RegionID coincida
                    string query = "DELETE FROM Region WHERE RegionID = @RegionID";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    // Añadimos el parámetro para evitar inyecciones SQL
                    comando.Parameters.AddWithValue("@RegionID", regionId);

                    // Ejecutamos la consulta
                    result = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                // Si ocurre un error, mostramos el mensaje correspondiente
                MessageBox.Show("Error al eliminar la región: " + sqlEx.Message);
            }

            // Devolvemos el número de filas afectadas (0 si no se eliminó ningún registro, 1 si se eliminó correctamente)
            return result;
        }


        // Busquedas

        public static List<Region> BuscarRegistroRegionID(int regionID)
        {
            List<Region> lista = new List<Region>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL para buscar por RegionID
                string query = "SELECT * FROM Region WHERE RegionID = @RegionID";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadir el parámetro para evitar inyección SQL
                comando.Parameters.AddWithValue("@RegionID", regionID);

                try
                {
                    // Ejecutar la consulta
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Region region = new Region();

                        // Asignar valores de cada columna al objeto Region
                        region.RegionID = reader.GetInt32(0);
                        region.RegionDescription = reader.GetString(1);

                        // Añadir el objeto a la lista
                        lista.Add(region);
                    }

                    conexion.Close();
                }
                catch (SqlException sqlEx)
                {
                    // Manejo de errores
                    MessageBox.Show("Error al realizar la búsqueda: " + sqlEx.Message);
                }

                return lista;
            }
        }

        public static List<Region> BuscarRegistroRegionDescription(string regionDescription)
        {
            List<Region> lista = new List<Region>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Consulta SQL para buscar por RegionDescription
                string query = "SELECT * FROM Region WHERE RegionDescription LIKE @RegionDescription";
                SqlCommand comando = new SqlCommand(query, conexion);

                // Añadir el parámetro para evitar inyección SQL
                comando.Parameters.AddWithValue("@RegionDescription", "%" + regionDescription + "%");

                try
                {
                    // Ejecutar la consulta
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Region region = new Region();

                        // Asignar valores de cada columna al objeto Region
                        region.RegionID = reader.GetInt32(0);
                        region.RegionDescription = reader.GetString(1);

                        // Añadir el objeto a la lista
                        lista.Add(region);
                    }

                    conexion.Close();
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
