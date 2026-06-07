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
    }
}
