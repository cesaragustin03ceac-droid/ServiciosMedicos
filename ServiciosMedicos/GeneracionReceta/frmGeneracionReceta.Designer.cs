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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeneracionReceta));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            BtnAtras = new Button();
            groupBox2 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtFecha = new TextBox();
            txtMatricula = new TextBox();
            txtArea = new TextBox();
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
            btnImprimir = new Button();
            btonCancelar = new Button();
            richTextBox1 = new RichTextBox();
            btnAgregar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.FromArgb(217, 217, 217);
            groupBox1.Controls.Add(BtnAtras);
            groupBox1.Location = new Point(-6, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(903, 92);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // BtnAtras
            // 
            BtnAtras.BackColor = Color.FromArgb(217, 217, 217);
            BtnAtras.BackgroundImage = (Image)resources.GetObject("BtnAtras.BackgroundImage");
            BtnAtras.BackgroundImageLayout = ImageLayout.Zoom;
            BtnAtras.Location = new Point(31, 27);
            BtnAtras.Name = "BtnAtras";
            BtnAtras.Size = new Size(96, 41);
            BtnAtras.TabIndex = 0;
            BtnAtras.UseVisualStyleBackColor = false;
            BtnAtras.Click += BtnAtras_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(tableLayoutPanel1);
            groupBox2.Location = new Point(57, 155);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(793, 101);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 103F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.9704666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 103F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.0295372F));
            tableLayoutPanel1.Controls.Add(txtFecha, 3, 1);
            tableLayoutPanel1.Controls.Add(txtMatricula, 1, 0);
            tableLayoutPanel1.Controls.Add(txtArea, 3, 0);
            tableLayoutPanel1.Controls.Add(txtNombre, 1, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(label7, 2, 1);
            tableLayoutPanel1.Controls.Add(label6, 2, 0);
            tableLayoutPanel1.Controls.Add(lblMatricula, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            tableLayoutPanel1.Location = new Point(3, 24);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(787, 73);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // txtFecha
            // 
            txtFecha.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFecha.Location = new Point(505, 40);
            txtFecha.Margin = new Padding(3, 4, 3, 4);
            txtFecha.Name = "txtFecha";
            txtFecha.ReadOnly = true;
            txtFecha.Size = new Size(279, 32);
            txtFecha.TabIndex = 13;
            // 
            // txtMatricula
            // 
            txtMatricula.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMatricula.Location = new Point(106, 4);
            txtMatricula.Margin = new Padding(3, 4, 3, 4);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.ReadOnly = true;
            txtMatricula.Size = new Size(290, 32);
            txtMatricula.TabIndex = 10;
            // 
            // txtArea
            // 
            txtArea.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtArea.Location = new Point(505, 4);
            txtArea.Margin = new Padding(3, 4, 3, 4);
            txtArea.Name = "txtArea";
            txtArea.ReadOnly = true;
            txtArea.Size = new Size(279, 32);
            txtArea.TabIndex = 12;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(106, 40);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(290, 32);
            txtNombre.TabIndex = 11;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label5.Location = new Point(3, 42);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 5;
            label5.Text = "Nombre";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label7.Location = new Point(402, 42);
            label7.Name = "label7";
            label7.Size = new Size(62, 25);
            label7.TabIndex = 7;
            label7.Text = "Fecha";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label6.Location = new Point(402, 5);
            label6.Name = "label6";
            label6.Size = new Size(53, 25);
            label6.TabIndex = 6;
            label6.Text = "Area";
            // 
            // lblMatricula
            // 
            lblMatricula.Anchor = AnchorStyles.Left;
            lblMatricula.AutoSize = true;
            lblMatricula.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblMatricula.Location = new Point(3, 5);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(96, 25);
            lblMatricula.TabIndex = 4;
            lblMatricula.Text = "Matricula";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.Location = new Point(56, 125);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 3;
            label1.Text = "Datos Paciente";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(dgvMedicamentos);
            groupBox3.Location = new Point(56, 309);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(793, 285);
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
            dgvMedicamentos.Location = new Point(3, 4);
            dgvMedicamentos.Margin = new Padding(3, 4, 3, 4);
            dgvMedicamentos.Name = "dgvMedicamentos";
            dgvMedicamentos.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvMedicamentos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvMedicamentos.Size = new Size(786, 277);
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
            label2.Location = new Point(56, 268);
            label2.Name = "label2";
            label2.Size = new Size(209, 25);
            label2.TabIndex = 5;
            label2.Text = "Medicamentos y Dosis";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.Location = new Point(60, 618);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 6;
            label3.Text = "Indicaciones";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.BackColor = Color.FromArgb(204, 204, 204);
            btnGuardar.Location = new Point(553, 663);
            btnGuardar.Margin = new Padding(2, 3, 2, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(135, 43);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVistaPrevia
            // 
            btnVistaPrevia.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVistaPrevia.BackColor = Color.FromArgb(204, 204, 204);
            btnVistaPrevia.Location = new Point(710, 663);
            btnVistaPrevia.Margin = new Padding(2, 3, 2, 3);
            btnVistaPrevia.Name = "btnVistaPrevia";
            btnVistaPrevia.Size = new Size(135, 43);
            btnVistaPrevia.TabIndex = 13;
            btnVistaPrevia.Text = "Vista Previa";
            btnVistaPrevia.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            btnImprimir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnImprimir.BackColor = Color.FromArgb(204, 204, 204);
            btnImprimir.Location = new Point(553, 748);
            btnImprimir.Margin = new Padding(2, 3, 2, 3);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(135, 43);
            btnImprimir.TabIndex = 14;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btonCancelar
            // 
            btonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonCancelar.BackColor = Color.FromArgb(204, 204, 204);
            btonCancelar.Location = new Point(709, 747);
            btonCancelar.Margin = new Padding(2, 3, 2, 3);
            btonCancelar.Name = "btonCancelar";
            btonCancelar.Size = new Size(135, 43);
            btonCancelar.TabIndex = 15;
            btonCancelar.Text = "Cancelar";
            btonCancelar.UseVisualStyleBackColor = false;
            btonCancelar.Click += btnCancelar_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Location = new Point(56, 663);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(484, 127);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // btnAgregar
            // 
            btnAgregar.BackgroundImage = (Image)resources.GetObject("btnAgregar.BackgroundImage");
            btnAgregar.BackgroundImageLayout = ImageLayout.Zoom;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Location = new Point(271, 267);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.RightToLeft = RightToLeft.No;
            btnAgregar.Size = new Size(29, 33);
            btnAgregar.TabIndex = 16;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // frmGeneracionReceta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 208, 214);
            ClientSize = new Size(896, 803);
            Controls.Add(btnAgregar);
            Controls.Add(btonCancelar);
            Controls.Add(btnImprimir);
            Controls.Add(btnVistaPrevia);
            Controls.Add(btnGuardar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox3);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGeneracionReceta";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GeneracionReceta";
            Load += frmGeneracionReceta_Load;
            groupBox1.ResumeLayout(false);
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
        private TextBox txtArea;
        private TextBox txtNombre;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label lblMatricula;
        private DataGridView dgvMedicamentos;
        private Button btnGuardar;
        private Button btnVistaPrevia;
        private Button btnImprimir;
        private Button btonCancelar;
        private RichTextBox richTextBox1;
        private Button btnAgregar;
        private DataGridViewTextBoxColumn colMedicamentos;
        private DataGridViewTextBoxColumn colPresentación;
        private DataGridViewTextBoxColumn colFrecuencia;
        private DataGridViewTextBoxColumn colDuracion;
        private DataGridViewImageColumn colEliminar;
        private Button BtnAtras;
    }
}