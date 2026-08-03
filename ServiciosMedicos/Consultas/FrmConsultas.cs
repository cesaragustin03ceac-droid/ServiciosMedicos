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
            btnReceta.Hide(); 

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

            cboSintomas.Items.Clear();
            cboSintomas.Items.Add("Fiebre");
            cboSintomas.Items.Add("Tos");
            cboSintomas.Items.Add("Dolor de cabeza");
            cboSintomas.Items.Add("Nauseas");
            cboSintomas.Items.Add("Otro");
            cboSintomas.SelectedIndex = -1;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string motivoFinal = !string.IsNullOrWhiteSpace(txtMotivo.Text) ? txtMotivo.Text.Trim() : CboMotivo.SelectedItem?.ToString();
            string diagnosticoFinal = !string.IsNullOrWhiteSpace(TxtDiagnostico.Text) ? TxtDiagnostico.Text.Trim() : cboDiagnostico.SelectedItem?.ToString();

            string antecedentes = txtMalestarA.Text.Trim();
            string presion = txtPrecion.Text.Trim();
            string temperatura = txtTemperatura.Text.Trim();

            if (string.IsNullOrEmpty(motivoFinal) || string.IsNullOrEmpty(diagnosticoFinal))
            {
                MessageBox.Show("Motivo y Diagnostico son obligatorios.", "Campos Incompletos");
                return;
            }

            Conexion conexionBD = new Conexion();
            MySqlConnection conn = conexionBD.obtenerconexion();
            if (conn == null) return;

            MySqlTransaction trans = null;

            try
            {
                trans = conn.BeginTransaction();

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
                    throw new Exception("El paciente no tiene expediente. Creelo primero en Agregar Paciente.");
                }

                string queryConsulta = @"INSERT INTO consulta 
                    (fecha_consulta, matricula_alumno, num_trabajador, cedula_doctora, id_enfermera, presion, temperatura) 
                    VALUES 
                    (CURDATE(), @matAlu, @numTrab, NULL, NULL, @presion, @temperatura);";

                long idConsulta = 0;

                using (MySqlCommand cmd = new MySqlCommand(queryConsulta, conn, trans))
                {
                    cmd.Parameters.AddWithValue("@matAlu", tipoPaciente == "Alumno" ? idPaciente : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@numTrab", tipoPaciente == "Trabajador" ? Convert.ToInt32(idPaciente) : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@presion", string.IsNullOrEmpty(presion) ? (object)DBNull.Value : presion);
                    cmd.Parameters.AddWithValue("@temperatura", string.IsNullOrEmpty(temperatura) ? (object)DBNull.Value : temperatura);
                    cmd.ExecuteNonQuery();
                    idConsulta = cmd.LastInsertedId;
                }

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

                string queryUpdateExp = @"UPDATE expediente 
                    SET motivo_consulta = @motivo, antecedentes = @antecedentes 
                    WHERE id_expediente = @idExp;";

                using (MySqlCommand cmd = new MySqlCommand(queryUpdateExp, conn, trans))
                {
                    cmd.Parameters.AddWithValue("@motivo", motivoFinal);
                    cmd.Parameters.AddWithValue("@antecedentes", string.IsNullOrEmpty(antecedentes) ? (object)DBNull.Value : antecedentes);
                    cmd.Parameters.AddWithValue("@idExp", idExpediente);
                    cmd.ExecuteNonQuery();
                }

                trans.Commit();
                MessageBox.Show("Consulta guardada correctamente.", "Exito");
                btnReceta.Show();
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            HISTORIAL.HISTORIAL frmhistorial = new HISTORIAL.HISTORIAL();
            frmhistorial.CargarPerfilPaciente(this.idPaciente, this.tipoPaciente);
            frmhistorial.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                frmGeneracionReceta ventana = new frmGeneracionReceta();
                ventana.PassDatosPaciente(this.idPaciente, this.tipoPaciente);
                ventana.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

      

        private void cboDiagnostico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDiagnostico.SelectedItem?.ToString() == "Otro")
            {
                TxtDiagnostico.ReadOnly = false;
            }
            else
            {
                TxtDiagnostico.Clear();
                TxtDiagnostico.ReadOnly = true;
            }
        }

        private void cboSintomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSintomas.SelectedItem?.ToString() == "Otro")
            {
                txtSintomas.ReadOnly = false;
            }
            else
            {
                txtSintomas.Clear();
                txtSintomas.ReadOnly = true;
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
            }
        }

        private void btnEditar_Click(object sender, EventArgs e) { }
        private void txtMotivo_TextChanged(object sender, EventArgs e) { }

        private void CboMotivo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CboMotivo.SelectedItem?.ToString() == "Otro")
            {
                txtMotivo.ReadOnly = false;
            }
            else
            {
                txtMotivo.Clear();
                txtMotivo.ReadOnly = true;
            }
        }
    }
}