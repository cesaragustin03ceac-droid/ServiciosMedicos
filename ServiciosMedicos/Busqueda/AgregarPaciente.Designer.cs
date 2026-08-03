namespace ServiciosMedicos.Busqueda
{
    partial class AgregarPaciente
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
            BtnAtras = new Button();
            label1 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            txtApellidoM = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtEdad = new TextBox();
            txtArea = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            lblCURP = new Label();
            txtNSS = new TextBox();
            txtCURP = new TextBox();
            cboTipoSangre = new ComboBox();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            label12 = new Label();
            cboSexo = new ComboBox();
            txtApellidoP = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            cboRevicionOcular = new ComboBox();
            txtAlergia = new TextBox();
            txtEnfemedades = new TextBox();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            cboTipo = new ComboBox();
            label16 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(217, 217, 217);
            groupBox1.Controls.Add(BtnAtras);
            groupBox1.Location = new Point(-6, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(903, 92);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // BtnAtras
            // 
            BtnAtras.BackColor = Color.FromArgb(217, 217, 217);
            BtnAtras.BackgroundImage = Properties.Resources.Flecha_para_atras2;
            BtnAtras.BackgroundImageLayout = ImageLayout.Zoom;
            BtnAtras.FlatStyle = FlatStyle.Flat;
            BtnAtras.ForeColor = Color.FromArgb(217, 217, 217);
            BtnAtras.Location = new Point(31, 27);
            BtnAtras.Name = "BtnAtras";
            BtnAtras.Size = new Size(96, 41);
            BtnAtras.TabIndex = 0;
            BtnAtras.UseVisualStyleBackColor = false;
            BtnAtras.Click += BtnAtras_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 146);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(114, 147);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 207);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombres";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(114, 200);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtApellidoM
            // 
            txtApellidoM.Location = new Point(394, 200);
            txtApellidoM.Name = "txtApellidoM";
            txtApellidoM.Size = new Size(160, 27);
            txtApellidoM.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(579, 207);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 6;
            label3.Text = "Apellido Paterno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(260, 203);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 8;
            label4.Text = "Apellido Materno";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 332);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 9;
            label5.Text = "Edad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(273, 150);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 10;
            label6.Text = "Area";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(114, 332);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(125, 27);
            txtEdad.TabIndex = 11;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(345, 146);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(485, 27);
            txtArea.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 539);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 13;
            label7.Text = "Tipo de sangre";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(327, 539);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 14;
            label8.Text = "Peso";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(563, 536);
            label9.Name = "label9";
            label9.Size = new Size(49, 20);
            label9.TabIndex = 15;
            label9.Text = "Altura";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(45, 447);
            label10.Name = "label10";
            label10.Size = new Size(36, 20);
            label10.TabIndex = 16;
            label10.Text = "NSS";
            // 
            // lblCURP
            // 
            lblCURP.AutoSize = true;
            lblCURP.Location = new Point(454, 447);
            lblCURP.Name = "lblCURP";
            lblCURP.Size = new Size(45, 20);
            lblCURP.TabIndex = 17;
            lblCURP.Text = "CURP";
            // 
            // txtNSS
            // 
            txtNSS.Location = new Point(142, 440);
            txtNSS.Name = "txtNSS";
            txtNSS.Size = new Size(286, 27);
            txtNSS.TabIndex = 18;
            // 
            // txtCURP
            // 
            txtCURP.Location = new Point(544, 440);
            txtCURP.Name = "txtCURP";
            txtCURP.Size = new Size(286, 27);
            txtCURP.TabIndex = 19;
            // 
            // cboTipoSangre
            // 
            cboTipoSangre.FormattingEnabled = true;
            cboTipoSangre.Location = new Point(152, 536);
            cboTipoSangre.Name = "cboTipoSangre";
            cboTipoSangre.Size = new Size(151, 28);
            cboTipoSangre.TabIndex = 20;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(394, 536);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(125, 27);
            txtPeso.TabIndex = 21;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(649, 532);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(125, 27);
            txtAltura.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(292, 339);
            label12.Name = "label12";
            label12.Size = new Size(41, 20);
            label12.TabIndex = 23;
            label12.Text = "Sexo";
            // 
            // cboSexo
            // 
            cboSexo.FormattingEnabled = true;
            cboSexo.Location = new Point(368, 336);
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(151, 28);
            cboSexo.TabIndex = 24;
            // 
            // txtApellidoP
            // 
            txtApellidoP.Location = new Point(705, 200);
            txtApellidoP.Name = "txtApellidoP";
            txtApellidoP.Size = new Size(160, 27);
            txtApellidoP.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(45, 627);
            label13.Name = "label13";
            label13.Size = new Size(63, 20);
            label13.TabIndex = 26;
            label13.Text = "Alergias";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(324, 627);
            label14.Name = "label14";
            label14.Size = new Size(104, 20);
            label14.TabIndex = 27;
            label14.Text = "Enfermedades";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(595, 627);
            label15.Name = "label15";
            label15.Size = new Size(112, 20);
            label15.TabIndex = 28;
            label15.Text = "Revicion Ocular";
            // 
            // cboRevicionOcular
            // 
            cboRevicionOcular.FormattingEnabled = true;
            cboRevicionOcular.Location = new Point(714, 623);
            cboRevicionOcular.Name = "cboRevicionOcular";
            cboRevicionOcular.Size = new Size(151, 28);
            cboRevicionOcular.TabIndex = 29;
            // 
            // txtAlergia
            // 
            txtAlergia.Location = new Point(142, 624);
            txtAlergia.Name = "txtAlergia";
            txtAlergia.Size = new Size(161, 27);
            txtAlergia.TabIndex = 30;
            // 
            // txtEnfemedades
            // 
            txtEnfemedades.Location = new Point(454, 624);
            txtEnfemedades.Name = "txtEnfemedades";
            txtEnfemedades.Size = new Size(125, 27);
            txtEnfemedades.TabIndex = 31;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(145, 715);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(158, 61);
            btnGuardar.TabIndex = 32;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(371, 715);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(158, 61);
            btnEditar.TabIndex = 33;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(616, 715);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(158, 61);
            btnEliminar.TabIndex = 34;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(679, 339);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(151, 28);
            cboTipo.TabIndex = 35;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(544, 342);
            label16.Name = "label16";
            label16.Size = new Size(121, 20);
            label16.TabIndex = 36;
            label16.Text = "Tipo de paciente";
            // 
            // AgregarPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 208, 214);
            ClientSize = new Size(896, 803);
            Controls.Add(groupBox1);
            Controls.Add(label16);
            Controls.Add(cboTipo);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(txtEnfemedades);
            Controls.Add(txtAlergia);
            Controls.Add(cboRevicionOcular);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(txtApellidoP);
            Controls.Add(cboSexo);
            Controls.Add(label12);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(cboTipoSangre);
            Controls.Add(txtCURP);
            Controls.Add(txtNSS);
            Controls.Add(lblCURP);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtArea);
            Controls.Add(txtEdad);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtApellidoM);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "AgregarPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarPaciente";
            Load += AgregarPaciente_Load_1;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtID;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtApellidoM;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtEdad;
        private TextBox txtArea;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label lblCURP;
        private TextBox txtNSS;
        private TextBox txtCURP;
        private ComboBox cboTipoSangre;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Label label12;
        private ComboBox cboSexo;
        private TextBox txtApellidoP;
        private Label label13;
        private Label label14;
        private Label label15;
        private ComboBox cboRevicionOcular;
        private TextBox txtAlergia;
        private TextBox txtEnfemedades;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private ComboBox cboTipo;
        private Label label16;
        private Button BtnAtras;
    }
}