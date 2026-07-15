using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ServiciosMedicos.HISTORIAL
{
    public partial class HISTORIAL : Form
    {
        public HISTORIAL()
        {
            InitializeComponent();
            EstilarDataGridView(); //ESTIRA LA TABLA DE ABAJPO 
            groupBox1.Paint += DibujarBordeGrueso;  // BORDES DFEL GRUPÓ BOX 1 INFORMACION DEL PACIENTE 
            groupBox2perfil.Paint += DibujarBordeGrueso;   // BORDES DFEL GRUPÓ BOX  3 PARTE GRIS DED ARIIBA 
            groupBox3atenciones.Paint += DibujarBordeGrueso;   // BORDE DEL GRUPO BOX DE LA TABLA DE ATENCIONES PASADAS
            button1.Paint += DibujarBordeGrueso;       // BORDE DEL BOTON EDITAR  EXPEDIENTE 
            button2.Paint += DibujarBordeGrueso;     // BORDE DE IR AL FORMATO 
            dataGridView1atenciones.Rows.Add("14/07/2026", "Dolor de cabeza", "Migraña leve", "Ver Formato", "Ver Receta");    // ESTA LINA ES SOLO DE PRUEBA PARA VISUALIZAR EL FORMATO DE LA TABLA 


        }
        private void EstilarDataGridView()
        {
            dataGridView1atenciones.Columns.Clear();
            dataGridView1atenciones.EnableHeadersVisualStyles = false;

            // Color Azul de la Guía de Estilos (#6FA8DC)
            dataGridView1atenciones.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#6FA8DC");
            dataGridView1atenciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1atenciones.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridView1atenciones.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1atenciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1atenciones.ColumnHeadersHeight = 35;

            // Formato general de celdas y rejilla
            dataGridView1atenciones.BackgroundColor = Color.White;
            dataGridView1atenciones.BorderStyle = BorderStyle.FixedSingle;
            dataGridView1atenciones.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1atenciones.GridColor = Color.Black;
            dataGridView1atenciones.RowHeadersVisible = false;
            dataGridView1atenciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1atenciones.AllowUserToAddRows = false;

            // Crear las 5 columnas vacías
            dataGridView1atenciones.Columns.Add("colFecha", "Fecha");
            dataGridView1atenciones.Columns.Add("colMotivo", "Motivo");
            dataGridView1atenciones.Columns.Add("colDiagnostico", "Diagnostico");

            DataGridViewLinkColumn colFormato = new DataGridViewLinkColumn();
            colFormato.Name = "colFormato";
            colFormato.HeaderText = "Formato";
            colFormato.UseColumnTextForLinkValue = false;
            dataGridView1atenciones.Columns.Add(colFormato);

            DataGridViewLinkColumn colReceta = new DataGridViewLinkColumn();
            colReceta.Name = "colReceta";
            colReceta.HeaderText = "Receta";
            colReceta.UseColumnTextForLinkValue = false;
            dataGridView1atenciones.Columns.Add(colReceta);

            dataGridView1atenciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void DibujarBordeGrueso(object sender, PaintEventArgs e)
        {
            Control control = (Control)sender;
            int grosor = 3;

            using (Pen lapizNegro = new Pen(Color.Black, grosor))
            {
             
                Rectangle rectangulo = new Rectangle(
                    grosor / 2,
                    grosor / 2,
                    control.Width - grosor,
                    control.Height - grosor
                );

                e.Graphics.DrawRectangle(lapizNegro, rectangulo);
            }
        }
        private void groupBox2_Enter_1(object sender, EventArgs e)
        {
        }

    }
}
