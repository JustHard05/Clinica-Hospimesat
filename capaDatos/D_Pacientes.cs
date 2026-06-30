using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace capaDatos
{
    public class D_Pacientes
    {
        public DataTable ListarPacientes()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT id_paciente, CAST(id_paciente AS VARCHAR(10)) AS id_texto, nombre, identidad, fecha_nacimiento, telefono, direccion, sexo FROM paciente";

            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            tabla.Load(reader);
                        }
                    }
                }
                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Capa Datos (Listar): " + ex.Message);
            }
        }

        public bool RegistrarPaciente(string nombre, string identidad, DateTime fechaNac, string telefono, string direccion, string sexo)
        {
            string query = "INSERT INTO paciente (nombre, identidad, fecha_nacimiento, telefono, direccion, sexo) " +
                           "VALUES (@nombre, @identidad, @fechaNac, @telefono, @direccion, @sexo)";

            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@identidad", identidad);
                        cmd.Parameters.AddWithValue("@fechaNac", fechaNac);
                        cmd.Parameters.AddWithValue("@telefono", string.IsNullOrEmpty(telefono) ? (object)DBNull.Value : telefono);
                        cmd.Parameters.AddWithValue("@direccion", string.IsNullOrEmpty(direccion) ? (object)DBNull.Value : direccion);
                        cmd.Parameters.AddWithValue("@sexo", string.IsNullOrEmpty(sexo) ? (object)DBNull.Value : sexo);

                        con.Open();
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Capa Datos (Registrar): " + ex.Message);
            }
        }
    }
}