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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(217, 217, 217);
            groupBox1.Location = new Point(-10, 0);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1136, 167);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Location = new Point(23, 202);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.RightToLeft = RightToLeft.No;
            groupBox2.Size = new Size(1076, 375);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(23, 602);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.RightToLeft = RightToLeft.No;
            groupBox3.Size = new Size(1076, 375);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(76, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(939, 225);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 30);
            label1.Name = "label1";
            label1.Size = new Size(167, 25);
            label1.TabIndex = 1;
            label1.Text = "Atenciones Pasadas";
            label1.Click += label1_Click;
            // 
            // HISTORIAL
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 208, 214);
            ClientSize = new Size(1120, 1050);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "HISTORIAL";
            Text = "HISTORIAL";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private DataGridView dataGridView1;
    }
}