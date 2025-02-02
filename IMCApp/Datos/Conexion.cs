using Npgsql;

namespace Datos
{
    public class Conexion
    {
        public NpgsqlConnection conexion;
        public NpgsqlConnection ConexionBD()
        {
            string servidor = "localhost";
            int puerto = 5432;
            string usuario = "postgres";
            string clave = "1234";
            string baseDatos = "imcapp";

            string cadenaConexion = "Server=" + servidor + ";" + "Port=" + puerto + ";" + "User Id=" + usuario + ";" + "Password=" + clave + ";" + "Database=" + baseDatos;
            conexion = new NpgsqlConnection(cadenaConexion);
            conexion.Open();

            return conexion;
        }
    }
}
