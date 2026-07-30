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
            txtCantidadDar = new TextBox();
            label4 = new Label();
            btnInvemtario = new Button();
            cboMedicamento = new ComboBox();
            txtCantidadMedicamento = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtIndicaciones = new RichTextBox();
            label3 = new Label();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCantidadDar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnInvemtario);
            groupBox1.Controls.Add(cboMedicamento);
            groupBox1.Controls.Add(txtCantidadMedicamento);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(32, 113);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(831, 269);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda de medicamentos";
            // 
            // txtCantidadDar
            // 
            txtCantidadDar.Location = new Point(175, 198);
            txtCantidadDar.Name = "txtCantidadDar";
            txtCantidadDar.Size = new Size(198, 27);
            txtCantidadDar.TabIndex = 7;
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
            // cboMedicamento
            // 
            cboMedicamento.FormattingEnabled = true;
            cboMedicamento.Location = new Point(161, 55);
            cboMedicamento.Name = "cboMedicamento";
            cboMedicamento.Size = new Size(360, 28);
            cboMedicamento.TabIndex = 4;
            // 
            // txtCantidadMedicamento
            // 
            txtCantidadMedicamento.Location = new Point(250, 132);
            txtCantidadMedicamento.Name = "txtCantidadMedicamento";
            txtCantidadMedicamento.ReadOnly = true;
            txtCantidadMedicamento.Size = new Size(198, 27);
            txtCantidadMedicamento.TabIndex = 3;
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
            groupBox2.Controls.Add(txtIndicaciones);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(32, 412);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(831, 308);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Indicaciones del medicamento";
            // 
            // txtIndicaciones
            // 
            txtIndicaciones.Location = new Point(42, 107);
            txtIndicaciones.Name = "txtIndicaciones";
            txtIndicaciones.Size = new Size(556, 167);
            txtIndicaciones.TabIndex = 5;
            txtIndicaciones.Text = "";
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
            // btnAgregar
            // 
            btnAgregar.Location = new Point(614, 738);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(169, 53);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
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
            // btnGuardar
            // 
            btnGuardar.Location = new Point(193, 738);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(169, 53);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
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
            // Medicamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 208, 214);
            ClientSize = new Size(896, 803);
            Controls.Add(groupBox3);
            Controls.Add(btnGuardar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
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
        private TextBox txtCantidadMedicamento;
        private GroupBox groupBox2;
        private Label label3;
        private ComboBox cboMedicamento;
        private RichTextBox txtIndicaciones;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnGuardar;
        private Button btnInvemtario;
        private GroupBox groupBox3;
        private TextBox txtCantidadDar;
        private Label label4;
    }
}