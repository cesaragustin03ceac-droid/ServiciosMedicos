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
            BtnSalir = new Button();
            lblpersona = new Label();
            groupBox2 = new GroupBox();
            RegistroAlumnos = new DataGridView();
            txtBusqueda = new TextBox();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            groupBox3 = new GroupBox();
            CmbTipoPaciente = new ComboBox();
            lblTipo = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtApellidoM = new TextBox();
            txtApellidoP = new TextBox();
            txtNombre = new TextBox();
            txtMatricula = new TextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RegistroAlumnos).BeginInit();
            groupBox3.SuspendLayout();
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
            groupBox1.Size = new Size(893, 92);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.FromArgb(217, 217, 217);
            BtnSalir.BackgroundImage = Properties.Resources.Salir;
            BtnSalir.BackgroundImageLayout = ImageLayout.Zoom;
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
            lblpersona.Location = new Point(40, 34);
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
            groupBox2.Location = new Point(85, 107);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(748, 489);
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
            RegistroAlumnos.CellClick += RegistroAlumnos_CellClick;
            RegistroAlumnos.CellDoubleClick += RegistroAlumnos_CellDoubleClick;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBusqueda.Location = new Point(41, 55);
            txtBusqueda.Margin = new Padding(3, 4, 3, 4);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "Ingrese el matricula para buscar";
            txtBusqueda.Size = new Size(662, 27);
            txtBusqueda.TabIndex = 0;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Bottom;
            btnNuevo.Location = new Point(150, 762);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom;
            btnEditar.Location = new Point(411, 762);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom;
            btnEliminar.Location = new Point(673, 762);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(CmbTipoPaciente);
            groupBox3.Controls.Add(lblTipo);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(txtApellidoM);
            groupBox3.Controls.Add(txtApellidoP);
            groupBox3.Controls.Add(txtNombre);
            groupBox3.Controls.Add(txtMatricula);
            groupBox3.Location = new Point(85, 621);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(753, 135);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Agregar, Modicar o Eliminar";
            // 
            // CmbTipoPaciente
            // 
            CmbTipoPaciente.FormattingEnabled = true;
            CmbTipoPaciente.Location = new Point(602, 74);
            CmbTipoPaciente.Name = "CmbTipoPaciente";
            CmbTipoPaciente.Size = new Size(151, 28);
            CmbTipoPaciente.TabIndex = 10;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(602, 37);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(98, 20);
            lblTipo.TabIndex = 9;
            lblTipo.Text = "Tipo Paciente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(461, 37);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 8;
            label4.Text = "Apellido Materno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(312, 37);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 7;
            label3.Text = "Apellido Paterno";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 37);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 37);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 5;
            label1.Text = "Matricula";
            label1.Click += label1_Click;
            // 
            // txtApellidoM
            // 
            txtApellidoM.Location = new Point(461, 75);
            txtApellidoM.Name = "txtApellidoM";
            txtApellidoM.Size = new Size(125, 27);
            txtApellidoM.TabIndex = 3;
            // 
            // txtApellidoP
            // 
            txtApellidoP.Location = new Point(299, 75);
            txtApellidoP.Name = "txtApellidoP";
            txtApellidoP.Size = new Size(133, 27);
            txtApellidoP.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(144, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(134, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(6, 75);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(125, 27);
            txtMatricula.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(329, 27);
            label5.Name = "label5";
            label5.Size = new Size(323, 41);
            label5.TabIndex = 11;
            label5.Text = "Busqueda de Pacientes";
            // 
            // frmBusquedaAlumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 208, 214);
            ClientSize = new Size(896, 803);
            Controls.Add(groupBox3);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
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
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtBusqueda;
        private DataGridView RegistroAlumnos;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnEliminar;
        private GroupBox groupBox3;
        private TextBox txtApellidoM;
        private TextBox txtApellidoP;
        private TextBox txtNombre;
        private TextBox txtMatricula;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label lblpersona;
        private ComboBox CmbTipoPaciente;
        private Label lblTipo;
        private Button BtnSalir;
        private Label label5;
    }
}