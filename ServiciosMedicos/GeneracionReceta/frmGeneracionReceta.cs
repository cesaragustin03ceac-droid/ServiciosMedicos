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
            groupBox2.Paint += DibujarBordeGrueso;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
