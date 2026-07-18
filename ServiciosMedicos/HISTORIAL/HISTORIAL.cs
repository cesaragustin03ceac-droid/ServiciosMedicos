using MySql.Data.MySqlClient;
using ServiciosMedicos.DataConexion;
using ServiciosMedicos.GeneracionReceta;
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
        private string idPacienteActual;
        private string tipoPacienteActual;
        public HISTORIAL()
        {
            InitializeComponent();
            EstilarDataGridView(); //ESTIRA LA TABLA DE ABAJPO 
            groupBox1.Paint += DibujarBordeGrueso;  // BORDES DFEL GRUPÓ BOX 1 INFORMACION DEL PACIENTE 
            groupBox2perfil.Paint += DibujarBordeGrueso;   // BORDES DFEL GRUPÓ BOX  3 PARTE GRIS DED ARIIBA 
            groupBox3atenciones.Paint += DibujarBordeGrueso;   // BORDE DEL GRUPO BOX DE LA TABLA DE ATENCIONES PASADAS
            button1.Paint += DibujarBordeGrueso;       // BORDE DEL BOTON EDITAR  EXPEDIENTE 
            button2.Paint += DibujarBordeGrueso;     // BORDE DE IR AL FORMATO 


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
        public void CargarPerfilPaciente(string idPaciente, string tipoPaciente)
        {
            this.idPacienteActual = idPaciente;
            this.tipoPacienteActual = tipoPaciente;
            Conexion conexionBD = new Conexion();
            MySqlConnection conexionAbierta = conexionBD.obtenerconexion();

            if (conexionAbierta != null)
            {
                try
                {
                    string query = "";

                    if (tipoPaciente == "Alumno")
                    {
                        query = @"SELECT a.Nombre, a.Apellido_P, a.Apellido_M, 
                                 e.TipoSangre AS 'Tipo de Sangre', 
                                 e.Alergias, 
                                 e.Enfermedades AS 'Enfermedades Crónicas',
                                 e.Peso, 
                                 e.Talla
                          FROM Alumno a
                          LEFT JOIN Consulta c ON a.Matricula = c.Matricula_Alumno
                          LEFT JOIN Diagnostico d ON c.Id_Diagnostico = d.Id_Diagnostico
                          LEFT JOIN Expediente e ON d.Id_Expediente = e.Id_Expediente
                          WHERE a.Matricula = @id 
                          LIMIT 1;";
                    }
                    else if (tipoPaciente == "Trabajador")
                    {
                        query = @"SELECT t.Nombre, t.Apellido_P, t.Apellido_M, 
                                 e.TipoSangre AS 'Tipo de Sangre', 
                                 e.Alergias, 
                                 e.Enfermedades AS 'Enfermedades Crónicas',
                                 e.Peso, 
                                 e.Talla
                          FROM Trabajador t
                          LEFT JOIN Consulta c ON t.Num_Trabajador = c.Num_Trabajador
                          LEFT JOIN Diagnostico d ON c.Id_Diagnostico = d.Id_Diagnostico
                          LEFT JOIN Expediente e ON d.Id_Expediente = e.Id_Expediente
                          WHERE t.Num_Trabajador = @id 
                          LIMIT 1;";
                    }

                    MySqlCommand comando = new MySqlCommand(query, conexionAbierta);
                    comando.Parameters.AddWithValue("@id", idPaciente);

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataTable tablaDatos = new DataTable();
                    adaptador.Fill(tablaDatos);

                    if (tablaDatos.Rows.Count > 0)
                    {
                        string nombre = tablaDatos.Rows[0]["Nombre"].ToString();
                        string apellidoP = tablaDatos.Rows[0]["Apellido_P"].ToString();
                        string apellidoM = tablaDatos.Rows[0]["Apellido_M"].ToString();

                        txtNombrePaciente.Text = $"{nombre} {apellidoP} {apellidoM}";

                        tablaDatos.Columns.Remove("Nombre");
                        tablaDatos.Columns.Remove("Apellido_P");
                        tablaDatos.Columns.Remove("Apellido_M");

                        PerfilPaciente.DataSource = tablaDatos;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró al paciente en la base de datos.", "Aviso");
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el perfil: " + ex.Message, "Error");
                }
                finally
                {
                    conexionAbierta.Close();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(idPacienteActual))
            {
                // Reemplaza 'frmGeneracionReceta' por el nombre exacto de la clase de tu ventana de Recetas
                frmGeneracionReceta ventanaReceta = new frmGeneracionReceta();
                ventanaReceta.Show();

                // Le enviamos los datos guardados en el historial
                ventanaReceta.CargarDatosPaciente(this.idPacienteActual, this.tipoPacienteActual);
            }
            else
            {
                MessageBox.Show("No hay ningún paciente seleccionado actualmente.", "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ServiciosMedicos.GeneracionReceta.frmGeneracionReceta ventanaFormato = new ServiciosMedicos.GeneracionReceta.frmGeneracionReceta();

                ventanaFormato.Show();
                this.Hide();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("error");
            }
        }
    }
}
