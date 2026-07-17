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
            groupBox2 = new GroupBox();
            RegistroAlumnos = new DataGridView();
            txtBusqueda = new TextBox();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            groupBox3 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtApellidoM = new TextBox();
            txtApellidoP = new TextBox();
            txtNombre = new TextBox();
            txtMatricula = new TextBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RegistroAlumnos).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.FromArgb(217, 217, 217);
            groupBox1.Location = new Point(-7, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(795, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(RegistroAlumnos);
            groupBox2.Controls.Add(txtBusqueda);
            groupBox2.Location = new Point(69, 157);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(678, 416);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // RegistroAlumnos
            // 
            RegistroAlumnos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RegistroAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RegistroAlumnos.Location = new Point(36, 108);
            RegistroAlumnos.Name = "RegistroAlumnos";
            RegistroAlumnos.RowHeadersWidth = 51;
            RegistroAlumnos.Size = new Size(603, 262);
            RegistroAlumnos.TabIndex = 1;
            RegistroAlumnos.CellDoubleClick += RegistroAlumnos_CellDoubleClick;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBusqueda.Location = new Point(36, 41);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(603, 23);
            txtBusqueda.TabIndex = 0;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Bottom;
            btnNuevo.Location = new Point(137, 726);
            btnNuevo.Margin = new Padding(3, 2, 3, 2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(82, 22);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom;
            btnEditar.Location = new Point(369, 726);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(82, 22);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom;
            btnEliminar.Location = new Point(556, 726);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 22);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(txtApellidoM);
            groupBox3.Controls.Add(txtApellidoP);
            groupBox3.Controls.Add(txtNombre);
            groupBox3.Controls.Add(txtMatricula);
            groupBox3.Location = new Point(69, 606);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(678, 101);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos del paciente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(528, 28);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 8;
            label4.Text = "Apellido Materno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(348, 28);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 7;
            label3.Text = "Apellido Paterno";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 28);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 28);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 5;
            label1.Text = "Matricula";
            label1.Click += label1_Click;
            // 
            // txtApellidoM
            // 
            txtApellidoM.Location = new Point(529, 56);
            txtApellidoM.Margin = new Padding(3, 2, 3, 2);
            txtApellidoM.Name = "txtApellidoM";
            txtApellidoM.Size = new Size(110, 23);
            txtApellidoM.TabIndex = 3;
            // 
            // txtApellidoP
            // 
            txtApellidoP.Location = new Point(348, 56);
            txtApellidoP.Margin = new Padding(3, 2, 3, 2);
            txtApellidoP.Name = "txtApellidoP";
            txtApellidoP.Size = new Size(117, 23);
            txtApellidoP.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(175, 56);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(118, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(5, 56);
            txtMatricula.Margin = new Padding(3, 2, 3, 2);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(110, 23);
            txtMatricula.TabIndex = 0;
            // 
            // frmBusquedaAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 208, 214);
            ClientSize = new Size(784, 768);
            Controls.Add(groupBox3);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmBusquedaAlumnos";
            Text = "frmBusquedaAlumnos";
            Load += frmBusquedaAlumnos_Load;
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
    }
}