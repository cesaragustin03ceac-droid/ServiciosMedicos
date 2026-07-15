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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeneracionReceta));
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            colMedicamentos = new DataGridViewTextBoxColumn();
            colPresentación = new DataGridViewTextBoxColumn();
            colFrecuencia = new DataGridViewTextBoxColumn();
            colDuracion = new DataGridViewTextBoxColumn();
            colEliminar = new DataGridViewButtonColumn();
            label2 = new Label();
            label3 = new Label();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            groupBox2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            tableLayoutPanel1.Controls.Add(textBox4, 3, 1);
            tableLayoutPanel1.Controls.Add(textBox3, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox2, 3, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(label7, 2, 1);
            tableLayoutPanel1.Controls.Add(label6, 2, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
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
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(441, 30);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(244, 27);
            textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(93, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(252, 27);
            textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(441, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(244, 27);
            textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(93, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 27);
            textBox1.TabIndex = 11;
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
            label6.Size = new Size(60, 20);
            label6.TabIndex = 6;
            label6.Text = "Carrera";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 4;
            label4.Text = "Matricula";
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
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(50, 248);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(694, 214);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Enter += groupBox3_Enter;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colMedicamentos, colPresentación, colFrecuencia, colDuracion, colEliminar });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(688, 208);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colMedicamentos
            // 
            colMedicamentos.HeaderText = "Medicamento";
            colMedicamentos.Name = "colMedicamentos";
            colMedicamentos.Resizable = DataGridViewTriState.True;
            colMedicamentos.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colPresentación
            // 
            colPresentación.HeaderText = "Presentación";
            colPresentación.Name = "colPresentación";
            colPresentación.Resizable = DataGridViewTriState.True;
            colPresentación.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colFrecuencia
            // 
            colFrecuencia.HeaderText = "Frecuencia";
            colFrecuencia.Name = "colFrecuencia";
            colFrecuencia.Resizable = DataGridViewTriState.True;
            colFrecuencia.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colDuracion
            // 
            colDuracion.HeaderText = "Duración";
            colDuracion.Name = "colDuracion";
            colDuracion.Resizable = DataGridViewTriState.True;
            colDuracion.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colEliminar
            // 
            colEliminar.HeaderText = "Eliminar";
            colEliminar.Name = "colEliminar";
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
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button5.BackColor = Color.FromArgb(204, 204, 204);
            button5.Location = new Point(484, 524);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(118, 32);
            button5.TabIndex = 12;
            button5.Text = "Guardar";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button6.BackColor = Color.FromArgb(204, 204, 204);
            button6.Location = new Point(623, 524);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(118, 32);
            button6.TabIndex = 13;
            button6.Text = "Vista Previa";
            button6.UseVisualStyleBackColor = false;
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
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(221, 220);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(25, 25);
            button2.TabIndex = 16;
            button2.UseVisualStyleBackColor = true;
            // 
            // frmGeneracionReceta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 208, 214);
            ClientSize = new Size(784, 641);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox3);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(richTextBox1);
            Name = "frmGeneracionReceta";
            Text = "GeneracionReceta";
            Load += frmGeneracionReceta_Load;
            groupBox2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label4;
        private DataGridView dataGridView1;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button1;
        private RichTextBox richTextBox1;
        private DataGridViewTextBoxColumn colMedicamentos;
        private DataGridViewTextBoxColumn colPresentación;
        private DataGridViewTextBoxColumn colFrecuencia;
        private DataGridViewTextBoxColumn colDuracion;
        private DataGridViewButtonColumn colEliminar;
        private Button button2;
    }
}