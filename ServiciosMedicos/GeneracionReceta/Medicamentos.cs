using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ServiciosMedicos.GeneracionReceta
{
    public partial class Medicamentos : Form
    {
        public Medicamentos()
        {
            InitializeComponent();
        }

        private void btnInvemtario_Click(object sender, EventArgs e)
        {
            Inventario frmInventario = new Inventario();
            frmInventario.Show();

            this.Close();
        }
    }
}
