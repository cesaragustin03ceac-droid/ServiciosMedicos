namespace ServiciosMedicos.Consultas
{
    partial class FrmConsultas
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
            groupBox1 = new GroupBox();
            txtMotivo = new TextBox();
            CboMotivo = new ComboBox();
            groupBox5 = new GroupBox();
            txtSintomas = new TextBox();
            cboSintomas = new ComboBox();
            groupBox2 = new GroupBox();
            txtMalestarA = new TextBox();
            groupBox3 = new GroupBox();
            TxtDiagnostico = new TextBox();
            cboDiagnostico = new ComboBox();
            groupBox4 = new GroupBox();
            txtPrecion = new TextBox();
            groupBox6 = new GroupBox();
            txtTemperatura = new TextBox();
            btnReceta = new Button();
            groupBox7 = new GroupBox();
            label1 = new Label();
            btnAtras = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtMotivo);
            groupBox1.Controls.Add(CboMotivo);
            groupBox1.Location = new Point(22, 112);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(205, 121);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Motivo";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(21, 73);
            txtMotivo.Margin = new Padding(3, 2, 3, 2);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.PlaceholderText = "Otro Motivo";
            txtMotivo.ReadOnly = true;
            txtMotivo.Size = new Size(143, 21);
            txtMotivo.TabIndex = 1;
            txtMotivo.TextChanged += txtMotivo_TextChanged;
            // 
            // CboMotivo
            // 
            CboMotivo.FormattingEnabled = true;
            CboMotivo.Items.AddRange(new object[] { "Motivo General" });
            CboMotivo.Location = new Point(21, 35);
            CboMotivo.Margin = new Padding(3, 2, 3, 2);
            CboMotivo.Name = "CboMotivo";
            CboMotivo.Size = new Size(143, 23);
            CboMotivo.TabIndex = 0;
            CboMotivo.Text = "Motivo General";
            CboMotivo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.White;
            groupBox5.Controls.Add(txtSintomas);
            groupBox5.Controls.Add(cboSintomas);
            groupBox5.Location = new Point(22, 301);
            groupBox5.Margin = new Padding(3, 2, 3, 2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 2, 3, 2);
            groupBox5.Size = new Size(205, 121);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "Sintomas";
            // 
            // txtSintomas
            // 
            txtSintomas.Location = new Point(21, 73);
            txtSintomas.Margin = new Padding(3, 2, 3, 2);
            txtSintomas.Name = "txtSintomas";
            txtSintomas.PlaceholderText = "Otro Sintoma";
            txtSintomas.ReadOnly = true;
            txtSintomas.Size = new Size(143, 23);
            txtSintomas.TabIndex = 1;
            // 
            // cboSintomas
            // 
            cboSintomas.FormattingEnabled = true;
            cboSintomas.Location = new Point(21, 38);
            cboSintomas.Margin = new Padding(3, 2, 3, 2);
            cboSintomas.Name = "cboSintomas";
            cboSintomas.Size = new Size(143, 23);
            cboSintomas.TabIndex = 0;
            cboSintomas.Text = "Sintomas Generales";
            cboSintomas.SelectedIndexChanged += cboSintomas_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtMalestarA);
            groupBox2.Location = new Point(288, 112);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(205, 121);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Antecedentes";
            // 
            // txtMalestarA
            // 
            txtMalestarA.Location = new Point(34, 53);
            txtMalestarA.Margin = new Padding(3, 2, 3, 2);
            txtMalestarA.Name = "txtMalestarA";
            txtMalestarA.PlaceholderText = "Malestar Anterior";
            txtMalestarA.Size = new Size(143, 23);
            txtMalestarA.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(TxtDiagnostico);
            groupBox3.Controls.Add(cboDiagnostico);
            groupBox3.Location = new Point(288, 301);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(205, 121);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Diagnostico";
            // 
            // TxtDiagnostico
            // 
            TxtDiagnostico.Location = new Point(34, 73);
            TxtDiagnostico.Margin = new Padding(3, 2, 3, 2);
            TxtDiagnostico.Name = "TxtDiagnostico";
            TxtDiagnostico.PlaceholderText = "Otro Diagnostico";
            TxtDiagnostico.ReadOnly = true;
            TxtDiagnostico.Size = new Size(143, 23);
            TxtDiagnostico.TabIndex = 1;
            // 
            // cboDiagnostico
            // 
            cboDiagnostico.FormattingEnabled = true;
            cboDiagnostico.Location = new Point(34, 38);
            cboDiagnostico.Margin = new Padding(3, 2, 3, 2);
            cboDiagnostico.Name = "cboDiagnostico";
            cboDiagnostico.Size = new Size(143, 23);
            cboDiagnostico.TabIndex = 0;
            cboDiagnostico.Text = "Diagnostico General";
            cboDiagnostico.SelectedIndexChanged += cboDiagnostico_SelectedIndexChanged;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(txtPrecion);
            groupBox4.Location = new Point(569, 112);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(205, 121);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Presion";
            // 
            // txtPrecion
            // 
            txtPrecion.Location = new Point(29, 53);
            txtPrecion.Margin = new Padding(3, 2, 3, 2);
            txtPrecion.Name = "txtPrecion";
            txtPrecion.PlaceholderText = "Ingrese la Precion";
            txtPrecion.Size = new Size(143, 23);
            txtPrecion.TabIndex = 2;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.White;
            groupBox6.Controls.Add(txtTemperatura);
            groupBox6.Location = new Point(569, 301);
            groupBox6.Margin = new Padding(3, 2, 3, 2);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 2, 3, 2);
            groupBox6.Size = new Size(205, 121);
            groupBox6.TabIndex = 7;
            groupBox6.TabStop = false;
            groupBox6.Text = "Temperatura";
            // 
            // txtTemperatura
            // 
            txtTemperatura.Location = new Point(29, 61);
            txtTemperatura.Margin = new Padding(3, 2, 3, 2);
            txtTemperatura.Name = "txtTemperatura";
            txtTemperatura.PlaceholderText = "Ingrese la Temperatura";
            txtTemperatura.Size = new Size(143, 23);
            txtTemperatura.TabIndex = 3;
            // 
            // btnReceta
            // 
            btnReceta.Location = new Point(523, 500);
            btnReceta.Margin = new Padding(3, 2, 3, 2);
            btnReceta.Name = "btnReceta";
            btnReceta.Size = new Size(134, 48);
            btnReceta.TabIndex = 10;
            btnReceta.Text = "Ir A La Receta";
            btnReceta.UseVisualStyleBackColor = true;
            btnReceta.Click += button3_Click;
            // 
            // groupBox7
            // 
            groupBox7.BackColor = Color.FromArgb(217, 217, 217);
            groupBox7.Controls.Add(label1);
            groupBox7.Controls.Add(btnAtras);
            groupBox7.ForeColor = Color.Black;
            groupBox7.Location = new Point(1, 4);
            groupBox7.Margin = new Padding(3, 2, 3, 2);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(3, 2, 3, 2);
            groupBox7.Size = new Size(781, 69);
            groupBox7.TabIndex = 11;
            groupBox7.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 20);
            label1.Name = "label1";
            label1.Size = new Size(228, 32);
            label1.TabIndex = 1;
            label1.Text = "Formato de Signos";
            // 
            // btnAtras
            // 
            btnAtras.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAtras.BackColor = Color.FromArgb(217, 217, 217);
            btnAtras.BackgroundImage = Properties.Resources.Flecha_para_atras2;
            btnAtras.BackgroundImageLayout = ImageLayout.Zoom;
            btnAtras.FlatAppearance.BorderSize = 0;
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Location = new Point(27, 20);
            btnAtras.Margin = new Padding(3, 2, 3, 2);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(84, 31);
            btnAtras.TabIndex = 0;
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(307, 500);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(134, 48);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(93, 500);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(134, 48);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(182, 208, 214);
            ClientSize = new Size(784, 562);
            Controls.Add(btnGuardar);
            Controls.Add(btnEditar);
            Controls.Add(groupBox7);
            Controls.Add(btnReceta);
            Controls.Add(groupBox6);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConsultas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConsultas";
            Load += FrmConsultas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox CboMotivo;
        private TextBox txtMotivo;
        private GroupBox groupBox5;
        private TextBox txtSintomas;
        private ComboBox cboSintomas;
        private GroupBox groupBox2;
        private TextBox txtMalestarA;
        private GroupBox groupBox3;
        private TextBox TxtDiagnostico;
        private ComboBox cboDiagnostico;
        private GroupBox groupBox4;
        private ComboBox comboBox5;
        private GroupBox groupBox6;
        private ComboBox comboBox6;
        private Button button1;
        private Button button2;
        private Button btnReceta;
        private GroupBox groupBox7;
        private TextBox txtPrecion;
        private TextBox txtTemperatura;
        private Button btnEditar;
        private Button btnGuardar;
        private Button btnAtras;
        private Label label1;
    }
}