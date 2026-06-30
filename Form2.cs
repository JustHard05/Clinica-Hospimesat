using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Clinica_Hospimesat
{
    public partial class Form2 : MaterialForm
    {
        public Form2()
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

            ConfigurarTabla();
        }

        private void ConfigurarTabla()
        {
            materialListView1.View = View.Details;
            materialListView1.FullRowSelect = true;

            materialListView1.Columns.Add("ID", 70, HorizontalAlignment.Left);
            materialListView1.Columns.Add("Nombre Completo", 250, HorizontalAlignment.Left);
            materialListView1.Columns.Add("No. Identidad", 150, HorizontalAlignment.Left);
            materialListView1.Columns.Add("F. Nacimiento", 120, HorizontalAlignment.Left);
            materialListView1.Columns.Add("Teléfono", 110, HorizontalAlignment.Left);
            materialListView1.Columns.Add("Dirección Residencial", 300, HorizontalAlignment.Left);
            materialListView1.Columns.Add("Sexo", 60, HorizontalAlignment.Left);
        }

        private void CargarPacientes()
        {
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            try
            {
                materialListView1.Items.Clear();

                capaDeNegocios.N_Pacientes negocio = new capaDeNegocios.N_Pacientes();
                DataTable dt = negocio.ObtenerPacientes();

                List<string> filtros = new List<string>();

                if (!string.IsNullOrEmpty(materialTextBox21.Text))
                {
                    filtros.Add($"Convert(id_paciente, 'System.String') LIKE '%{materialTextBox21.Text.Trim()}%'");
                }

                if (!string.IsNullOrEmpty(materialTextBox22.Text))
                {
                    filtros.Add($"nombre LIKE '%{materialTextBox22.Text.Trim()}%'");
                }

                if (!string.IsNullOrEmpty(materialTextBox23.Text))
                {
                    filtros.Add($"identidad LIKE '%{materialTextBox23.Text.Trim()}%'");
                }

                string filtroFinal = string.Join(" AND ", filtros);

                DataRow[] filasFiltradas;
                if (!string.IsNullOrEmpty(filtroFinal))
                {
                    filasFiltradas = dt.Select(filtroFinal); 
                }
                else
                {
                    filasFiltradas = dt.Select();
                }

                foreach (DataRow fila in filasFiltradas)
                {
                    ListViewItem item = new ListViewItem(fila["id_paciente"].ToString());
                    item.SubItems.Add(fila["nombre"].ToString());
                    item.SubItems.Add(fila["identidad"].ToString());

                    if (fila["fecha_nacimiento"] != DBNull.Value)
                    {
                        DateTime fecha = Convert.ToDateTime(fila["fecha_nacimiento"]);
                        item.SubItems.Add(fecha.ToString("dd/MM/yyyy"));
                    }
                    else
                    {
                        item.SubItems.Add("");
                    }

                    item.SubItems.Add(fila["telefono"].ToString());
                    item.SubItems.Add(fila["direccion"].ToString());
                    item.SubItems.Add(fila["sexo"].ToString());

                    materialListView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CargarPacientes();
        }


        private void materialTextBox21_TextChanged(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void materialTextBox22_TextChanged(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void materialTextBox23_TextChanged(object sender, EventArgs e)
        {
            ActualizarTabla();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            materialTextBox21.Text = "";
            materialTextBox22.Text = "";
            materialTextBox23.Text = "";

            CargarPacientes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            materialTextBox21.Text = "";
            materialTextBox22.Text = "";
            materialTextBox23.Text = "";

            CargarPacientes();
        }
    }
}