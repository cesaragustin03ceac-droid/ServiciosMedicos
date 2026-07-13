namespace ServiciosMedicos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            BtEntrar = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            TxbContrasena = new TextBox();
            TxbUsuario = new TextBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(BtEntrar);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(TxbContrasena);
            panel1.Controls.Add(TxbUsuario);
            panel1.Location = new Point(100, 190);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 262);
            panel1.TabIndex = 0;
            // 
            // BtEntrar
            // 
            BtEntrar.BackColor = Color.FromArgb(204, 204, 204);
            BtEntrar.Cursor = Cursors.IBeam;
            BtEntrar.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtEntrar.Location = new Point(94, 190);
            BtEntrar.Name = "BtEntrar";
            BtEntrar.Size = new Size(389, 38);
            BtEntrar.TabIndex = 4;
            BtEntrar.Text = "Entrar";
            BtEntrar.UseVisualStyleBackColor = false;
            BtEntrar.Click += BtEntrar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(77, 115, 147);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(94, 119);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(77, 115, 147);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(94, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // TxbContrasena
            // 
            TxbContrasena.BorderStyle = BorderStyle.FixedSingle;
            TxbContrasena.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxbContrasena.Location = new Point(136, 120);
            TxbContrasena.Name = "TxbContrasena";
            TxbContrasena.PlaceholderText = "Contraseña";
            TxbContrasena.Size = new Size(347, 40);
            TxbContrasena.TabIndex = 1;
            // 
            // TxbUsuario
            // 
            TxbUsuario.BorderStyle = BorderStyle.FixedSingle;
            TxbUsuario.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxbUsuario.Location = new Point(136, 52);
            TxbUsuario.Name = "TxbUsuario";
            TxbUsuario.PlaceholderText = "Usuario";
            TxbUsuario.Size = new Size(347, 40);
            TxbUsuario.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(132, 154, 174);
            panel2.Location = new Point(-7, 652);
            panel2.Name = "panel2";
            panel2.Size = new Size(795, 107);
            panel2.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(100, 21);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(567, 101);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 208, 214);
            ClientSize = new Size(782, 753);
            Controls.Add(pictureBox3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Inicio de sesion";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox TxbContrasena;
        private TextBox TxbUsuario;
        private Button BtEntrar;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
    }
}
