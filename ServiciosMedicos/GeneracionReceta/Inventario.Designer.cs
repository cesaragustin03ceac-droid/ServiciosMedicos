namespace ServiciosMedicos.GeneracionReceta
{
    partial class Inventario
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            BtnAgregar = new Button();
            groupBox3 = new GroupBox();
            BtnModificar = new Button();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(217, 217, 217);
            groupBox1.Location = new Point(-6, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(903, 92);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnAgregar);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(26, 117);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(823, 188);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Agregar Medicamento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 50);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 110);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Cantidad";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(132, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(512, 27);
            textBox1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(141, 110);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 3;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(682, 68);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(115, 52);
            BtnAgregar.TabIndex = 4;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(BtnModificar);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(26, 330);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(823, 188);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Modificar Medicamento";
            // 
            // BtnModificar
            // 
            BtnModificar.Location = new Point(682, 68);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(115, 52);
            BtnModificar.TabIndex = 4;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 110);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 1;
            label3.Text = "Cantidad Anterior";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 50);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 0;
            label4.Text = "Nombre";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(132, 50);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(512, 28);
            comboBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(180, 107);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(124, 27);
            textBox2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(333, 114);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 6;
            label5.Text = "Cantidad Nueva";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(468, 110);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(124, 27);
            textBox3.TabIndex = 7;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 208, 214);
            ClientSize = new Size(896, 553);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Inventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventario";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button BtnAgregar;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private ComboBox comboBox1;
        private Button BtnModificar;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox2;
    }
}