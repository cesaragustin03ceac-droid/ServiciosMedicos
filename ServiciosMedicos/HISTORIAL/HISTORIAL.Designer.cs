namespace ServiciosMedicos.HISTORIAL
{
    partial class HISTORIAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HISTORIAL));
            groupBox1 = new GroupBox();
            label8 = new Label();
            BtnAtras = new Button();
            groupBox2perfil = new GroupBox();
            PerfilPaciente = new DataGridView();
            txtNombrePaciente = new TextBox();
            labelNOMBRE = new Label();
            pictureBox1usuario = new PictureBox();
            label2 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox3atenciones = new GroupBox();
            label1 = new Label();
            dataGridView1atenciones = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            btnGuardar = new Button();
            groupBox1.SuspendLayout();
            groupBox2perfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PerfilPaciente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1usuario).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            groupBox3atenciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1atenciones).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.FromArgb(217, 217, 217);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(BtnAtras);
            groupBox1.Location = new Point(3, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(893, 92);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(300, 27);
            label8.Name = "label8";
            label8.Size = new Size(304, 41);
            label8.TabIndex = 5;
            label8.Text = "Historial y Expediente";
            // 
            // BtnAtras
            // 
            BtnAtras.BackColor = Color.FromArgb(217, 217, 217);
            BtnAtras.BackgroundImage = Properties.Resources.Flecha_para_atras2;
            BtnAtras.BackgroundImageLayout = ImageLayout.Zoom;
            BtnAtras.Location = new Point(31, 27);
            BtnAtras.Name = "BtnAtras";
            BtnAtras.Size = new Size(96, 41);
            BtnAtras.TabIndex = 5;
            BtnAtras.UseVisualStyleBackColor = false;
            BtnAtras.Click += BtnAtras_Click;
            // 
            // groupBox2perfil
            // 
            groupBox2perfil.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2perfil.BackColor = Color.White;
            groupBox2perfil.Controls.Add(PerfilPaciente);
            groupBox2perfil.Controls.Add(txtNombrePaciente);
            groupBox2perfil.Controls.Add(labelNOMBRE);
            groupBox2perfil.Controls.Add(pictureBox1usuario);
            groupBox2perfil.Controls.Add(label2);
            groupBox2perfil.Location = new Point(3, 130);
            groupBox2perfil.Margin = new Padding(3, 4, 3, 4);
            groupBox2perfil.Name = "groupBox2perfil";
            groupBox2perfil.Padding = new Padding(2, 3, 2, 3);
            groupBox2perfil.RightToLeft = RightToLeft.No;
            groupBox2perfil.Size = new Size(882, 307);
            groupBox2perfil.TabIndex = 1;
            groupBox2perfil.TabStop = false;
            groupBox2perfil.Enter += groupBox2_Enter_1;
            // 
            // PerfilPaciente
            // 
            PerfilPaciente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PerfilPaciente.BackgroundColor = Color.White;
            PerfilPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PerfilPaciente.Location = new Point(216, 71);
            PerfilPaciente.Margin = new Padding(2);
            PerfilPaciente.Name = "PerfilPaciente";
            PerfilPaciente.ReadOnly = true;
            PerfilPaciente.RowHeadersWidth = 62;
            PerfilPaciente.Size = new Size(646, 222);
            PerfilPaciente.TabIndex = 7;
            // 
            // txtNombrePaciente
            // 
            txtNombrePaciente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombrePaciente.Location = new Point(423, 34);
            txtNombrePaciente.Margin = new Padding(2);
            txtNombrePaciente.Name = "txtNombrePaciente";
            txtNombrePaciente.ReadOnly = true;
            txtNombrePaciente.Size = new Size(433, 27);
            txtNombrePaciente.TabIndex = 6;
            // 
            // labelNOMBRE
            // 
            labelNOMBRE.AutoSize = true;
            labelNOMBRE.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNOMBRE.Location = new Point(216, 35);
            labelNOMBRE.Margin = new Padding(2, 0, 2, 0);
            labelNOMBRE.Name = "labelNOMBRE";
            labelNOMBRE.Size = new Size(208, 25);
            labelNOMBRE.TabIndex = 5;
            labelNOMBRE.Text = "Nombre del paciente :";
            // 
            // pictureBox1usuario
            // 
            pictureBox1usuario.BackColor = Color.White;
            pictureBox1usuario.Image = (Image)resources.GetObject("pictureBox1usuario.Image");
            pictureBox1usuario.Location = new Point(19, 74);
            pictureBox1usuario.Margin = new Padding(2);
            pictureBox1usuario.Name = "pictureBox1usuario";
            pictureBox1usuario.Size = new Size(148, 161);
            pictureBox1usuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1usuario.TabIndex = 3;
            pictureBox1usuario.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 20);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(175, 25);
            label2.TabIndex = 0;
            label2.Text = "Perfil del Paciente ";
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox5.BackColor = Color.FromArgb(217, 217, 217);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(255, 320);
            textBox5.Margin = new Padding(2, 3, 2, 3);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(467, 20);
            textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox4.BackColor = Color.FromArgb(217, 217, 217);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(255, 245);
            textBox4.Margin = new Padding(2, 3, 2, 3);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(467, 20);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox3.BackColor = Color.FromArgb(217, 217, 217);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(255, 172);
            textBox3.Margin = new Padding(2, 4, 2, 4);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(467, 20);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(217, 217, 217);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(255, 71);
            textBox2.Margin = new Padding(2, 3, 2, 3);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(281, 20);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.FromArgb(217, 217, 217);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(255, 24);
            textBox1.Margin = new Padding(2, 4, 2, 4);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(467, 20);
            textBox1.TabIndex = 5;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(1, 317);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(251, 25);
            label7.TabIndex = 4;
            label7.Text = "Contacto de Emergencia:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(1, 243);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(251, 25);
            label6.TabIndex = 3;
            label6.Text = "Enfermedad Cronica:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1, 146);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(152, 25);
            label5.TabIndex = 2;
            label5.Text = "Tipo de Sangre:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1, 94);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(251, 25);
            label4.TabIndex = 1;
            label4.Text = "Alergias a Medicamentos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1, 0);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 0;
            label3.Text = "Nombre:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.Controls.Add(textBox5, 1, 4);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox4, 1, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(label7, 0, 4);
            tableLayoutPanel1.Controls.Add(textBox3, 1, 2);
            tableLayoutPanel1.Controls.Add(label6, 0, 3);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Location = new Point(3, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 21.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(724, 368);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // groupBox3atenciones
            // 
            groupBox3atenciones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3atenciones.BackColor = Color.White;
            groupBox3atenciones.Controls.Add(label1);
            groupBox3atenciones.Controls.Add(dataGridView1atenciones);
            groupBox3atenciones.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3atenciones.Location = new Point(3, 445);
            groupBox3atenciones.Margin = new Padding(3, 4, 3, 4);
            groupBox3atenciones.Name = "groupBox3atenciones";
            groupBox3atenciones.Padding = new Padding(2, 3, 2, 3);
            groupBox3atenciones.RightToLeft = RightToLeft.No;
            groupBox3atenciones.Size = new Size(882, 285);
            groupBox3atenciones.TabIndex = 2;
            groupBox3atenciones.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 14);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 1;
            label1.Text = "Atenciones Pasadas";
            // 
            // dataGridView1atenciones
            // 
            dataGridView1atenciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1atenciones.BackgroundColor = Color.White;
            dataGridView1atenciones.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView1atenciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1atenciones.Location = new Point(3, 41);
            dataGridView1atenciones.Margin = new Padding(1);
            dataGridView1atenciones.Name = "dataGridView1atenciones";
            dataGridView1atenciones.RowHeadersWidth = 62;
            dataGridView1atenciones.Size = new Size(875, 240);
            dataGridView1atenciones.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(204, 204, 204);
            button1.Location = new Point(559, 754);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(150, 36);
            button1.TabIndex = 2;
            button1.Text = "Editar Expediente ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(204, 204, 204);
            button2.Location = new Point(746, 754);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(112, 36);
            button2.TabIndex = 3;
            button2.Text = "Formato";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.BackColor = Color.FromArgb(204, 204, 204);
            btnGuardar.Location = new Point(387, 754);
            btnGuardar.Margin = new Padding(2, 3, 2, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 36);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // HISTORIAL
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(182, 208, 214);
            ClientSize = new Size(896, 803);
            Controls.Add(btnGuardar);
            Controls.Add(button2);
            Controls.Add(groupBox3atenciones);
            Controls.Add(button1);
            Controls.Add(groupBox2perfil);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HISTORIAL";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HISTORIAL";
            Load += HISTORIAL_Load;
            Paint += DibujarBordeGrueso;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2perfil.ResumeLayout(false);
            groupBox2perfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PerfilPaciente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1usuario).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox3atenciones.ResumeLayout(false);
            groupBox3atenciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1atenciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2perfil;
        private GroupBox groupBox3atenciones;
        private Label label1;
        private DataGridView dataGridView1atenciones;
        private Label label2;
        private PictureBox pictureBox1usuario;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtNombrePaciente;
        private Label labelNOMBRE;
        private DataGridView PerfilPaciente;
        private Button btnGuardar;
        private Button BtnAtras;
        private Label label8;
    }
}