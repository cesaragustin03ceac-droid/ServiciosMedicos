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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            BtnAtras = new Button();
            cboOpciones = new ComboBox();
            BtnVIstaPrevia = new Button();
            CboDia = new ComboBox();
            CboDIagnostico = new ComboBox();
            CboGrupo = new ComboBox();
            BtnImpresion = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 239);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(823, 382);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(217, 217, 217);
            groupBox1.Controls.Add(BtnAtras);
            groupBox1.Location = new Point(-6, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(903, 92);
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
            BtnAtras.Location = new Point(31, 27);
            BtnAtras.Name = "BtnAtras";
            BtnAtras.Size = new Size(96, 41);
            BtnAtras.TabIndex = 0;
            BtnAtras.UseVisualStyleBackColor = false;
            // 
            // cboOpciones
            // 
            cboOpciones.FormattingEnabled = true;
            cboOpciones.Location = new Point(35, 158);
            cboOpciones.Name = "cboOpciones";
            cboOpciones.Size = new Size(171, 28);
            cboOpciones.TabIndex = 2;
            cboOpciones.SelectedIndexChanged += cboOpciones_SelectedIndexChanged;
            // 
            // BtnVIstaPrevia
            // 
            BtnVIstaPrevia.Location = new Point(130, 654);
            BtnVIstaPrevia.Name = "BtnVIstaPrevia";
            BtnVIstaPrevia.Size = new Size(174, 49);
            BtnVIstaPrevia.TabIndex = 3;
            BtnVIstaPrevia.Text = "VistaPrevia";
            BtnVIstaPrevia.UseVisualStyleBackColor = true;
            // 
            // CboDia
            // 
            CboDia.FormattingEnabled = true;
            CboDia.Location = new Point(665, 158);
            CboDia.Name = "CboDia";
            CboDia.Size = new Size(171, 28);
            CboDia.TabIndex = 4;
            CboDia.SelectedIndexChanged += CboDia_SelectedIndexChanged;
            // 
            // CboDIagnostico
            // 
            CboDIagnostico.FormattingEnabled = true;
            CboDIagnostico.Location = new Point(445, 158);
            CboDIagnostico.Name = "CboDIagnostico";
            CboDIagnostico.Size = new Size(171, 28);
            CboDIagnostico.TabIndex = 5;
            CboDIagnostico.SelectedIndexChanged += CboDIagnostico_SelectedIndexChanged;
            // 
            // CboGrupo
            // 
            CboGrupo.FormattingEnabled = true;
            CboGrupo.Location = new Point(229, 158);
            CboGrupo.Name = "CboGrupo";
            CboGrupo.Size = new Size(171, 28);
            CboGrupo.TabIndex = 6;
            CboGrupo.SelectedIndexChanged += CboGrupo_SelectedIndexChanged;
            // 
            // BtnImpresion
            // 
            BtnImpresion.Location = new Point(459, 654);
            BtnImpresion.Name = "BtnImpresion";
            BtnImpresion.Size = new Size(174, 49);
            BtnImpresion.TabIndex = 7;
            BtnImpresion.Text = "Impresion";
            BtnImpresion.UseVisualStyleBackColor = true;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 208, 214);
            ClientSize = new Size(896, 715);
            Controls.Add(BtnImpresion);
            Controls.Add(CboGrupo);
            Controls.Add(CboDIagnostico);
            Controls.Add(CboDia);
            Controls.Add(BtnVIstaPrevia);
            Controls.Add(cboOpciones);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Reportes";
            Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button BtnAtras;
        private ComboBox cboOpciones;
        private Button BtnVIstaPrevia;
        private ComboBox CboDia;
        private ComboBox CboDIagnostico;
        private ComboBox CboGrupo;
        private Button BtnImpresion;
    }
}