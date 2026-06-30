using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Clinica_Hospimesat
{
    public partial class Form4 : MaterialForm
    {
        public Form4()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800,
                Primary.Blue900,
                Primary.Blue500,
                Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            txtIdentidad.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            cmbSexo.SelectedIndex = -1;
            dtpFechaNacimiento.Value = DateTime.Now;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text.Trim()) || string.IsNullOrEmpty(txtIdentidad.Text.Trim()))
            {
                MessageBox.Show("Por favor, rellene los campos obligatorios (Nombre e Identidad).",
                                "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbSexo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione el sexo del paciente.",
                                "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                capaDeNegocios.N_Pacientes negocio = new capaDeNegocios.N_Pacientes();

                string nombre = txtNombre.Text.Trim();
                string identidad = txtIdentidad.Text.Trim();
                DateTime fechaNac = dtpFechaNacimiento.Value;
                string telefono = txtTelefono.Text.Trim();
                string direccion = txtDireccion.Text.Trim();
                string sexo = cmbSexo.SelectedItem.ToString();

                string respuesta = negocio.GuardarPaciente(nombre, identidad, fechaNac, telefono, direccion, sexo);

                if (respuesta == "OK")
                {
                    MessageBox.Show("¡Paciente registrado exitosamente en el sistema!",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show(respuesta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico: " + ex.Message, "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}