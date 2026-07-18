namespace ServiciosMedicos.GeneracionReceta
{
    partial class frmGeneracionReceta
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeneracionReceta));
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtFecha = new TextBox();
            txtMatricula = new TextBox();
            txtCarrera = new TextBox();
            txtNombre = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            lblMatricula = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            dgvMedicamentos = new DataGridView();
            colMedicamentos = new DataGridViewTextBoxColumn();
            colPresentación = new DataGridViewTextBoxColumn();
            colFrecuencia = new DataGridViewTextBoxColumn();
            colDuracion = new DataGridViewTextBoxColumn();
            colEliminar = new DataGridViewImageColumn();
            label2 = new Label();
            label3 = new Label();
            btnGuardar = new Button();
            btnVistaPrevia = new Button();
            button7 = new Button();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            btnAgregar = new Button();
            groupBox2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.FromArgb(217, 217, 217);
            groupBox1.Location = new Point(-5, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(795, 81);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(tableLayoutPanel1);
            groupBox2.Location = new Point(50, 134);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(694, 76);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.9704666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.0295372F));
            tableLayoutPanel1.Controls.Add(txtFecha, 3, 1);
            tableLayoutPanel1.Controls.Add(txtMatricula, 1, 0);
            tableLayoutPanel1.Controls.Add(txtCarrera, 3, 0);
            tableLayoutPanel1.Controls.Add(txtNombre, 1, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(label7, 2, 1);
            tableLayoutPanel1.Controls.Add(label6, 2, 0);
            tableLayoutPanel1.Controls.Add(lblMatricula, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            tableLayoutPanel1.Location = new Point(3, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(688, 54);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // txtFecha
            // 
            txtFecha.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFecha.Location = new Point(441, 30);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(244, 27);
            txtFecha.TabIndex = 13;
            // 
            // txtMatricula
            // 
            txtMatricula.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMatricula.Location = new Point(93, 3);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(252, 27);
            txtMatricula.TabIndex = 10;
            // 
            // txtCarrera
            // 
            txtCarrera.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCarrera.Location = new Point(441, 3);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(244, 27);
            txtCarrera.TabIndex = 12;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(93, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(252, 27);
            txtNombre.TabIndex = 11;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label5.Location = new Point(3, 30);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 5;
            label5.Text = "Nombre";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label7.Location = new Point(351, 30);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 7;
            label7.Text = "Fecha";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label6.Location = new Point(351, 3);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 6;
            label6.Text = "Area";
            // 
            // lblMatricula
            // 
            lblMatricula.Anchor = AnchorStyles.Left;
            lblMatricula.AutoSize = true;
            lblMatricula.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblMatricula.Location = new Point(3, 3);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(75, 20);
            lblMatricula.TabIndex = 4;
            lblMatricula.Text = "Matricula";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.Location = new Point(49, 114);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 3;
            label1.Text = "Datos Paciente";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(dgvMedicamentos);
            groupBox3.Location = new Point(50, 248);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(694, 214);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            // 
            // dgvMedicamentos
            // 
            dgvMedicamentos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvMedicamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMedicamentos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvMedicamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicamentos.Columns.AddRange(new DataGridViewColumn[] { colMedicamentos, colPresentación, colFrecuencia, colDuracion, colEliminar });
            dgvMedicamentos.EnableHeadersVisualStyles = false;
            dgvMedicamentos.Location = new Point(3, 3);
            dgvMedicamentos.Name = "dgvMedicamentos";
            dgvMedicamentos.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvMedicamentos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvMedicamentos.Size = new Size(688, 208);
            dgvMedicamentos.TabIndex = 0;
            dgvMedicamentos.CellContentClick += dgvMedicamentos_CellClick;
            // 
            // colMedicamentos
            // 
            colMedicamentos.HeaderText = "Medicamento";
            colMedicamentos.MinimumWidth = 6;
            colMedicamentos.Name = "colMedicamentos";
            colMedicamentos.Resizable = DataGridViewTriState.True;
            colMedicamentos.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colPresentación
            // 
            colPresentación.HeaderText = "Presentación";
            colPresentación.MinimumWidth = 6;
            colPresentación.Name = "colPresentación";
            colPresentación.Resizable = DataGridViewTriState.True;
            colPresentación.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colFrecuencia
            // 
            colFrecuencia.HeaderText = "Frecuencia";
            colFrecuencia.MinimumWidth = 6;
            colFrecuencia.Name = "colFrecuencia";
            colFrecuencia.Resizable = DataGridViewTriState.True;
            colFrecuencia.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colDuracion
            // 
            colDuracion.HeaderText = "Duración";
            colDuracion.MinimumWidth = 6;
            colDuracion.Name = "colDuracion";
            colDuracion.Resizable = DataGridViewTriState.True;
            colDuracion.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colEliminar
            // 
            colEliminar.HeaderText = "Eliminar";
            colEliminar.Image = Properties.Resources.eliminar;
            colEliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colEliminar.MinimumWidth = 6;
            colEliminar.Name = "colEliminar";
            colEliminar.Resizable = DataGridViewTriState.True;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(49, 222);
            label2.Name = "label2";
            label2.Size = new Size(166, 20);
            label2.TabIndex = 5;
            label2.Text = "Medicamentos y Dosis";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.Location = new Point(50, 483);
            label3.Name = "label3";
            label3.Size = new Size(149, 20);
            label3.TabIndex = 6;
            label3.Text = "Indicaciones y Dosis";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.BackColor = Color.FromArgb(204, 204, 204);
            btnGuardar.Location = new Point(484, 524);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(118, 32);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnVistaPrevia
            // 
            btnVistaPrevia.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVistaPrevia.BackColor = Color.FromArgb(204, 204, 204);
            btnVistaPrevia.Location = new Point(623, 524);
            btnVistaPrevia.Margin = new Padding(2);
            btnVistaPrevia.Name = "btnVistaPrevia";
            btnVistaPrevia.Size = new Size(118, 32);
            btnVistaPrevia.TabIndex = 13;
            btnVistaPrevia.Text = "Vista Previa";
            btnVistaPrevia.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button7.BackColor = Color.FromArgb(204, 204, 204);
            button7.Location = new Point(484, 560);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(118, 32);
            button7.TabIndex = 14;
            button7.Text = "Imprimir";
            button7.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(204, 204, 204);
            button1.Location = new Point(626, 560);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(118, 32);
            button1.TabIndex = 15;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Location = new Point(49, 506);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(424, 96);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // btnAgregar
            // 
            btnAgregar.BackgroundImage = (Image)resources.GetObject("btnAgregar.BackgroundImage");
            btnAgregar.BackgroundImageLayout = ImageLayout.Zoom;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Location = new Point(221, 220);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.RightToLeft = RightToLeft.No;
            btnAgregar.Size = new Size(25, 25);
            btnAgregar.TabIndex = 16;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // frmGeneracionReceta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 208, 214);
            ClientSize = new Size(784, 562);
            Controls.Add(btnAgregar);
            Controls.Add(button1);
            Controls.Add(button7);
            Controls.Add(btnVistaPrevia);
            Controls.Add(btnGuardar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox3);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(richTextBox1);
            Name = "frmGeneracionReceta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GeneracionReceta";
            WindowState = FormWindowState.Maximized;
            groupBox2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private GroupBox groupBox3;
        private Label label2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtFecha;
        private TextBox txtMatricula;
        private TextBox txtCarrera;
        private TextBox txtNombre;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label lblMatricula;
        private DataGridView dgvMedicamentos;
        private Button btnGuardar;
        private Button btnVistaPrevia;
        private Button button7;
        private Button button1;
        private RichTextBox richTextBox1;
        private Button btnAgregar;
        private DataGridViewTextBoxColumn colMedicamentos;
        private DataGridViewTextBoxColumn colPresentación;
        private DataGridViewTextBoxColumn colFrecuencia;
        private DataGridViewTextBoxColumn colDuracion;
        private DataGridViewImageColumn colEliminar;
    }
}