using System;
using System.Drawing; 
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Clinica_Hospimesat
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
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

            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistroDePaciente(object sender, EventArgs e)
        {
            Form2 ventanaRegistros = new Form2();
            ventanaRegistros.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void btnAgentasDeCitas_Click(object sender, EventArgs e)
        {
            Form3 ventanaCitas = new Form3();
            ventanaCitas.Show();
        }

        private void btnNuevoPaciente_Click(object sender, EventArgs e)
        {
            Form4 ventanaNuevoPaciente = new Form4();
            ventanaNuevoPaciente.Show();
        }

        private void btnResgistroDePacientes_Click(object sender, EventArgs e)
        {
            Form2 ventanaRegistros = new Form2();
            ventanaRegistros.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                capaDeNegocios.N_Pacientes conexionTest = new capaDeNegocios.N_Pacientes();

                conexionTest.ObtenerPacientes();

                lblEstadoServidor.Text = "● Servidor: Conectado";
                lblEstadoServidor.ForeColor = Color.DarkGreen;
                lblEstadoServidor.Refresh();
            }
            catch (Exception)
            {
                lblEstadoServidor.Text = "● Servidor: Desconectado / Error de red";
                lblEstadoServidor.ForeColor = Color.Red;
                lblEstadoServidor.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Form2 ventanaRegistros = new Form2();
            ventanaRegistros.Show();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Form3 ventanaCitas = new Form3();
            ventanaCitas.Show();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            Form4 ventanaNuevoPaciente = new Form4();
            ventanaNuevoPaciente.Show();
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            try
            {
                capaDeNegocios.N_Pacientes negocio = new capaDeNegocios.N_Pacientes();

                string resultado = negocio.GuardarPaciente(
                    "Paciente Prueba Capas",
                    "0801199999999",
                    DateTime.Now,
                    "2222-3333",
                    "Direccion de Prueba",
                    "M"
                );

                if (resultado == "OK")
                {
                    MessageBox.Show("Operación exitosa: El registro fue procesado e insertado correctamente a través de la arquitectura de capas.", "Confirmación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Advertencia de negocio: " + resultado, "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción detectada en el flujo de datos: " + ex.Message, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblEstadoServior_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}