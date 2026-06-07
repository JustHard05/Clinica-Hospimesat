namespace Clinica_Hospimesat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button3 = new Button();
            btnSalir = new Button();
            btnAgentasDeCitas = new Button();
            btnNuevoPaciente = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            btnResgistroDePacientes = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(363, 24);
            button3.Name = "button3";
            button3.Size = new Size(45, 41);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(31, 416);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(76, 41);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleRight;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button5_Click;
            // 
            // btnAgentasDeCitas
            // 
            btnAgentasDeCitas.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAgentasDeCitas.Image = (Image)resources.GetObject("btnAgentasDeCitas.Image");
            btnAgentasDeCitas.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgentasDeCitas.Location = new Point(31, 229);
            btnAgentasDeCitas.Name = "btnAgentasDeCitas";
            btnAgentasDeCitas.Size = new Size(251, 40);
            btnAgentasDeCitas.TabIndex = 5;
            btnAgentasDeCitas.Text = "Agentas De Citas";
            btnAgentasDeCitas.UseVisualStyleBackColor = true;
            btnAgentasDeCitas.Click += btnAgentasDeCitas_Click;
            // 
            // btnNuevoPaciente
            // 
            btnNuevoPaciente.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnNuevoPaciente.Image = (Image)resources.GetObject("btnNuevoPaciente.Image");
            btnNuevoPaciente.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoPaciente.Location = new Point(31, 299);
            btnNuevoPaciente.Name = "btnNuevoPaciente";
            btnNuevoPaciente.Size = new Size(251, 40);
            btnNuevoPaciente.TabIndex = 6;
            btnNuevoPaciente.Text = "Nuevo Paciente";
            btnNuevoPaciente.UseVisualStyleBackColor = true;
            btnNuevoPaciente.Click += btnNuevoPaciente_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(342, 87);
            button1.Name = "button1";
            button1.Size = new Size(76, 37);
            button1.TabIndex = 14;
            button1.Text = "Menu";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnResgistroDePacientes
            // 
            btnResgistroDePacientes.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnResgistroDePacientes.Image = (Image)resources.GetObject("btnResgistroDePacientes.Image");
            btnResgistroDePacientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnResgistroDePacientes.Location = new Point(31, 160);
            btnResgistroDePacientes.Name = "btnResgistroDePacientes";
            btnResgistroDePacientes.Size = new Size(251, 40);
            btnResgistroDePacientes.TabIndex = 16;
            btnResgistroDePacientes.Text = "Registros De Pacientes";
            btnResgistroDePacientes.UseVisualStyleBackColor = true;
            btnResgistroDePacientes.Click += btnResgistroDePacientes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 30);
            label1.Name = "label1";
            label1.Size = new Size(156, 23);
            label1.TabIndex = 17;
            label1.Text = "Clinica Hospimesat";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(430, 495);
            Controls.Add(label1);
            Controls.Add(btnResgistroDePacientes);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(btnNuevoPaciente);
            Controls.Add(btnAgentasDeCitas);
            Controls.Add(btnSalir);
            Controls.Add(button3);
            Name = "Form1";
            Text = "Menu Principal";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Button btnSalir;
        private Button btnAgentasDeCitas;
        private Button btnNuevoPaciente;
        private PictureBox pictureBox1;
        private Button button1;
        private Button btnResgistroDePacientes;
        private Label label1;
    }
}
