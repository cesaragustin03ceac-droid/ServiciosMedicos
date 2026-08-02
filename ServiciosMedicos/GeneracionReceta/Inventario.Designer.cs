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
            BtnAgregar = new Button();
            numCantidadAgregar = new NumericUpDown();
            txtNombreAgregar = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            txtCantidadNueva = new TextBox();
            label5 = new Label();
            txtCantidadAnterior = new TextBox();
            cboNombreModificar = new ComboBox();
            BtnModificar = new Button();
            label3 = new Label();
            label4 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidadAgregar).BeginInit();
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
            groupBox2.Controls.Add(numCantidadAgregar);
            groupBox2.Controls.Add(txtNombreAgregar);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(26, 117);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(823, 188);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Agregar Medicamento";
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(682, 68);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(115, 52);
            BtnAgregar.TabIndex = 4;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // numCantidadAgregar
            // 
            numCantidadAgregar.Location = new Point(141, 110);
            numCantidadAgregar.Name = "numCantidadAgregar";
            numCantidadAgregar.Size = new Size(150, 27);
            numCantidadAgregar.TabIndex = 3;
            // 
            // txtNombreAgregar
            // 
            txtNombreAgregar.Location = new Point(132, 50);
            txtNombreAgregar.Name = "txtNombreAgregar";
            txtNombreAgregar.Size = new Size(512, 27);
            txtNombreAgregar.TabIndex = 2;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 50);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtCantidadNueva);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtCantidadAnterior);
            groupBox3.Controls.Add(cboNombreModificar);
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
            // txtCantidadNueva
            // 
            txtCantidadNueva.Location = new Point(468, 110);
            txtCantidadNueva.Name = "txtCantidadNueva";
            txtCantidadNueva.Size = new Size(124, 27);
            txtCantidadNueva.TabIndex = 7;
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
            // txtCantidadAnterior
            // 
            txtCantidadAnterior.Location = new Point(180, 107);
            txtCantidadAnterior.Name = "txtCantidadAnterior";
            txtCantidadAnterior.ReadOnly = true;
            txtCantidadAnterior.Size = new Size(124, 27);
            txtCantidadAnterior.TabIndex = 5;
            // 
            // cboNombreModificar
            // 
            cboNombreModificar.FormattingEnabled = true;
            cboNombreModificar.Location = new Point(132, 50);
            cboNombreModificar.Name = "cboNombreModificar";
            cboNombreModificar.Size = new Size(512, 28);
            cboNombreModificar.TabIndex = 5;
            // 
            // BtnModificar
            // 
            BtnModificar.Location = new Point(682, 68);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(115, 52);
            BtnModificar.TabIndex = 4;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            BtnModificar.Click += BtnModificar_Click;
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
            ((System.ComponentModel.ISupportInitialize)numCantidadAgregar).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button BtnAgregar;
        private NumericUpDown numCantidadAgregar;
        private TextBox txtNombreAgregar;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private ComboBox cboNombreModificar;
        private Button BtnModificar;
        private Label label3;
        private Label label4;
        private TextBox txtCantidadNueva;
        private Label label5;
        private TextBox txtCantidadAnterior;
    }
}