using MySql.Data.MySqlClient;
using ServiciosMedicos.Consultas;
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
            btnGuardar.Paint += DibujarBordeGrueso;

        }
        private void EstilarDataGridView()
        {
            // Limpiamos la tabla y desactivamos estilos de Windows
            dataGridView1atenciones.Columns.Clear();
            dataGridView1atenciones.EnableHeadersVisualStyles = false;

            // Bloqueamos la modificación manual de tamaños
            dataGridView1atenciones.AllowUserToResizeColumns = false;
            dataGridView1atenciones.AllowUserToResizeRows = false;

            // Color Azul de la Guía de Estilos (#6FA8DC) y formato de encabezados
            dataGridView1atenciones.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#6FA8DC");
            dataGridView1atenciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1atenciones.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridView1atenciones.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1atenciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1atenciones.ColumnHeadersHeight = 35;

            //  Formato general de celdas y rejilla
            dataGridView1atenciones.BackgroundColor = Color.White;
            dataGridView1atenciones.BorderStyle = BorderStyle.FixedSingle;
            dataGridView1atenciones.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1atenciones.GridColor = Color.Black;
            dataGridView1atenciones.RowHeadersVisible = false;
            dataGridView1atenciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1atenciones.AllowUserToAddRows = false;

            // Crear las 3 columnas de texto normales
            dataGridView1atenciones.Columns.Add("colFecha", "Fecha");
            dataGridView1atenciones.Columns.Add("colMotivo", "Motivo");
            dataGridView1atenciones.Columns.Add("colDiagnostico", "Diagnostico");

            // Crear las columnas de tipo Enlace (Links)
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

            // Activamos el relleno automático para abarcar todo el ancho
            dataGridView1atenciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Asignamos el porcentaje de ancho a cada columna 
            dataGridView1atenciones.Columns["colFecha"].FillWeight = 70;
            dataGridView1atenciones.Columns["colMotivo"].FillWeight = 90;
            dataGridView1atenciones.Columns["colDiagnostico"].FillWeight = 240; // Se lleva casi la mitad de la tabla
            dataGridView1atenciones.Columns["colFormato"].FillWeight = 50;     // Queda pequeño solo para "Ver"
            dataGridView1atenciones.Columns["colReceta"].FillWeight = 50;      // Queda pequeño solo para "Ver"
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

                    dataGridView1atenciones.Rows.Clear();

                    string queryAtenciones = "";

                    if (tipoPaciente == "Alumno")
                    {
                        queryAtenciones = @"SELECT c.Fecha AS FechaConsulta, e.Motivo_Consulta AS Motivo, d.Diagnostico AS Diagnostico                        
                        FROM Consulta c                  
                        LEFT JOIN Diagnostico d ON c.Id_Diagnostico = d.Id_Diagnostico                  
                        LEFT JOIN Expediente e ON d.Id_Expediente = e.Id_Expediente
                        WHERE c.Matricula_Alumno = @id
                        ORDER BY c.Fecha DESC;";
                    }
                    else if (tipoPaciente == "Trabajador")
                    {
                        queryAtenciones = @"SELECT c.Fecha AS FechaConsulta, e.Motivo_Consulta AS Motivo, d.Diagnostico AS Diagnostico                        
                        FROM Consulta c                  
                        LEFT JOIN Diagnostico d ON c.Id_Diagnostico = d.Id_Diagnostico                  
                        LEFT JOIN Expediente e ON d.Id_Expediente = e.Id_Expediente
                        WHERE c.Num_Trabajador = @id
                        ORDER BY c.Fecha DESC;";
                    }

                    using (MySqlCommand cmdAtenciones = new MySqlCommand(queryAtenciones, conexionAbierta))
                    {
                        cmdAtenciones.Parameters.AddWithValue("@id", idPaciente);

                        using (MySqlDataReader lector = cmdAtenciones.ExecuteReader())
                        {
                            while (lector.Read())
                            {

                                string fecha = lector["FechaConsulta"] != DBNull.Value ? Convert.ToDateTime(lector["FechaConsulta"]).ToString("yyyy-MM-dd") : "";
                                string motivo = lector["Motivo"] != DBNull.Value ? lector["Motivo"].ToString() : "";
                                string diagnostico = lector["Diagnostico"] != DBNull.Value ? lector["Diagnostico"].ToString() : "";

                                dataGridView1atenciones.Rows.Add(fecha, motivo, diagnostico, "Ver", "Ver");

                            }
                        }
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


        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                FrmConsultas ventanaConsulta = new FrmConsultas();
                ventanaConsulta.PassDatosPaciente(this.idPacienteActual, this.tipoPacienteActual);

                ventanaConsulta.Show();

                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la consulta: " + ex.Message, "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PerfilPaciente.ReadOnly = false;

            if (PerfilPaciente.Rows.Count > 0)
            {
                PerfilPaciente.CurrentCell = PerfilPaciente.Rows[0].Cells[0];
                PerfilPaciente.BeginEdit(true);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (PerfilPaciente.Rows.Count > 0)
            {
                DataGridViewRow fila = PerfilPaciente.Rows[0];

                string tipoSangre = fila.Cells["Tipo de Sangre"].Value?.ToString().Trim();
                string alergias = fila.Cells["Alergias"].Value?.ToString().Trim();
                string enfermedades = fila.Cells["Enfermedades Crónicas"].Value?.ToString().Trim();
                string peso = fila.Cells["Peso"].Value?.ToString().Trim();
                string talla = fila.Cells["Talla"].Value?.ToString().Trim();

                Conexion conexionBD = new Conexion();
                MySqlConnection conexionAbierta = conexionBD.obtenerconexion();

                if (conexionAbierta != null)
                {
                    try
                    {
                        string queryUpdate = @"UPDATE Expediente e
                       INNER JOIN Diagnostico d ON e.Id_Expediente = d.Id_Expediente
                       INNER JOIN Consulta c ON d.Id_Diagnostico = c.Id_Diagnostico
                       SET e.TipoSangre = @sangre, 
                           e.Alergias = @alergias, 
                           e.Enfermedades = @enfermedades, 
                           e.Peso = @peso, 
                           e.Talla = @talla 
                       WHERE c.Matricula_Alumno = @mat OR c.Num_Trabajador = @mat";
                        using (MySqlCommand comando = new MySqlCommand(queryUpdate, conexionAbierta))
                        {
                            comando.Parameters.AddWithValue("@sangre", tipoSangre);
                            comando.Parameters.AddWithValue("@alergias", alergias);
                            comando.Parameters.AddWithValue("@enfermedades", enfermedades);
                            comando.Parameters.AddWithValue("@peso", peso);
                            comando.Parameters.AddWithValue("@talla", talla);
                            comando.Parameters.AddWithValue("@mat", idPacienteActual);

                            int filasAfectadas = comando.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Expediente actualizado y guardado correctamente.", "Éxito");
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el registro para actualizar.", "Aviso");
                            }

                            PerfilPaciente.ReadOnly = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar: " + ex.Message, "Error");
                    }
                    finally
                    {
                        conexionAbierta.Close();
                    }
                }
            }
        }
    }
}
