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
            groupBox2perfil = new GroupBox();
            dataGridView2datos_d_paciente = new DataGridView();
            textBoxpaciente = new TextBox();
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
            groupBox2perfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2datos_d_paciente).BeginInit();
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
            groupBox1.Location = new Point(-7, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(795, 101);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 

            // groupBox2perfil
            // 
            groupBox2perfil.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2perfil.BackColor = Color.White;
            groupBox2perfil.Controls.Add(dataGridView2datos_d_paciente);
            groupBox2perfil.Controls.Add(textBoxpaciente);
            groupBox2perfil.Controls.Add(labelNOMBRE);
            groupBox2perfil.Controls.Add(pictureBox1usuario);
            groupBox2perfil.Controls.Add(label2);
            groupBox2perfil.Location = new Point(4, 156);
            groupBox2perfil.Margin = new Padding(4, 5, 4, 5);
            groupBox2perfil.Name = "groupBox2perfil";
            groupBox2perfil.Padding = new Padding(3, 4, 3, 4);
            groupBox2perfil.RightToLeft = RightToLeft.No;
            groupBox2perfil.Size = new Size(1050, 368);
            groupBox2perfil.TabIndex = 1;
            groupBox2perfil.TabStop = false;
            groupBox2perfil.Enter += groupBox2_Enter_1;
            // 
            // dataGridView2datos_d_paciente
            // 
            dataGridView2datos_d_paciente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2datos_d_paciente.BackgroundColor = Color.White;
            dataGridView2datos_d_paciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2datos_d_paciente.Location = new Point(259, 85);
            dataGridView2datos_d_paciente.Name = "dataGridView2datos_d_paciente";
            dataGridView2datos_d_paciente.RowHeadersWidth = 62;
            dataGridView2datos_d_paciente.Size = new Size(767, 267);
            dataGridView2datos_d_paciente.TabIndex = 7;
            // 
            // textBoxpaciente
            // 
            textBoxpaciente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxpaciente.Location = new Point(508, 41);
            textBoxpaciente.Name = "textBoxpaciente";
            textBoxpaciente.ReadOnly = true;
            textBoxpaciente.Size = new Size(510, 31);
            textBoxpaciente.TabIndex = 6;
            // 
            // labelNOMBRE
            // 
            labelNOMBRE.AutoSize = true;
            labelNOMBRE.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNOMBRE.Location = new Point(259, 42);
            labelNOMBRE.Name = "labelNOMBRE";
            labelNOMBRE.Size = new Size(243, 30);
            labelNOMBRE.TabIndex = 5;
            labelNOMBRE.Text = "Nombre del paciente :";
            // 
            // pictureBox1usuario
            // 
            pictureBox1usuario.BackColor = Color.White;
            pictureBox1usuario.Image = (Image)resources.GetObject("pictureBox1usuario.Image");
            pictureBox1usuario.Location = new Point(23, 89);
            pictureBox1usuario.Name = "pictureBox1usuario";
            pictureBox1usuario.Size = new Size(178, 193);
            pictureBox1usuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1usuario.TabIndex = 3;
            pictureBox1usuario.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 24);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(213, 31);
            label2.TabIndex = 0;
            label2.Text = "Perfil del Paciente ";

            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(panel1);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(15, 107);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.No;
            groupBox2.Size = new Size(753, 256);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(204, 14);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(532, 232);
            panel1.TabIndex = 4;

            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox5.BackColor = Color.FromArgb(217, 217, 217);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(240, 199);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(244, 16);
            textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox4.BackColor = Color.FromArgb(217, 217, 217);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(240, 153);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(246, 16);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox3.BackColor = Color.FromArgb(217, 217, 217);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(240, 110);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(246, 16);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(217, 217, 217);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(240, 69);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(246, 16);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.FromArgb(217, 217, 217);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(103, 32);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(382, 16);
            textBox1.TabIndex = 5;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(29, 199);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(182, 20);
            label7.TabIndex = 4;
            label7.Text = "Contacto de Emergencia:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(29, 153);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(154, 20);
            label6.TabIndex = 3;
            label6.Text = "Enfermedad Cronica:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(29, 110);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 2;
            label5.Text = "Tipo de Sangre:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 69);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(189, 20);
            label4.TabIndex = 1;
            label4.Text = "Alergias a Medicamentos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 32);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 0;
            label3.Text = "Nombre:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 67);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 18);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(160, 20);
            label2.TabIndex = 0;
            label2.Text = "Perfil del Estudiantes ";
            label2.Click += label2_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(15, 369);
            groupBox3.Name = "groupBox3";
            groupBox3.RightToLeft = RightToLeft.No;
            groupBox3.Size = new Size(753, 210);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 17);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 1;
            label1.Text = "Atenciones Pasadas";
            // 
            // dataGridView1atenciones
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 37);
            dataGridView1.Margin = new Padding(1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(676, 152);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(204, 204, 204);
            button1.Location = new Point(458, 589);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(118, 32);
            button1.TabIndex = 2;
            button1.Text = "Editar Expediente ";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(204, 204, 204);
            button2.Location = new Point(622, 589);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(104, 32);
            button2.TabIndex = 3;
            button2.Text = "Formato";
            button2.UseVisualStyleBackColor = false;
            // 
            // HISTORIAL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 208, 214);
            ClientSize = new Size(784, 661);
            Controls.Add(button2);
            Controls.Add(groupBox3atenciones);
            Controls.Add(button1);
            Controls.Add(groupBox2perfil);
            Controls.Add(groupBox1);
            Name = "HISTORIAL";
            Text = "HISTORIAL";
            Paint += DibujarBordeGrueso;
            groupBox2perfil.ResumeLayout(false);
            groupBox2perfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2datos_d_paciente).EndInit();
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
        private TextBox textBoxpaciente;
        private Label labelNOMBRE;
        private DataGridView dataGridView2datos_d_paciente;
    }
}