using Microsoft.Data.SqlClient;


namespace capaDatos
{
    public class Conexion
    {
        private static string cadena =
            "Server=DESKTOP-A20ONI5\\INSTANCE2022;Database=HOSPIMESAT;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }

        public static bool ProbarConexion()
        {
            try
            {
                using (SqlConnection con = ObtenerConexion())
                {
                    con.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}