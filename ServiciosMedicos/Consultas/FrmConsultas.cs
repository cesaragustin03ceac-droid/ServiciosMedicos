using MySql.Data.MySqlClient;
using ServiciosMedicos.Busqueda;
using ServiciosMedicos.DataConexion;
using ServiciosMedicos.GeneracionReceta;
using ServiciosMedicos.HISTORIAL;
using System;
using System.Windows.Forms;

namespace ServiciosMedicos.Consultas
{
    public partial class FrmConsultas : Form
    {
        private string idPaciente;
        private string tipoPaciente;

        public FrmConsultas()
        {
            InitializeComponent();
            CargarOpcionesGenerales();
        }

        private void CargarOpcionesGenerales()
        {
            CboMotivo.Items.Clear();
            CboMotivo.Items.Add("Chequeo general de rutina");
            CboMotivo.Items.Add("Malestar general");
            CboMotivo.Items.Add("Dolor");
            CboMotivo.Items.Add("Otro");
            CboMotivo.SelectedIndex = -1;

            cboDiagnostico.Items.Clear();
            cboDiagnostico.Items.Add("Infeccion de estomago");
            cboDiagnostico.Items.Add("Resfriado comun");
            cboDiagnostico.Items.Add("Gastroenteritis aguda");
            cboDiagnostico.Items.Add("Otro");
            cboDiagnostico.SelectedIndex = -1;
        }

        public void PassDatosPaciente(string id, string tipo)
        {
            this.idPaciente = id;
            this.tipoPaciente = tipo;
            CargarNombrePaciente();
        }

        private void CargarNombrePaciente()
        {
            if (string.IsNullOrEmpty(idPaciente)) return;

            Conexion conexionBD = new Conexion();
            MySqlConnection conn = conexionBD.obtenerconexion();
            if (conn == null) return;

            try
            {
                string query = tipoPaciente == "Alumno"
                    ? "SELECT nombre, apellido_p, apellido_m FROM alumno WHERE matricula = @id LIMIT 1;"
                    : "SELECT nombre, apellido_p, apellido_m FROM trabajador WHERE num_trabajador = @id LIMIT 1;";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idPaciente);
                    using (MySqlDataReader lector = cmd.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            string nombre = $"{lector["nombre"]} {lector["apellido_p"]} {lector["apellido_m"]}".Trim();
                            this.Text = $"Consulta - {nombre}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar paciente: " + ex.Message, "Error");
            }
            finally
            {
                conn.Close();
            }
        }

        // ============================================================
        // GUARDAR: Solo Motivo y Diagnostico
        // ============================================================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string motivoFinal = !string.IsNullOrWhiteSpace(txtMotivo.Text) ? txtMotivo.Text.Trim() : CboMotivo.SelectedItem?.ToString();
            string diagnosticoFinal = !string.IsNullOrWhiteSpace(TxtDiagnostico.Text) ? TxtDiagnostico.Text.Trim() : cboDiagnostico.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(motivoFinal) || string.IsNullOrEmpty(diagnosticoFinal))
            {
                MessageBox.Show("Motivo y Diagnóstico son obligatorios.", "Campos Incompletos");
                return;
            }

            Conexion conexionBD = new Conexion();
            MySqlConnection conn = conexionBD.obtenerconexion();
            if (conn == null) return;

            MySqlTransaction trans = null;

            try
            {
                trans = conn.BeginTransaction();

                // 1. BUSCAR EXPEDIENTE POR CURP
                int idExpediente = 0;
                string queryBuscarExp = "SELECT id_expediente FROM expediente WHERE curp = @id LIMIT 1;";

                using (MySqlCommand cmd = new MySqlCommand(queryBuscarExp, conn, trans))
                {
                    cmd.Parameters.AddWithValue("@id", idPaciente);
                    object resultado = cmd.ExecuteScalar();
                    if (resultado != null && resultado != DBNull.Value)
                        idExpediente = Convert.ToInt32(resultado);
                }

                if (idExpediente == 0)
                {
                    throw new Exception("El paciente no tiene expediente. Créalo primero en Agregar Paciente.");
                }

                // 2. INSERTAR CONSULTA (primero, porque diagnostico la necesita)
                string queryConsulta = @"INSERT INTO consulta 
                    (fecha_consulta, matricula_alumno, num_trabajador, cedula_doctora, id_enfermera) 
                    VALUES 
                    (CURDATE(), @matAlu, @numTrab, NULL, NULL);";

                long idConsulta = 0;

                using (MySqlCommand cmd = new MySqlCommand(queryConsulta, conn, trans))
                {
                    cmd.Parameters.AddWithValue("@matAlu", tipoPaciente == "Alumno" ? idPaciente : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@numTrab", tipoPaciente == "Trabajador" ? Convert.ToInt32(idPaciente) : (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                    idConsulta = cmd.LastInsertedId;
                }

                // 3. INSERTAR DIAGNOSTICO (apuntando a la consulta y al expediente)
                string queryDiag = @"INSERT INTO diagnostico 
                    (diagnostico, id_consulta, id_expediente) 
                    VALUES 
                    (@diag, @idCon, @idExp);";

                using (MySqlCommand cmd = new MySqlCommand(queryDiag, conn, trans))
                {
                    cmd.Parameters.AddWithValue("@diag", diagnosticoFinal);
                    cmd.Parameters.AddWithValue("@idCon", idConsulta);
                    cmd.Parameters.AddWithValue("@idExp", idExpediente);
                    cmd.ExecuteNonQuery();
                }

                // 4. ACTUALIZAR MOTIVO EN EXPEDIENTE
                string queryUpdateExp = "UPDATE expediente SET motivo_consulta = @motivo WHERE id_expediente = @idExp;";

                using (MySqlCommand cmd = new MySqlCommand(queryUpdateExp, conn, trans))
                {
                    cmd.Parameters.AddWithValue("@motivo", motivoFinal);
                    cmd.Parameters.AddWithValue("@idExp", idExpediente);
                    cmd.ExecuteNonQuery();
                }

                trans.Commit();
                MessageBox.Show("Consulta guardada correctamente.", "Éxito");
            }
            catch (Exception ex)
            {
                trans?.Rollback();
                MessageBox.Show("Error al guardar: " + ex.Message, "Error");
            }
            finally
            {
                conn.Close();
            }
        }

        // ============================================================
        // BOTÓN ATRÁS → REGRESA AL HISTORIAL
        // ============================================================
        private void btnAtras_Click(object sender, EventArgs e)
        {
          
        }

        // ============================================================
        // BOTÓN IR A RECETA
        // ============================================================
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                frmGeneracionReceta ventana = new frmGeneracionReceta();
                ventana.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        // ============================================================
        // EVENTOS COMBOS "OTRO"
        // ============================================================
        private void CboMotivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboMotivo.Text == "Otro")
                txtMotivo.ReadOnly = false;
            else
            {
                txtMotivo.Clear();
                txtMotivo.ReadOnly = true;
            }
        }

        private void cboDiagnostico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDiagnostico.Text == "Otro")
                TxtDiagnostico.ReadOnly = false;
            else
            {
                TxtDiagnostico.Clear();
                TxtDiagnostico.ReadOnly = true;
            }
        }

        private void FrmConsultas_Load(object sender, EventArgs e)
        {
            if (frmBusquedaAlumnos.UsuarioTipo != null && frmBusquedaAlumnos.UsuarioTipo.Trim().ToLower() == "enfermera")
            {
                btnReceta.Enabled = false;
                btnReceta.Visible = false;
            }
            else
            {
                btnReceta.Enabled = true;
                btnReceta.Visible = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e) { }
        private void txtMotivo_TextChanged(object sender, EventArgs e) { }
        private void cboSintomas_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}