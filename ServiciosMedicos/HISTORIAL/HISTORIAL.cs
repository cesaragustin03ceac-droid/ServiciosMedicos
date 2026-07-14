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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        // ESTE METODO CARGA LA INF DEL PACIENTE 

        public void CargarInformacionPaciente(string idPaciente)
        {
            // UN LIMPÍA CAJAS POR AI HABIA DATOS ANTES 
            dataGridView1.Rows.Clear();

            // AQUI LA CADENA DE CONEXION DE LA BASE DE DATOS 
            string cadenaConexion = "AQUI VA LA CONEXION ALOA BD ";

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    // SE CONSULTA EL PERFIL DEL ESTUDIANTE 
                    // AQUI SE AJUSTAN 'PACIENTES Y ID PACIENTE POR LO QUE VA EN LA BASE DE DATOS 
                    string queryPerfil = "SELECT Nombre, Alergias, TipoSangre, EnfermedadCronica, ContactoEmergencia FROM Pacientes WHERE id_paciente = @id";

                    using (MySqlCommand cmdPerfil = new MySqlCommand(queryPerfil, conexion))
                    {
                        cmdPerfil.Parameters.AddWithValue("@id", idPaciente);

                        using (MySqlDataReader reader = cmdPerfil.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textBox1.Text = reader["Nombre"].ToString();
                                textBox2.Text = reader["Alergias"].ToString();
                                textBox3.Text = reader["TipoSangre"].ToString();
                                textBox4.Text = reader["EnfermedadCronica"].ToString();
                                textBox5.Text = reader["ContactoEmergencia"].ToString();
                            }
                        }
                    }

                    // AQUI CONSULTA LA TABLA DE ATENCIONES PASADAS
                    string queryHistorial = "SELECT Fecha, Motivo, Diagnostico FROM Atenciones WHERE id_paciente = @id";

                    using (MySqlCommand cmdHistorial = new MySqlCommand(queryHistorial, conexion))
                    {
                        cmdHistorial.Parameters.AddWithValue("@id", idPaciente);

                        using (MySqlDataReader readerHistorial = cmdHistorial.ExecuteReader())
                        {
                            while (readerHistorial.Read())
                            {
                                dataGridView1.Rows.Add(
                                    readerHistorial["Fecha"].ToString(),
                                    readerHistorial["Motivo"].ToString(),
                                    readerHistorial["Diagnostico"].ToString(),
                                    "Formato",
                                    "Receta"
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex) // ES EL MENSAJE DE EEROR SI NO SE CONECTA CON LA BD 
            {
                MessageBox.Show("Error al conectar con la BD: " + ex.Message);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Obtener el nombre de la columna donde se hizo clic
            string nombreColumna = dataGridView1.Columns[e.ColumnIndex].Name;

            if (nombreColumna == "colFormato")
            {
                MessageBox.Show(" SE ABRE LA VENTANA FORMATO");// AQUI VA LA LIENA PARA LAMAR A FORMATO 
            }
            else if (nombreColumna == "colReceta")
            {
                MessageBox.Show("SE ABRE LA VENTANA RECETA ");// AQUI VA LA LIENA DEL CODIGO PARA LKAMMAR A RECETA 
            }

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }







        //METODO PARTA BORDES NEGROS 

        private void button1_Click(object sender, EventArgs e)
        {

        }

        // =========================================================================
        // 🎨 MÉTODO PARA DIBUJAR BORDES NEGROS GRUESOS (FORZADO)
        // =========================================================================
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void HISTORIAL_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
