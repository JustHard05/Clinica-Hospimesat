namespace Clinica_Hospimesat
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label7 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            pictureBox15 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            button4 = new Button();
            txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            txtIdentidad = new MaterialSkin.Controls.MaterialTextBox();
            txtTelefono = new MaterialSkin.Controls.MaterialTextBox();
            txtDireccion = new MaterialSkin.Controls.MaterialTextBox();
            label1 = new Label();
            cmbSexo = new MaterialSkin.Controls.MaterialComboBox();
            dtpFechaNacimiento = new DateTimePicker();
            btnGuardar = new MaterialSkin.Controls.MaterialButton();
            btnCancelar = new MaterialSkin.Controls.MaterialButton();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(14, 90);
            label7.Name = "label7";
            label7.Size = new Size(200, 18);
            label7.TabIndex = 160;
            label7.Text = "Registrar Nuevo Paciente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 125);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 158;
            label6.Text = "Nombre Completo";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(457, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 152;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 125);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 209;
            label2.Text = "Fecha de Nacimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 212);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 210;
            label3.Text = "Numero de identidad";
            // 
            // pictureBox15
            // 
            pictureBox15.Image = (Image)resources.GetObject("pictureBox15.Image");
            pictureBox15.Location = new Point(260, 115);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(24, 25);
            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox15.TabIndex = 218;
            pictureBox15.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(14, 115);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 220;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(14, 202);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 25);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 221;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(14, 289);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(24, 25);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 222;
            pictureBox6.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(14, 376);
            button4.Name = "button4";
            button4.Size = new Size(23, 23);
            button4.TabIndex = 232;
            button4.UseVisualStyleBackColor = false;
            // 
            // txtNombre
            // 
            txtNombre.AnimateReadOnly = false;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Depth = 0;
            txtNombre.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombre.Hint = "Nombre Completo";
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(14, 146);
            txtNombre.MaxLength = 50;
            txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            txtNombre.Multiline = false;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(183, 50);
            txtNombre.TabIndex = 238;
            txtNombre.Text = "";
            txtNombre.TrailingIcon = null;
            // 
            // txtIdentidad
            // 
            txtIdentidad.AnimateReadOnly = false;
            txtIdentidad.BorderStyle = BorderStyle.None;
            txtIdentidad.Depth = 0;
            txtIdentidad.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtIdentidad.Hint = "Número de Identidad";
            txtIdentidad.LeadingIcon = null;
            txtIdentidad.Location = new Point(14, 233);
            txtIdentidad.MaxLength = 50;
            txtIdentidad.MouseState = MaterialSkin.MouseState.OUT;
            txtIdentidad.Multiline = false;
            txtIdentidad.Name = "txtIdentidad";
            txtIdentidad.Size = new Size(183, 50);
            txtIdentidad.TabIndex = 239;
            txtIdentidad.Text = "";
            txtIdentidad.TrailingIcon = null;
            // 
            // txtTelefono
            // 
            txtTelefono.AnimateReadOnly = false;
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Depth = 0;
            txtTelefono.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelefono.Hint = "Teléfono";
            txtTelefono.LeadingIcon = null;
            txtTelefono.Location = new Point(14, 320);
            txtTelefono.MaxLength = 50;
            txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            txtTelefono.Multiline = false;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(183, 50);
            txtTelefono.TabIndex = 240;
            txtTelefono.Text = "";
            txtTelefono.TrailingIcon = null;
            // 
            // txtDireccion
            // 
            txtDireccion.AnimateReadOnly = false;
            txtDireccion.BorderStyle = BorderStyle.None;
            txtDireccion.Depth = 0;
            txtDireccion.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDireccion.Hint = "Dirección de Residencia";
            txtDireccion.LeadingIcon = null;
            txtDireccion.Location = new Point(14, 397);
            txtDireccion.MaxLength = 50;
            txtDireccion.MouseState = MaterialSkin.MouseState.OUT;
            txtDireccion.Multiline = false;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(196, 50);
            txtDireccion.TabIndex = 241;
            txtDireccion.Text = "";
            txtDireccion.TrailingIcon = null;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 299);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 242;
            label1.Text = "Teléfono";
            // 
            // cmbSexo
            // 
            cmbSexo.AutoResize = false;
            cmbSexo.BackColor = Color.FromArgb(255, 255, 255);
            cmbSexo.Depth = 0;
            cmbSexo.DrawMode = DrawMode.OwnerDrawVariable;
            cmbSexo.DropDownHeight = 174;
            cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSexo.DropDownWidth = 121;
            cmbSexo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbSexo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Hint = "Sexo";
            cmbSexo.IntegralHeight = false;
            cmbSexo.ItemHeight = 43;
            cmbSexo.Items.AddRange(new object[] { "M", "F" });
            cmbSexo.Location = new Point(251, 202);
            cmbSexo.MaxDropDownItems = 4;
            cmbSexo.MouseState = MaterialSkin.MouseState.OUT;
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(98, 49);
            cmbSexo.StartIndex = 0;
            cmbSexo.TabIndex = 243;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(251, 146);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(200, 23);
            dtpFechaNacimiento.TabIndex = 244;
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGuardar.Depth = 0;
            btnGuardar.HighEmphasis = true;
            btnGuardar.Icon = (Image)resources.GetObject("btnGuardar.Icon");
            btnGuardar.Location = new Point(241, 355);
            btnGuardar.Margin = new Padding(4, 6, 4, 6);
            btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.NoAccentTextColor = Color.Empty;
            btnGuardar.Size = new Size(189, 36);
            btnGuardar.TabIndex = 245;
            btnGuardar.Text = "Guardar Paciente";
            btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGuardar.UseAccentColor = false;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = (Image)resources.GetObject("btnCancelar.Icon");
            btnCancelar.Location = new Point(457, 355);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(124, 36);
            btnCancelar.TabIndex = 246;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 376);
            label4.Name = "label4";
            label4.Size = new Size(132, 15);
            label4.TabIndex = 247;
            label4.Text = "Dirección de Residencia";
            label4.Click += btnGuardar_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 461);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(cmbSexo);
            Controls.Add(label1);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtIdentidad);
            Controls.Add(txtNombre);
            Controls.Add(button4);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox15);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Name = "Form4";
            Text = "Registro De Nuevo Paciente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox15;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button button4;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialTextBox txtIdentidad;
        private MaterialSkin.Controls.MaterialTextBox txtTelefono;
        private MaterialSkin.Controls.MaterialTextBox txtDireccion;
        private Label label1;
        private MaterialSkin.Controls.MaterialComboBox cmbSexo;
        private DateTimePicker dtpFechaNacimiento;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private Label label4;
    }
}