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
            btnEditar = new Button();
            btnGuardar = new Button();
            btnAtras = new Button();
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
            groupBox1.Location = new Point(25, 149);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(234, 161);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Motivo";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(24, 97);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.PlaceholderText = "Otro Motivo";
            txtMotivo.Size = new Size(163, 27);
            txtMotivo.TabIndex = 1;
            // 
            // CboMotivo
            // 
            CboMotivo.FormattingEnabled = true;
            CboMotivo.Items.AddRange(new object[] { "Motivo General" });
            CboMotivo.Location = new Point(24, 47);
            CboMotivo.Name = "CboMotivo";
            CboMotivo.Size = new Size(163, 28);
            CboMotivo.TabIndex = 0;
            CboMotivo.Text = "Motivo General";
            CboMotivo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.White;
            groupBox5.Controls.Add(txtSintomas);
            groupBox5.Controls.Add(cboSintomas);
            groupBox5.Location = new Point(25, 401);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(234, 161);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "Sintomas";
            // 
            // txtSintomas
            // 
            txtSintomas.Location = new Point(24, 97);
            txtSintomas.Name = "txtSintomas";
            txtSintomas.PlaceholderText = "Otro Sintoma";
            txtSintomas.Size = new Size(163, 27);
            txtSintomas.TabIndex = 1;
            // 
            // cboSintomas
            // 
            cboSintomas.FormattingEnabled = true;
            cboSintomas.Location = new Point(24, 51);
            cboSintomas.Name = "cboSintomas";
            cboSintomas.Size = new Size(163, 28);
            cboSintomas.TabIndex = 0;
            cboSintomas.Text = "Sintomas Generales";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtMalestarA);
            groupBox2.Location = new Point(329, 149);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(234, 161);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Antecedentes";
            // 
            // txtMalestarA
            // 
            txtMalestarA.Location = new Point(39, 71);
            txtMalestarA.Name = "txtMalestarA";
            txtMalestarA.PlaceholderText = "Malestar Anterior";
            txtMalestarA.Size = new Size(163, 27);
            txtMalestarA.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(TxtDiagnostico);
            groupBox3.Controls.Add(cboDiagnostico);
            groupBox3.Location = new Point(329, 401);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(234, 161);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Diagnostico";
            // 
            // TxtDiagnostico
            // 
            TxtDiagnostico.Location = new Point(39, 97);
            TxtDiagnostico.Name = "TxtDiagnostico";
            TxtDiagnostico.PlaceholderText = "Otro Diagnostico";
            TxtDiagnostico.Size = new Size(163, 27);
            TxtDiagnostico.TabIndex = 1;
            // 
            // cboDiagnostico
            // 
            cboDiagnostico.FormattingEnabled = true;
            cboDiagnostico.Location = new Point(39, 51);
            cboDiagnostico.Name = "cboDiagnostico";
            cboDiagnostico.Size = new Size(163, 28);
            cboDiagnostico.TabIndex = 0;
            cboDiagnostico.Text = "Diagnostico General";
            cboDiagnostico.SelectedIndexChanged += cboDiagnostico_SelectedIndexChanged;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(txtPrecion);
            groupBox4.Location = new Point(650, 149);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(234, 161);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Presion";
            // 
            // txtPrecion
            // 
            txtPrecion.Location = new Point(33, 71);
            txtPrecion.Name = "txtPrecion";
            txtPrecion.PlaceholderText = "Ingrese la Precion";
            txtPrecion.Size = new Size(163, 27);
            txtPrecion.TabIndex = 2;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.White;
            groupBox6.Controls.Add(txtTemperatura);
            groupBox6.Location = new Point(650, 401);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(234, 161);
            groupBox6.TabIndex = 7;
            groupBox6.TabStop = false;
            groupBox6.Text = "Temperatura";
            // 
            // txtTemperatura
            // 
            txtTemperatura.Location = new Point(33, 81);
            txtTemperatura.Name = "txtTemperatura";
            txtTemperatura.PlaceholderText = "Ingrese la Temperatura";
            txtTemperatura.Size = new Size(163, 27);
            txtTemperatura.TabIndex = 3;
            // 
            // btnReceta
            // 
            btnReceta.Location = new Point(598, 667);
            btnReceta.Name = "btnReceta";
            btnReceta.Size = new Size(153, 64);
            btnReceta.TabIndex = 10;
            btnReceta.Text = "Ir A La Receta";
            btnReceta.UseVisualStyleBackColor = true;
            btnReceta.Click += button3_Click;
            // 
            // groupBox7
            // 
            groupBox7.BackColor = Color.Silver;
            groupBox7.Controls.Add(btnAtras);
            groupBox7.ForeColor = Color.Black;
            groupBox7.Location = new Point(1, 5);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(893, 92);
            groupBox7.TabIndex = 11;
            groupBox7.TabStop = false;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(351, 667);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(153, 64);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(106, 667);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(153, 64);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.FromArgb(217, 217, 217);
            btnAtras.BackgroundImage = Properties.Resources.Flecha_para_atras2;
            btnAtras.BackgroundImageLayout = ImageLayout.Zoom;
            btnAtras.Location = new Point(31, 27);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(96, 41);
            btnAtras.TabIndex = 0;
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // FrmConsultas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(182, 208, 214);
            ClientSize = new Size(896, 803);
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
    }
}