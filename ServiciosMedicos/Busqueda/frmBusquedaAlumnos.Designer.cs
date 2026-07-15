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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RegistroAlumnos).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.FromArgb(217, 217, 217);
            groupBox1.Location = new Point(-7, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(795, 199);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(69, 151);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(678, 515);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // RegistroAlumnos
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(603, 262);
            dataGridView1.TabIndex = 1;
            // 
            // txtBusqueda
            // 
            textBox1.Location = new Point(36, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(603, 23);
            textBox1.TabIndex = 0;
            // 
            // btnNuevo
            // 
            button1.Location = new Point(137, 703);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 2;
            button1.Text = "Nuevo";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            button2.Location = new Point(369, 703);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 3;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            button3.Location = new Point(556, 703);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 4;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Location = new Point(69, 583);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(678, 101);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos del alumno";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(574, 28);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 9;
            label5.Text = "Grupo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(431, 28);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 8;
            label4.Text = "Cuatrimestre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(279, 28);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 7;
            label3.Text = "Apellido Materno";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 28);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 6;
            label2.Text = "Apellido Paterno";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 28);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 5;
            label1.Text = "Matricula";
            label1.Click += label1_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(564, 56);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(110, 23);
            textBox6.TabIndex = 4;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(423, 56);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(110, 23);
            textBox5.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(279, 56);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(117, 23);
            textBox4.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(138, 56);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(118, 23);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(5, 56);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 0;
            // 
            // frmBusquedaAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 208, 214);
            ClientSize = new Size(784, 661);
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