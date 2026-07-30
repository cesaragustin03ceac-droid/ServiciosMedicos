namespace ServiciosMedicos.Busqueda
{
    partial class frmBusquedaAlumnos
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
            label5 = new Label();
            BtnSalir = new Button();
            lblpersona = new Label();
            groupBox2 = new GroupBox();
            RegistroAlumnos = new DataGridView();
            txtBusqueda = new TextBox();
            btnExpedientePaciente = new Button();
            btnAgregarPaciente = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RegistroAlumnos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.FromArgb(217, 217, 217);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(BtnSalir);
            groupBox1.Controls.Add(lblpersona);
            groupBox1.Location = new Point(-8, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(912, 92);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(299, 27);
            label5.Name = "label5";
            label5.Size = new Size(338, 41);
            label5.TabIndex = 11;
            label5.Text = "Busqueda de Pacientes";
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.FromArgb(217, 217, 217);
            BtnSalir.BackgroundImage = Properties.Resources.Salir;
            BtnSalir.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSalir.FlatAppearance.BorderSize = 0;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Location = new Point(31, 27);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(96, 41);
            BtnSalir.TabIndex = 1;
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // lblpersona
            // 
            lblpersona.AutoSize = true;
            lblpersona.Location = new Point(40, 35);
            lblpersona.Name = "lblpersona";
            lblpersona.Size = new Size(12, 20);
            lblpersona.TabIndex = 0;
            lblpersona.Text = ".";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(RegistroAlumnos);
            groupBox2.Controls.Add(txtBusqueda);
            groupBox2.Location = new Point(85, 129);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(747, 489);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // RegistroAlumnos
            // 
            RegistroAlumnos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RegistroAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RegistroAlumnos.Location = new Point(41, 100);
            RegistroAlumnos.Margin = new Padding(3, 4, 3, 4);
            RegistroAlumnos.Name = "RegistroAlumnos";
            RegistroAlumnos.ReadOnly = true;
            RegistroAlumnos.RowHeadersWidth = 51;
            RegistroAlumnos.Size = new Size(662, 349);
            RegistroAlumnos.TabIndex = 1;
            RegistroAlumnos.CellContentClick += RegistroAlumnos_CellContentClick;
            RegistroAlumnos.CellDoubleClick += RegistroAlumnos_CellDoubleClick;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBusqueda.Location = new Point(41, 55);
            txtBusqueda.Margin = new Padding(3, 4, 3, 4);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "Ingrese la matricula o No. de trabajador ";
            txtBusqueda.Size = new Size(662, 27);
            txtBusqueda.TabIndex = 0;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // btnExpedientePaciente
            // 
            btnExpedientePaciente.Location = new Point(177, 677);
            btnExpedientePaciente.Name = "btnExpedientePaciente";
            btnExpedientePaciente.Size = new Size(155, 61);
            btnExpedientePaciente.TabIndex = 2;
            btnExpedientePaciente.Text = "Ir al expediente del Paciente";
            btnExpedientePaciente.UseVisualStyleBackColor = true;
            btnExpedientePaciente.Click += btnExpedientePaciente_Click;
            // 
            // btnAgregarPaciente
            // 
            btnAgregarPaciente.Location = new Point(403, 677);
            btnAgregarPaciente.Name = "btnAgregarPaciente";
            btnAgregarPaciente.Size = new Size(155, 61);
            btnAgregarPaciente.TabIndex = 3;
            btnAgregarPaciente.Text = "Agregar un nuvo Paciente";
            btnAgregarPaciente.UseVisualStyleBackColor = true;
            btnAgregarPaciente.Click += btnAgregarPaciente_Click;
            // 
            // frmBusquedaAlumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 208, 214);
            ClientSize = new Size(896, 803);
            Controls.Add(btnAgregarPaciente);
            Controls.Add(btnExpedientePaciente);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBusquedaAlumnos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBusquedaAlumnos";
            Load += frmBusquedaAlumnos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RegistroAlumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtBusqueda;
        private DataGridView RegistroAlumnos;
        private Label lblpersona;
        private Button BtnSalir;
        private Label label5;
        private Button btnExpedientePaciente;
        private Button btnAgregarPaciente;
    }
}