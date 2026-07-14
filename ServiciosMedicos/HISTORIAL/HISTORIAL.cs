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
            groupBox2.Paint += DibujarBordeGrueso;   // BORDES DFEL GRUPÓ BOX  3 PARTE GRIS DED ARIIBA 
            groupBox3.Paint += DibujarBordeGrueso;   // BORDE DEL GRUPO BOX DE LA TABLA DE ATENCIONES PASADAS
            button1.Paint += DibujarBordeGrueso;       // BORDE DEL BOTON EDITAR  EXPEDIENTE 
            button2.Paint += DibujarBordeGrueso;     // BORDE DE IR AL FORMATO 
            dataGridView1.Rows.Add("14/07/2026", "Dolor de cabeza", "Migraña leve", "Ver Formato", "Ver Receta");    // ESTA LINA ES SOLO DE PRUEBA PARA VISUALIZAR EL FORMATO DE LA TABLA 


        }
        private void EstilarDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.EnableHeadersVisualStyles = false;

            // Color Azul de la Guía de Estilos (#6FA8DC)
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#6FA8DC");
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.ColumnHeadersHeight = 35;

            // Formato general de celdas y rejilla
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.FixedSingle;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            // Crear las 5 columnas vacías
            dataGridView1.Columns.Add("colFecha", "Fecha");
            dataGridView1.Columns.Add("colMotivo", "Motivo");
            dataGridView1.Columns.Add("colDiagnostico", "Diagnostico");

            DataGridViewLinkColumn colFormato = new DataGridViewLinkColumn();
            colFormato.Name = "colFormato";
            colFormato.HeaderText = "Formato";
            colFormato.UseColumnTextForLinkValue = false;
            dataGridView1.Columns.Add(colFormato);

            DataGridViewLinkColumn colReceta = new DataGridViewLinkColumn();
            colReceta.Name = "colReceta";
            colReceta.HeaderText = "Receta";
            colReceta.UseColumnTextForLinkValue = false;
            dataGridView1.Columns.Add(colReceta);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
