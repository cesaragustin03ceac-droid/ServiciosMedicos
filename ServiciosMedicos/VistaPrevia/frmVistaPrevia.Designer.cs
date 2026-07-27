namespace ServiciosMedicos.VistaPrevia
{
    partial class frmVistaPrevia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVistaPrevia));
            groupBox1 = new GroupBox();
            label5 = new Label();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblFecha = new Label();
            lblArea = new Label();
            label12 = new Label();
            label9 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblSexo = new Label();
            lblMatricula = new Label();
            lblEdad = new Label();
            lblNobre = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            label6 = new Label();
            groupBox2 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblDoctora = new Label();
            label4 = new Label();
            lblCedula = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label13 = new Label();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(62, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(586, 650);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label5.Location = new Point(40, 474);
            label5.Name = "label5";
            label5.Size = new Size(279, 20);
            label5.TabIndex = 7;
            label5.Text = "INDICACIONES Y RECOMENDACIONES";
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.Location = new Point(43, 340);
            label3.Name = "label3";
            label3.Size = new Size(226, 20);
            label3.TabIndex = 6;
            label3.Text = "MEDICAMENTOS PREESCRITOS";
            label3.Click += label3_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(39, 496);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(483, 67);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(217, 217, 217);
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(39, 363);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(492, 107);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(1, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(492, 107);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Medicamentos";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Presentación";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Dosis y Frecuencia";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Duración";
            Column4.Name = "Column4";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(217, 217, 217);
            groupBox3.Controls.Add(tableLayoutPanel3);
            groupBox3.Controls.Add(tableLayoutPanel2);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(40, 233);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(492, 96);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Enter += groupBox3_Enter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.553971F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.3441963F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.979633F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.1222F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(lblFecha, 3, 0);
            tableLayoutPanel3.Controls.Add(lblArea, 1, 0);
            tableLayoutPanel3.Controls.Add(label12, 2, 0);
            tableLayoutPanel3.Controls.Add(label9, 0, 0);
            tableLayoutPanel3.Location = new Point(0, 72);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(491, 25);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(297, 5);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(191, 15);
            lblFecha.TabIndex = 11;
            // 
            // lblArea
            // 
            lblArea.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblArea.AutoSize = true;
            lblArea.Location = new Point(45, 5);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(197, 15);
            lblArea.TabIndex = 10;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.Location = new Point(248, 5);
            label12.Name = "label12";
            label12.Size = new Size(43, 15);
            label12.TabIndex = 5;
            label12.Text = "Fecha:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(3, 5);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 2;
            label9.Text = "Area:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.8207722F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.0773926F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.979633F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.1222F));
            tableLayoutPanel2.Controls.Add(lblSexo, 3, 1);
            tableLayoutPanel2.Controls.Add(lblMatricula, 1, 1);
            tableLayoutPanel2.Controls.Add(lblEdad, 3, 0);
            tableLayoutPanel2.Controls.Add(lblNobre, 1, 0);
            tableLayoutPanel2.Controls.Add(label7, 0, 0);
            tableLayoutPanel2.Controls.Add(label8, 0, 1);
            tableLayoutPanel2.Controls.Add(label10, 2, 0);
            tableLayoutPanel2.Controls.Add(label11, 2, 1);
            tableLayoutPanel2.Location = new Point(1, 26);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(490, 46);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // lblSexo
            // 
            lblSexo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(295, 27);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(192, 15);
            lblSexo.TabIndex = 9;
            // 
            // lblMatricula
            // 
            lblMatricula.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(90, 27);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(151, 15);
            lblMatricula.TabIndex = 8;
            // 
            // lblEdad
            // 
            lblEdad.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(295, 4);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(192, 15);
            lblEdad.TabIndex = 7;
            // 
            // lblNobre
            // 
            lblNobre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblNobre.AutoSize = true;
            lblNobre.Location = new Point(90, 4);
            lblNobre.Name = "lblNobre";
            lblNobre.Size = new Size(151, 15);
            lblNobre.TabIndex = 6;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(3, 4);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 0;
            label7.Text = "Paciente:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(3, 27);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 1;
            label8.Text = "Matricula:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(247, 4);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 3;
            label10.Text = "Edad:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(247, 27);
            label11.Name = "label11";
            label11.Size = new Size(42, 15);
            label11.TabIndex = 4;
            label11.Text = "Sexo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(162, 20);
            label6.TabIndex = 1;
            label6.Text = "DATOS DEL PACIENTE";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(217, 217, 217);
            groupBox2.Controls.Add(tableLayoutPanel1);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(41, 142);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(492, 83);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 248F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblDoctora, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(lblCedula, 1, 1);
            tableLayoutPanel1.Location = new Point(1, 30);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(490, 49);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lblDoctora
            // 
            lblDoctora.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDoctora.AutoSize = true;
            lblDoctora.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDoctora.Location = new Point(3, 4);
            lblDoctora.Name = "lblDoctora";
            lblDoctora.Size = new Size(242, 15);
            lblDoctora.TabIndex = 2;
            lblDoctora.Text = "DRA.";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(3, 29);
            label4.Name = "label4";
            label4.Size = new Size(242, 15);
            label4.TabIndex = 3;
            label4.Text = "MEDICA GENERAL, CEDULA PROFESIONAL";
            // 
            // lblCedula
            // 
            lblCedula.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(251, 29);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(236, 15);
            lblCedula.TabIndex = 4;
            lblCedula.Text = ".";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(-1, 0);
            label2.Name = "label2";
            label2.Size = new Size(178, 20);
            label2.TabIndex = 0;
            label2.Text = "DATOS DE LA DOCTORA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(145, 104);
            label1.Name = "label1";
            label1.Size = new Size(313, 32);
            label1.TabIndex = 1;
            label1.Text = "RECETA MEDICA ESCOLAR";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(100, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(393, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label13.Location = new Point(223, 610);
            label13.Name = "label13";
            label13.Size = new Size(139, 20);
            label13.TabIndex = 8;
            label13.Text = "FIRMA DE LA DRA";
            // 
            // frmVistaPrevia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 208, 214);
            ClientSize = new Size(714, 674);
            Controls.Add(groupBox1);
            Name = "frmVistaPrevia";
            Text = "frmVistaPrevia";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblDoctora;
        private Label label4;
        private GroupBox groupBox3;
        private Label lblCedula;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label lblFecha;
        private Label lblArea;
        private Label lblSexo;
        private Label lblMatricula;
        private Label lblEdad;
        private Label lblNobre;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private RichTextBox richTextBox1;
        private Label label3;
        private Label label5;
        private Label label13;
    }
}