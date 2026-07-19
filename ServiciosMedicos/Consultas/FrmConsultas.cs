using ServiciosMedicos.GeneracionReceta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ServiciosMedicos.Consultas
{
    public partial class FrmConsultas : Form
    {

        public FrmConsultas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                frmGeneracionReceta ventanaConsulta = new frmGeneracionReceta();

                ventanaConsulta.Show();

                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la consulta: " + ex.Message, "Error");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
