using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ServiciosMedicos.GeneracionReceta
{
    public partial class frmGeneracionReceta : Form
    {
        public frmGeneracionReceta()
        {
            InitializeComponent();
            button1.Paint += DibujarBordeGrueso;       // BORDE DEL BOTON EDITAR  EXPEDIENTE 
            button5.Paint += DibujarBordeGrueso;
            button6.Paint += DibujarBordeGrueso;
            button7.Paint += DibujarBordeGrueso;
            groupBox2.Paint += DibujarBordeGrueso;
            groupBox3.Paint += DibujarBordeGrueso;
          

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void DibujarBordeGrueso(object sender, PaintEventArgs e)
        {
            Control control = (Control)sender;
            int grosor = 3; // Lápiz grueso de 3 píxeles

            using (Pen lapizNegro = new Pen(Color.Black, grosor))
            {
                // Ajustamos el rectángulo un poquito hacia adentro para que no se amoche
                Rectangle rectangulo = new Rectangle(
                    grosor / 2,
                    grosor / 2,
                    control.Width - grosor,
                    control.Height - grosor
                );

                e.Graphics.DrawRectangle(lapizNegro, rectangulo);
            }
        }

        private void frmGeneracionReceta_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
