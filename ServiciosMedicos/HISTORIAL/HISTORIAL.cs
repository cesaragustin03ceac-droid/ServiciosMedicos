using MySql.Data.MySqlClient;
using ServiciosMedicos.Busqueda;
using ServiciosMedicos.Consultas;
using ServiciosMedicos.DataConexion;
using ServiciosMedicos.GeneracionReceta;
using ServiciosMedicos.VistaPrevia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ServiciosMedicos.HISTORIAL
{
    public partial class HISTORIAL : Form
    {
        private string idPacienteActual;
        private string tipoPacienteActual;
        private string idExpedienteActual;

        public HISTORIAL()
        {
            InitializeComponent();
            EstilarDataGridView();
            groupBox1.Paint += DibujarBordeGrueso;
            groupBox2perfil.Paint += DibujarBordeGrueso;
            groupBox3atenciones.Paint += DibujarBordeGrueso;
            button1.Paint += DibujarBordeGrueso;
            button2.Paint += DibujarBordeGrueso;

            dataGridView1atenciones.CellContentClick += dataGridView1atenciones_CellContentClick;
        }

        private void EstilarDataGridView()
        {
            dataGridView1atenciones.Columns.Clear();
            dataGridView1atenciones.EnableHeadersVisualStyles = false;
            dataGridView1atenciones.AllowUserToResizeColumns = false;
            dataGridView1atenciones.AllowUserToResizeRows = false;
            dataGridView1atenciones.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#6FA8DC");
            dataGridView1atenciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1atenciones.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridView1atenciones.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1atenciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1atenciones.ColumnHeadersHeight = 35;
            dataGridView1atenciones.BackgroundColor = Color.White;
            dataGridView1atenciones.BorderStyle = BorderStyle.FixedSingle;
            dataGridView1atenciones.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1atenciones.GridColor = Color.Black;
            dataGridView1atenciones.RowHeadersVisible = false;
            dataGridView1atenciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1atenciones.AllowUserToAddRows = false;
            dataGridView1atenciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

            dataGridView1atenciones.Columns.Add("colIdConsulta", "ID");
            dataGridView1atenciones.Columns["colIdConsulta"].Visible = false;

            dataGridView1atenciones.Columns["colFecha"].FillWeight = 70;
            dataGridView1atenciones.Columns["colMotivo"].FillWeight = 90;
            dataGridView1atenciones.Columns["colDiagnostico"].FillWeight = 240;
            dataGridView1atenciones.Columns["colFormato"].FillWeight = 50;
            dataGridView1atenciones.Columns["colReceta"].FillWeight = 50;
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

        public void CargarPerfilPaciente(string idPaciente, string tipoPaciente)
        {
            this.idPacienteActual = idPaciente;
            this.tipoPacienteActual = tipoPaciente;
            this.idExpedienteActual = null;

            Conexion conexionBD = new Conexion();
            MySqlConnection conn = conexionBD.obtenerconexion();
            if (conn == null) return;

            try
            {
                string query = "";

                if (tipoPaciente == "Alumno")
                {
                    query = @"SELECT a.matricula AS id, a.nombre, a.apellido_p, a.apellido_m,
                                     ar.nombre_area, 
                                     e.id_expediente, e.edad, e.nss, e.curp, e.sexo, 
                                     e.tipo_sangre, e.peso, e.talla, e.alergias, 
                                     e.enfermedades, e.revision_ocular
                              FROM alumno a
                              LEFT JOIN areas ar ON a.id_area = ar.id_area
                              LEFT JOIN expediente e ON e.curp = a.matricula
                              WHERE a.matricula = @id
                              LIMIT 1;";
                }
                else
                {
                    query = @"SELECT t.num_trabajador AS id, t.nombre, t.apellido_p, t.apellido_m,
                                     ar.nombre_area, 
                                     e.id_expediente, e.edad, e.nss, e.curp, e.sexo, 
                                     e.tipo_sangre, e.peso, e.talla, e.alergias, 
                                     e.enfermedades, e.revision_ocular
                              FROM trabajador t
                              LEFT JOIN areas ar ON t.id_area = ar.id_area
                              LEFT JOIN expediente e ON e.curp = CAST(t.num_trabajador AS CHAR)
                              WHERE t.num_trabajador = @id
                              LIMIT 1;";
                }

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idPaciente);

                    using (MySqlDataReader lector = cmd.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            string nombre = lector["nombre"].ToString();
                            string apellidoP = lector["apellido_p"].ToString();
                            string apellidoM = lector["apellido_m"].ToString();
                            txtNombrePaciente.Text = $"{nombre} {apellidoP} {apellidoM}".Trim();

                            txtArea.Text = ValorO_Vacio(lector["nombre_area"]);
                            txtEdad.Text = ValorO_Vacio(lector["edad"]);

                            PerfilPaciente.Columns.Clear();
                            PerfilPaciente.AutoGenerateColumns = true;

                            DataTable dtPerfil = new DataTable();
                            dtPerfil.Columns.Add("Sexo");
                            dtPerfil.Columns.Add("NSS");
                            dtPerfil.Columns.Add("CURP");
                            dtPerfil.Columns.Add("Tipo de Sangre");
                            dtPerfil.Columns.Add("Peso");
                            dtPerfil.Columns.Add("Talla");
                            dtPerfil.Columns.Add("Alergias");
                            dtPerfil.Columns.Add("Enfermedades");
                            dtPerfil.Columns.Add("Revisión Ocular");

                            DataRow fila = dtPerfil.NewRow();
                            fila["Sexo"] = ValorO_Vacio(lector["sexo"]);
                            fila["NSS"] = ValorO_Vacio(lector["nss"]);
                            fila["CURP"] = ValorO_Vacio(lector["curp"]);
                            fila["Tipo de Sangre"] = ValorO_Vacio(lector["tipo_sangre"]);
                            fila["Peso"] = ValorO_Vacio(lector["peso"]);
                            fila["Talla"] = ValorO_Vacio(lector["talla"]);
                            fila["Alergias"] = ValorO_Vacio(lector["alergias"]);
                            fila["Enfermedades"] = ValorO_Vacio(lector["enfermedades"]);
                            fila["Revisión Ocular"] = ValorO_Vacio(lector["revision_ocular"]);
                            dtPerfil.Rows.Add(fila);

                            PerfilPaciente.DataSource = dtPerfil;
                            PerfilPaciente.ReadOnly = true;
                            PerfilPaciente.AllowUserToAddRows = false;
                            PerfilPaciente.RowHeadersVisible = false;
                            PerfilPaciente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            if (lector["id_expediente"] != DBNull.Value)
                                this.idExpedienteActual = lector["id_expediente"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el paciente.", "Aviso");
                        }
                    }
                }

                CargarAtenciones(idPaciente, tipoPaciente, conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar perfil: " + ex.Message, "Error");
            }
            finally
            {
                conn.Close();
            }
        }


        private void CargarAtenciones(string idPaciente, string tipoPaciente, MySqlConnection conn)
        {
            dataGridView1atenciones.Rows.Clear();

            string query = "";

            if (tipoPaciente == "Alumno")
            {
                query = @"SELECT c.id_consulta, c.fecha_consulta, e.motivo_consulta, d.diagnostico
                        FROM consulta c
                        LEFT JOIN diagnostico d ON c.id_consulta = d.id_consulta
                        LEFT JOIN expediente e ON d.id_expediente = e.id_expediente
                        WHERE c.matricula_alumno = @id
                        ORDER BY c.fecha_consulta DESC;";
            }
            else
            {
                query = @"SELECT c.id_consulta, c.fecha_consulta, e.motivo_consulta, d.diagnostico
                        FROM consulta c
                        LEFT JOIN diagnostico d ON c.id_consulta = d.id_consulta
                        LEFT JOIN expediente e ON d.id_expediente = e.id_expediente
                        WHERE c.num_trabajador = @id
                        ORDER BY c.fecha_consulta DESC;";
            }

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", idPaciente);

                using (MySqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string idConsulta = lector["id_consulta"] != DBNull.Value ? lector["id_consulta"].ToString() : "0";
                        string fecha = lector["fecha_consulta"] != DBNull.Value
                            ? Convert.ToDateTime(lector["fecha_consulta"]).ToString("yyyy-MM-dd")
                            : "";
                        string motivo = lector["motivo_consulta"] != DBNull.Value ? lector["motivo_consulta"].ToString() : "";
                        string diagnostico = lector["diagnostico"] != DBNull.Value ? lector["diagnostico"].ToString() : "";

                        dataGridView1atenciones.Rows.Add(fecha, motivo, diagnostico, "Ver", "Ver", idConsulta);
                    }
                }
            }
        }

        private void dataGridView1atenciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView1atenciones.Columns[e.ColumnIndex].Name == "colReceta")
            {
                string idConsulta = dataGridView1atenciones.Rows[e.RowIndex].Cells["colIdConsulta"].Value?.ToString();

                if (!string.IsNullOrEmpty(idConsulta) && idConsulta != "0")
                {
                    VerRecetaGuardada(idConsulta);
                }
                else
                {
                    MessageBox.Show("No se encontró el identificador de la consulta.", "Error");
                }
            }
        }

        
        private void VerRecetaGuardada(string idConsulta)
        {
            Conexion conexionBD = new Conexion();
            MySqlConnection conn = conexionBD.obtenerconexion();
            if (conn == null) return;

            try
            {
                string queryReceta = @"SELECT r.id_receta, r.dia, r.mes, r.anio 
                                       FROM receta r
                                       INNER JOIN diagnostico d ON r.id_diagnostico = d.id_diagnostico
                                       WHERE d.id_consulta = @idConsulta
                                       LIMIT 1";

                int idReceta = 0;
                int dia = 0, mes = 0, anio = 0;
                bool recetaEncontrada = false;

                using (MySqlCommand cmd = new MySqlCommand(queryReceta, conn))
                {
                    cmd.Parameters.AddWithValue("@idConsulta", Convert.ToInt32(idConsulta));
                    using (MySqlDataReader lector = cmd.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            idReceta = Convert.ToInt32(lector["id_receta"]);
                            dia = Convert.ToInt32(lector["dia"]);
                            mes = Convert.ToInt32(lector["mes"]);
                            anio = Convert.ToInt32(lector["anio"]);
                            recetaEncontrada = true;
                        }
                    }
                }

                if (!recetaEncontrada)
                {
                    MessageBox.Show("Esta consulta no tiene receta guardada.", "Sin receta");
                    return;
                }

                var listaMedicamentos = new List<frmGeneracionReceta.MedicamentoReceta>();

                string queryMed = @"SELECT dm.nombre_medicamento, dm.cant_medicamento, dm.indicaciones
                                    FROM detallemedicamento dm
                                    WHERE dm.id_receta = @idReceta";

                using (MySqlCommand cmd = new MySqlCommand(queryMed, conn))
                {
                    cmd.Parameters.AddWithValue("@idReceta", idReceta);
                    using (MySqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            var med = new frmGeneracionReceta.MedicamentoReceta
                            {
                                Nombre = lector["nombre_medicamento"].ToString(),
                                Cantidad = lector["cant_medicamento"].ToString(),
                                Indicaciones = lector["indicaciones"].ToString()
                            };
                            listaMedicamentos.Add(med);
                        }
                    }
                }

                if (listaMedicamentos.Count == 0)
                {
                    MessageBox.Show("La receta no contiene medicamentos.", "Receta vacía");
                    return;
                }

                string nombreDoctora = frmBusquedaAlumnos.UsuarioNombre;
                string cedulaDoctora = frmBusquedaAlumnos.UsuarioId;
                string nombrePaciente = txtNombrePaciente.Text.Trim();
                string matricula = idPacienteActual;
                string area = txtArea.Text.Trim();

                string edad = txtEdad.Text.Trim();
                string sexo = "";
                if (PerfilPaciente.Rows.Count > 0)
                {
                    sexo = PerfilPaciente.Rows[0].Cells["Sexo"].Value?.ToString() ?? "";
                }
                string fecha = new DateTime(anio, mes, dia).ToString("dd/MM/yyyy");

                frmVistaPrevia vista = new frmVistaPrevia();
                vista.CargarDatos(
                    nombreDoctora,
                    cedulaDoctora,
                    nombrePaciente,
                    matricula,
                    area,
                    edad,
                    sexo,
                    fecha,
                    listaMedicamentos
                );
                vista.PassDatosPaciente(this.idPacienteActual, this.tipoPacienteActual);

                vista.FormClosed += (s, ev) => this.Show();
                vista.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la receta: " + ex.Message, "Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private string ValorO_Vacio(object valor)
        {
            return valor != DBNull.Value ? valor.ToString() : "";
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idPacienteActual) || string.IsNullOrEmpty(tipoPacienteActual))
            {
                MessageBox.Show("No hay paciente cargado para editar.", "Aviso");
                return;
            }

            AgregarPaciente ventana = new AgregarPaciente(idPacienteActual, tipoPacienteActual);
            ventana.Show();
            this.Close();
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

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            frmBusquedaAlumnos busqueda = new frmBusquedaAlumnos();
            busqueda.Show();
            this.Close();
        }

        private void HISTORIAL_Load(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }
    }
}