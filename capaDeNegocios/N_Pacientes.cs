using System;
using System.Data;
using capaDatos; 

namespace capaDeNegocios
{
    public class N_Pacientes
    {
        private D_Pacientes objetoDatos = new D_Pacientes();

        public DataTable ObtenerPacientes()
        {
            return objetoDatos.ListarPacientes();
        }

        public string GuardarPaciente(string nombre, string identidad, DateTime fechaNac, string telefono, string direccion, string sexo)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                return "El nombre del paciente es obligatorio.";

            if (string.IsNullOrWhiteSpace(identidad))
                return "El número de identidad es obligatorio.";

            bool exito = objetoDatos.RegistrarPaciente(nombre, identidad, fechaNac, telefono, direccion, sexo);

            return exito ? "OK" : "No se pudo registrar el paciente.";
        }
    }
}