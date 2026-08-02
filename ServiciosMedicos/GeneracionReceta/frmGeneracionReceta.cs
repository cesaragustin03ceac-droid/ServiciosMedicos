using MySql.Data.MySqlClient;
using ServiciosMedicos.Busqueda;
using ServiciosMedicos.Consultas;
using ServiciosMedicos.DataConexion;
using ServiciosMedicos.VistaPrevia;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

    namespace ServiciosMedicos.GeneracionReceta
    {
        public partial class frmGeneracionReceta : Form
        {
            public class MedicamentoReceta
            {
                public int IdMedicamento { get; set; }
                public string Nombre { get; set; }
                public string Cantidad { get; set; }
                public string Indicaciones { get; set; }
            }

            private List<MedicamentoReceta> listaMedicamentos = new List<MedicamentoReceta>();

            private string idPaciente;
            private string tipoPaciente;
            private string edadPaciente;
            private string sexoPaciente;
            private string areaPaciente;


            public void PassDatosPaciente(string id, string tipo)
            {
                this.idPaciente = id;
                this.tipoPaciente = tipo;
                
            }

            public frmGeneracionReceta()
            {
                InitializeComponent();
                btonCancelar.Paint += DibujarBordeGrueso;
                btnGuardar.Paint += DibujarBordeGrueso;
                btnVistaPrevia.Paint += DibujarBordeGrueso;
                btnImprimir.Paint += DibujarBordeGrueso;
                groupBox2.Paint += DibujarBordeGrueso;
                groupBox3.Paint += DibujarBordeGrueso;
                FechaConsulta();
                dgvMedicamentos.DataError += (s, ev) => { ev.ThrowException = false; };
            }

            public void FechaConsulta()
            {
                txtFecha.Text = DateTime.Now.ToString();
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

            private void CargarDatosPacienteEnReceta() 
            {
                Conexion conexionBD = new Conexion();
                MySqlConnection conexionAbierta = conexionBD.obtenerconexion();
                if (conexionAbierta != null)
                {
                    try
                    {
                        string query = "";

                        if (tipoPaciente == "Alumno")
                        {
                            query = @"SELECT  c.Matricula_Alumno AS MatriculaFinal,ar.nombre_area AS Area, e.edad AS Edad, e.sexo AS Sexo,  CONCAT(a.Nombre, ' ', a.Apellido_P, ' ', a.Apellido_M) AS NombreCompleto
                            FROM consulta c LEFT JOIN alumno a ON c.Matricula_Alumno = a.Matricula
                            LEFT JOIN areas ar ON a.id_area = ar.id_area
                            LEFT JOIN expediente e ON e.curp = a.matricula
                        
                            WHERE c.Matricula_Alumno = @id;";
                        }
                        else if (tipoPaciente == "Trabajador")
                        {
                            query = @"SELECT  c.Num_Trabajador  AS MatriculaFinal, ar.nombre_area AS Area, e.edad AS Edad, e.sexo AS Sexo, CONCAT(t.Nombre, ' ', t.Apellido_P , ' ', t.Apellido_M ) AS NombreCompleto          
                            FROM consulta c LEFT JOIN trabajador t ON c.Num_Trabajador = t.Num_Trabajador
                            LEFT JOIN areas ar ON t.id_area = ar.id_area
                            LEFT JOIN expediente e ON e.curp = t.Num_Trabajador
                        
                            WHERE c.Num_Trabajador = @id;";
                        }
                        using (MySqlCommand cmd = new MySqlCommand(query, conexionAbierta))
                        {
                            cmd.Parameters.AddWithValue("@id", idPaciente);
                            using (MySqlDataReader lector = cmd.ExecuteReader())
                            {
                                if (lector.Read())
                                {
                                    txtMatricula.Text = lector["MatriculaFinal"].ToString();
                                    txtNombre.Text = lector["NombreCompleto"].ToString();
                                    this.areaPaciente = lector["Area"].ToString();
                                    this.edadPaciente = lector["Edad"].ToString();
                                    this.sexoPaciente = lector["Sexo"].ToString();

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar los datos del paciente para la receta: " + ex.Message, "Error");
                    }
                    finally
                    {
                        conexionAbierta.Close();
                    }
                }
            }

            private void btnAgregar_Click(object sender, EventArgs e)
            {
                Medicamentos frmmedicamento = new Medicamentos();
                if (frmmedicamento.ShowDialog() == DialogResult.OK)
                {
                    MedicamentoReceta med = new MedicamentoReceta
                    {
                        IdMedicamento = frmmedicamento.IdMedicamento,
                        Nombre = frmmedicamento.Medicamento,
                        Cantidad = frmmedicamento.Cantidad,
                        Indicaciones = frmmedicamento.Indicaciones
                    };
                    listaMedicamentos.Add(med);
                    dgvMedicamentos.Rows.Add(med.Nombre, med.Indicaciones);
                }
            }

            private void dgvMedicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0 && dgvMedicamentos.Columns[e.ColumnIndex].Name == "colEliminar")
                {
                    if (!dgvMedicamentos.Rows[e.RowIndex].IsNewRow)
                    {
                        listaMedicamentos.RemoveAt(e.RowIndex);
                        dgvMedicamentos.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }

            private void btnGuardar_Click(object sender, EventArgs e)
            {
                if (listaMedicamentos.Count == 0)
                {
                    MessageBox.Show("Agregue al menos un medicamento");
                    return;
                }

                Conexion conexionBD = new Conexion();
                MySqlConnection conexionAbierta = conexionBD.obtenerconexion();
                if (conexionAbierta == null) return;

                MySqlTransaction transaccion = null;

                try
                {
                    transaccion = conexionAbierta.BeginTransaction();

                    string queryDiag = @"SELECT d.id_diagnostico 
                                         FROM diagnostico d 
                                         INNER JOIN consulta c ON d.id_consulta = c.id_consulta 
                                         WHERE c.matricula_alumno = @mat 
                                         ORDER BY c.id_consulta DESC LIMIT 1";
                    int idDiagnostico = 0;
                    using (MySqlCommand cmd = new MySqlCommand(queryDiag, conexionAbierta, transaccion))
                    {
                        cmd.Parameters.AddWithValue("@mat", txtMatricula.Text);
                        object res = cmd.ExecuteScalar();
                        if (res != null) idDiagnostico = Convert.ToInt32(res);
                    }

                    if (idDiagnostico == 0)
                    {
                        MessageBox.Show("No se encontro diagnostico");
                        transaccion.Rollback();
                        return;
                    }

                    DateTime fecha = DateTime.Now;
                    string queryReceta = "INSERT INTO receta (dia, mes, anio, id_diagnostico) VALUES (@dia, @mes, @anio, @idDiag)";
                    int idReceta = 0;
                    using (MySqlCommand cmd = new MySqlCommand(queryReceta, conexionAbierta, transaccion))
                    {
                        cmd.Parameters.AddWithValue("@dia", fecha.Day);
                        cmd.Parameters.AddWithValue("@mes", fecha.Month);
                        cmd.Parameters.AddWithValue("@anio", fecha.Year);
                        cmd.Parameters.AddWithValue("@idDiag", idDiagnostico);
                        cmd.ExecuteNonQuery();
                        idReceta = (int)cmd.LastInsertedId;
                    }

                    foreach (MedicamentoReceta med in listaMedicamentos)
                    {
                        int idMed = med.IdMedicamento;
                        string cant = med.Cantidad;
                        string ind = med.Indicaciones;

                        string queryDet = "INSERT INTO detallemedicamento (id_receta, id_medicamento, nombre_medicamento, cant_medicamento, indicaciones) VALUES (@idRec, @idMed, @med, @cant, @ind)";
                        using (MySqlCommand cmd = new MySqlCommand(queryDet, conexionAbierta, transaccion))
                        {
                            cmd.Parameters.AddWithValue("@idRec", idReceta);
                            cmd.Parameters.AddWithValue("@idMed", idMed);
                            cmd.Parameters.AddWithValue("@med", med.Nombre);
                            cmd.Parameters.AddWithValue("@cant", cant);
                            cmd.Parameters.AddWithValue("@ind", ind);
                            cmd.ExecuteNonQuery();
                        }

                        int cantidadDar = 0;
                        int.TryParse(cant, out cantidadDar);

                        string queryStock = "SELECT cantidad FROM inventario WHERE id_medicamento = @idMed";
                        using (MySqlCommand cmdStock = new MySqlCommand(queryStock, conexionAbierta, transaccion))
                        {
                            cmdStock.Parameters.AddWithValue("@idMed", idMed);
                            object resStock = cmdStock.ExecuteScalar();
                            int stock = resStock != null ? Convert.ToInt32(resStock) : 0;

                            int nuevoStock = stock - cantidadDar;
                            if (nuevoStock < 0) nuevoStock = 0;
                            string queryUpd = "UPDATE inventario SET cantidad = @nuevo WHERE id_medicamento = @idMed";
                            using (MySqlCommand cmdUpd = new MySqlCommand(queryUpd, conexionAbierta, transaccion))
                            {
                                cmdUpd.Parameters.AddWithValue("@nuevo", nuevoStock);
                                cmdUpd.Parameters.AddWithValue("@idMed", idMed);
                                cmdUpd.ExecuteNonQuery();
                            }
                        }
                    }

                    transaccion.Commit();
                    MessageBox.Show("Receta guardada correctamente");
                    listaMedicamentos.Clear();
                    dgvMedicamentos.Rows.Clear();
                }
                catch (Exception ex)
                {
                    transaccion?.Rollback();
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
                finally
                {
                    conexionAbierta.Close();
                }
            }

            private void frmGeneracionReceta_Load(object sender, EventArgs e)
            {
                CargarDatosPacienteEnReceta();
            }

            private void btnCancelar_Click(object sender, EventArgs e)
            {
                FrmConsultas frmcondultas = new FrmConsultas();
                frmcondultas.PassDatosPaciente(this.idPaciente, this.tipoPaciente);  
                frmcondultas.Show();
                this.Close();
            }

            private void BtnAtras_Click(object sender, EventArgs e)
            {
                FrmConsultas frmcondultas = new FrmConsultas();
                frmcondultas.Show();
                frmcondultas.PassDatosPaciente(this.idPaciente, this.tipoPaciente);  

                this.Close();
            }

            private void txtNombre_TextChanged(object sender, EventArgs e)
            {
            }



        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            // Validar medicamentos
            if (listaMedicamentos == null || listaMedicamentos.Count == 0)
            {
                MessageBox.Show("Agregue al menos un medicamento.", "Sin medicamentos");
                return;
            }

            // Datos de la doctora (del login)
            string nombreDoctora = frmBusquedaAlumnos.UsuarioNombre;
            string cedulaDoctora = frmBusquedaAlumnos.UsuarioId;

            // Datos del paciente
            string nombrePaciente = txtNombre.Text.Trim();
            string matricula = txtMatricula.Text.Trim();
            string area = areaPaciente ?? "";
            string edad = edadPaciente ?? "";
            string sexo = sexoPaciente ?? "";
            string fecha = txtFecha.Text.Trim();

            // CONSTRUCTOR VACÍO + MÉTODO CargarDatos
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
                listaMedicamentos    // ← Ahora sí: mismo tipo público
            );
            vista.PassDatosPaciente(this.idPaciente, this.tipoPaciente);


            vista.FormClosed += (s, ev) => this.Show();
            vista.Show();
            this.Hide();
        }
    }
    }