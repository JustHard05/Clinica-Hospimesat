namespace Clinica_Hospimesat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
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

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
