namespace ServiciosMedicos.GeneracionReceta
{
    partial class Medicamentos
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
            btnInvemtario = new Button();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            BtnAgregar = new Button();
            btnEditar = new Button();
            BtnGuardar = new Button();
            groupBox3 = new GroupBox();
            label4 = new Label();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnInvemtario);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(32, 113);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(831, 269);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda de medicamentos";
            // 
            // btnInvemtario
            // 
            btnInvemtario.Location = new Point(595, 102);
            btnInvemtario.Name = "btnInvemtario";
            btnInvemtario.Size = new Size(169, 53);
            btnInvemtario.TabIndex = 5;
            btnInvemtario.Text = "Modificar Inventario";
            btnInvemtario.UseVisualStyleBackColor = true;
            btnInvemtario.Click += btnInvemtario_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(161, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(360, 28);
            comboBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(250, 132);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 135);
            label2.Name = "label2";
            label2.Size = new Size(186, 20);
            label2.TabIndex = 1;
            label2.Text = "Cantidad de Medicamento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 58);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Medicamento";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(32, 412);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(831, 308);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Indicaciones del medicamento";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(42, 107);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(556, 167);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 67);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 4;
            label3.Text = "Indicaciones";
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(614, 738);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(169, 53);
            BtnAgregar.TabIndex = 2;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(406, 738);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(169, 53);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(193, 738);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(169, 53);
            BtnGuardar.TabIndex = 4;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(217, 217, 217);
            groupBox3.Location = new Point(-4, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(903, 92);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 201);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 6;
            label4.Text = "Cantidad a dar ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 198);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 27);
            textBox1.TabIndex = 7;
            // 
            // Medicamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 208, 214);
            ClientSize = new Size(896, 803);
            Controls.Add(groupBox3);
            Controls.Add(BtnGuardar);
            Controls.Add(btnEditar);
            Controls.Add(BtnAgregar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Medicamentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Medicamentos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private Label label3;
        private ComboBox comboBox1;
        private RichTextBox richTextBox1;
        private Button BtnAgregar;
        private Button btnEditar;
        private Button BtnGuardar;
        private Button btnInvemtario;
        private GroupBox groupBox3;
        private TextBox textBox1;
        private Label label4;
    }
}