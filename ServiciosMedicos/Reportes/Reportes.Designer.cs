namespace ServiciosMedicos.Reportes
{
    partial class Reportes
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
            BtnAtras = new Button();
            cboOpciones = new ComboBox();
            BtnVIstaPrevia = new Button();
            CboDia = new ComboBox();
            CboGrupo = new ComboBox();
            BtnImpresion = new Button();
            dataGridView1 = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            CboDIagnostico = new ComboBox();
            dtpFechaEspecifica = new DateTimePicker();
            dtpFechaFin = new DateTimePicker();
            dtpFechaInicio = new DateTimePicker();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(217, 217, 217);
            groupBox1.Controls.Add(BtnAtras);
            groupBox1.Location = new Point(-5, 3);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(790, 69);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // BtnAtras
            // 
            BtnAtras.BackColor = Color.FromArgb(217, 217, 217);
            BtnAtras.BackgroundImage = Properties.Resources.Flecha_para_atras2;
            BtnAtras.BackgroundImageLayout = ImageLayout.Zoom;
            BtnAtras.FlatStyle = FlatStyle.Flat;
            BtnAtras.ForeColor = Color.FromArgb(217, 217, 217);
            BtnAtras.Location = new Point(27, 20);
            BtnAtras.Margin = new Padding(3, 2, 3, 2);
            BtnAtras.Name = "BtnAtras";
            BtnAtras.Size = new Size(84, 31);
            BtnAtras.TabIndex = 0;
            BtnAtras.UseVisualStyleBackColor = false;
            // 
            // cboOpciones
            // 
            cboOpciones.FormattingEnabled = true;
            cboOpciones.Location = new Point(73, 90);
            cboOpciones.Margin = new Padding(3, 2, 3, 2);
            cboOpciones.Name = "cboOpciones";
            cboOpciones.Size = new Size(150, 23);
            cboOpciones.TabIndex = 2;
            cboOpciones.SelectedIndexChanged += cboOpciones_SelectedIndexChanged;
            // 
            // BtnVIstaPrevia
            // 
            BtnVIstaPrevia.Location = new Point(114, 490);
            BtnVIstaPrevia.Margin = new Padding(3, 2, 3, 2);
            BtnVIstaPrevia.Name = "BtnVIstaPrevia";
            BtnVIstaPrevia.Size = new Size(152, 37);
            BtnVIstaPrevia.TabIndex = 3;
            BtnVIstaPrevia.Text = "VistaPrevia";
            BtnVIstaPrevia.UseVisualStyleBackColor = true;
            // 
            // CboDia
            // 
            CboDia.FormattingEnabled = true;
            CboDia.Location = new Point(267, 129);
            CboDia.Margin = new Padding(3, 2, 3, 2);
            CboDia.Name = "CboDia";
            CboDia.Size = new Size(150, 23);
            CboDia.TabIndex = 4;
            CboDia.SelectedIndexChanged += CboDia_SelectedIndexChanged;
            // 
            // CboGrupo
            // 
            CboGrupo.FormattingEnabled = true;
            CboGrupo.Location = new Point(73, 130);
            CboGrupo.Margin = new Padding(3, 2, 3, 2);
            CboGrupo.Name = "CboGrupo";
            CboGrupo.Size = new Size(150, 23);
            CboGrupo.TabIndex = 6;
            CboGrupo.SelectedIndexChanged += CboGrupo_SelectedIndexChanged;
            // 
            // BtnImpresion
            // 
            BtnImpresion.Location = new Point(402, 490);
            BtnImpresion.Margin = new Padding(3, 2, 3, 2);
            BtnImpresion.Name = "BtnImpresion";
            BtnImpresion.Size = new Size(152, 37);
            BtnImpresion.TabIndex = 7;
            BtnImpresion.Text = "Impresion";
            BtnImpresion.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 2);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(720, 248);
            dataGridView1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(dataGridView1);
            flowLayoutPanel1.Location = new Point(22, 158);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(724, 251);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // CboDIagnostico
            // 
            CboDIagnostico.FormattingEnabled = true;
            CboDIagnostico.Location = new Point(267, 90);
            CboDIagnostico.Margin = new Padding(3, 2, 3, 2);
            CboDIagnostico.Name = "CboDIagnostico";
            CboDIagnostico.Size = new Size(150, 23);
            CboDIagnostico.TabIndex = 5;
            CboDIagnostico.SelectedIndexChanged += CboDIagnostico_SelectedIndexChanged;
            // 
            // dtpFechaEspecifica
            // 
            dtpFechaEspecifica.Location = new Point(468, 90);
            dtpFechaEspecifica.Name = "dtpFechaEspecifica";
            dtpFechaEspecifica.Size = new Size(232, 23);
            dtpFechaEspecifica.TabIndex = 9;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Location = new Point(468, 129);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(232, 23);
            dtpFechaFin.TabIndex = 10;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(468, 90);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(232, 23);
            dtpFechaInicio.TabIndex = 11;
            dtpFechaInicio.ValueChanged += dtpFechaInicio_ValueChanged;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 208, 214);
            ClientSize = new Size(784, 536);
            Controls.Add(dtpFechaInicio);
            Controls.Add(dtpFechaFin);
            Controls.Add(dtpFechaEspecifica);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(BtnImpresion);
            Controls.Add(CboGrupo);
            Controls.Add(CboDIagnostico);
            Controls.Add(CboDia);
            Controls.Add(BtnVIstaPrevia);
            Controls.Add(cboOpciones);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Reportes";
            Text = "Reportes";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button BtnAtras;
        private ComboBox cboOpciones;
        private Button BtnVIstaPrevia;
        private ComboBox CboDia;
        private ComboBox CboGrupo;
        private Button BtnImpresion;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox CboDIagnostico;
        private DateTimePicker dtpFechaEspecifica;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpFechaInicio;
    }
}