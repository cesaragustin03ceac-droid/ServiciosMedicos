using MySql.Data.MySqlClient;
using ServiciosMedicos.Consultas;
using ServiciosMedicos.DataConexion;
using System;
using System.Windows.Forms;

namespace ServiciosMedicos.Busqueda
{
    public partial class AgregarPaciente : Form
    {
        // === DATOS DEL PACIENTE ===
        private string idPaciente;
        private string tipoPaciente;
        private bool expedienteExiste;
        private bool esNuevoPaciente;

        // === CONSTRUCTORES ===
        public AgregarPaciente()
        {
            InitializeComponent();
            esNuevoPaciente = true;
            this.Load += AgregarPaciente_Load;
            txtCURP.Hide();
            lblCURP.Hide();
        }

        public AgregarPaciente(string id, string tipo)
        {
            InitializeComponent();
            idPaciente = id;
            tipoPaciente = tipo;
            esNuevoPaciente = false;
            this.Load += AgregarPaciente_Load;
        }

        // === AL ABRIR LA VENTANA ===
        private void AgregarPaciente_Load(object sender, EventArgs e)
        {
            LlenarComboBoxes();

            if (esNuevoPaciente)
                ModoNuevoPaciente();
            else
                ModoEditarPaciente();
        }

        // === MODO NUEVO PACIENTE ===
        private void ModoNuevoPaciente()
        {
            LimpiarCampos();
            HabilitarCampos();
            btnGuardar.Show();
            btnEditar.Hide();
            btnEliminar.Hide();
            txtID.ReadOnly = false;
        }

        // === MODO EDITAR PACIENTE ===
        private void ModoEditarPaciente()
        {
            CargarDatosPaciente();
            DeshabilitarCampos();
            btnGuardar.Hide();
            btnEditar.Show();
            btnEliminar.Show();
        }

        // === RELLENA LAS LISTAS DESPLEGABLES ===
        private void LlenarComboBoxes()
        {
            cboTipo.Items.Clear();
            cboTipo.Items.Add("Alumno");
            cboTipo.Items.Add("Trabajador");

            cboSexo.Items.Clear();
            cboSexo.Items.Add("Masculino");
            cboSexo.Items.Add("Femenino");

            cboTipoSangre.Items.Clear();
            cboTipoSangre.Items.AddRange(new[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });

            cboRevicionOcular.Items.Clear();
            cboRevicionOcular.Items.AddRange(new[] { "Miopía", "Astigmatismo", "Ninguna" });
        }

        // === LIMPIA TODOS LOS CAMPOS ===
        private void LimpiarCampos()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtApellidoP.Clear();
            txtApellidoM.Clear();
            txtArea.Clear();
            txtEdad.Clear();
            txtNSS.Clear();
            txtCURP.Clear();
            txtPeso.Clear();
            txtAltura.Clear();
            txtAlergia.Clear();
            txtEnfemedades.Clear();

            cboSexo.SelectedIndex = -1;
            cboTipoSangre.SelectedIndex = -1;
            cboRevicionOcular.SelectedIndex = -1;
            cboTipo.SelectedIndex = -1;
        }

        // ============================================================
        // CARGAR DATOS DESDE LA BASE DE DATOS
        // ============================================================
        private void CargarDatosPaciente()
        {
            Conexion conexionBD = new Conexion();
            MySqlConnection conn = conexionBD.obtenerconexion();
            if (conn == null) return;

            try
            {
                string query = "";

                if (tipoPaciente == "Alumno")
                {
                    query = @"SELECT a.matricula AS id, a.nombre, a.apellido_p, a.apellido_m,
                                     ar.nombre_area, e.id_expediente, e.edad, e.tipo_sangre, e.peso, e.talla,
                                     e.alergias, e.enfermedades, e.nss, e.curp, e.sexo, e.revision_ocular
                              FROM alumno a
                              LEFT JOIN areas ar ON a.id_area = ar.id_area
                              LEFT JOIN expediente e ON e.curp = a.matricula
                              WHERE a.matricula = @id
                              LIMIT 1;";
                }
                else
                {
                    query = @"SELECT t.num_trabajador AS id, t.nombre, t.apellido_p, t.apellido_m,
                                     ar.nombre_area, e.id_expediente, e.edad, e.tipo_sangre, e.peso, e.talla,
                                     e.alergias, e.enfermedades, e.nss, e.curp, e.sexo, e.revision_ocular
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
                            txtID.Text = lector["id"].ToString();
                            txtNombre.Text = lector["nombre"].ToString();
                            txtApellidoP.Text = lector["apellido_p"].ToString();
                            txtApellidoM.Text = lector["apellido_m"].ToString();
                            txtArea.Text = ValorO_Vacio(lector["nombre_area"]);

                            txtEdad.Text = ValorO_Vacio(lector["edad"]);
                            txtNSS.Text = ValorO_Vacio(lector["nss"]);
                            txtCURP.Text = ValorO_Vacio(lector["curp"]);
                            txtPeso.Text = ValorO_Vacio(lector["peso"]);
                            txtAltura.Text = ValorO_Vacio(lector["talla"]);
                            txtAlergia.Text = ValorO_Vacio(lector["alergias"]);
                            txtEnfemedades.Text = ValorO_Vacio(lector["enfermedades"]);

                            cboSexo.Text = ValorO_Vacio(lector["sexo"]);
                            cboTipoSangre.Text = ValorO_Vacio(lector["tipo_sangre"]);
                            cboRevicionOcular.Text = ValorO_Vacio(lector["revision_ocular"]);

                            // DETECTA SI EXISTE EL EXPEDIENTE POR SU ID, NO POR CAMPOS SUELTOS
                            expedienteExiste = lector["id_expediente"] != DBNull.Value;
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el paciente en la base de datos.", "Aviso");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error");
            }
            finally
            {
                conn.Close();
            }
        }

        // === AYUDANTE: Si el valor es nulo, devuelve texto vacío ===
        private string ValorO_Vacio(object valor)
        {
            return valor != DBNull.Value ? valor.ToString() : "";
        }

        // === BOTÓN EDITAR ===
        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnGuardar.Show();
        }

        // === BOTÓN GUARDAR ===
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (esNuevoPaciente)
                GuardarNuevo();
            else
                GuardarCambios();
        }

        // ============================================================
        // GUARDAR NUEVO PACIENTE
        // ============================================================
        private void GuardarNuevo()
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(cboTipo.Text))
            {
                MessageBox.Show("ID, Nombre y Tipo de paciente son obligatorios.", "Campos requeridos");
                return;
            }

            Conexion conexionBD = new Conexion();
            MySqlConnection conn = conexionBD.obtenerconexion();
            if (conn == null) return;

            MySqlTransaction trans = null;

            try
            {
                trans = conn.BeginTransaction();

                // ← OBTENER id_area DESDE EL NOMBRE ESCRITO EN txtArea
                int? idArea = ObtenerIdArea(conn, trans, txtArea.Text.Trim());

                // INSERTAR en tabla alumno O trabajador
                if (cboTipo.Text == "Alumno")
                {
                    string q = @"INSERT INTO alumno (matricula, nombre, apellido_p, apellido_m, id_area) 
                         VALUES (@id, @nom, @ap, @am, @idArea);";
                    using (MySqlCommand cmd = new MySqlCommand(q, conn, trans))
                    {
                        cmd.Parameters.AddWithValue("@id", txtID.Text.Trim());
                        cmd.Parameters.AddWithValue("@nom", txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@ap", txtApellidoP.Text.Trim());
                        cmd.Parameters.AddWithValue("@am", txtApellidoM.Text.Trim());
                        cmd.Parameters.AddWithValue("@idArea", idArea ?? (object)DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    string q = @"INSERT INTO trabajador (num_trabajador, nombre, apellido_p, apellido_m, id_area) 
                         VALUES (@id, @nom, @ap, @am, @idArea);";
                    using (MySqlCommand cmd = new MySqlCommand(q, conn, trans))
                    {
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtID.Text.Trim()));
                        cmd.Parameters.AddWithValue("@nom", txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@ap", txtApellidoP.Text.Trim());
                        cmd.Parameters.AddWithValue("@am", txtApellidoM.Text.Trim());
                        cmd.Parameters.AddWithValue("@idArea", idArea ?? (object)DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }
                }

                // INSERTAR expediente médico (sin cambios)
                string qExp = @"INSERT INTO expediente 
            (curp, edad, nss, talla, peso, sexo, tipo_sangre, alergias, enfermedades, revision_ocular) 
            VALUES 
            (@curp, @edad, @nss, @talla, @peso, @sexo, @tipoSangre, @alergias, @enfermedades, @revisionOcular);";

                using (MySqlCommand cmd = new MySqlCommand(qExp, conn, trans))
                {
                    cmd.Parameters.AddWithValue("@curp", txtID.Text.Trim());
                    cmd.Parameters.AddWithValue("@edad", ValorO_DBNull(txtEdad.Text));
                    cmd.Parameters.AddWithValue("@nss", ValorO_DBNull(txtNSS.Text));
                    cmd.Parameters.AddWithValue("@talla", ValorO_DBNull(txtAltura.Text));
                    cmd.Parameters.AddWithValue("@peso", ValorO_DBNull(txtPeso.Text));
                    cmd.Parameters.AddWithValue("@sexo", ValorO_DBNull(cboSexo.Text));
                    cmd.Parameters.AddWithValue("@tipoSangre", ValorO_DBNull(cboTipoSangre.Text));
                    cmd.Parameters.AddWithValue("@alergias", ValorO_DBNull(txtAlergia.Text));
                    cmd.Parameters.AddWithValue("@enfermedades", ValorO_DBNull(txtEnfemedades.Text));
                    cmd.Parameters.AddWithValue("@revisionOcular", ValorO_DBNull(cboRevicionOcular.Text));
                    cmd.ExecuteNonQuery();
                }

                trans.Commit();
                MessageBox.Show("Paciente registrado correctamente.", "Éxito");
                VolverABusqueda();
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
        // GUARDAR CAMBIOS DE PACIENTE EXISTENTE
        // ============================================================
        private void GuardarCambios()
        {
            Conexion conexionBD = new Conexion();
            MySqlConnection conn = conexionBD.obtenerconexion();
            if (conn == null) return;

            MySqlTransaction trans = null;

            try
            {
                trans = conn.BeginTransaction();

                // ← OBTENER id_area DESDE EL NOMBRE ESCRITO EN txtArea
                int? idArea = ObtenerIdArea(conn, trans, txtArea.Text.Trim());

                // ACTUALIZAR tabla alumno o trabajador (AHORA INCLUYE id_area)
                string queryPaciente = tipoPaciente == "Alumno"
                    ? @"UPDATE alumno SET nombre = @nombre, apellido_p = @apellidoP, apellido_m = @apellidoM, id_area = @idArea 
                WHERE matricula = @id;"
                    : @"UPDATE trabajador SET nombre = @nombre, apellido_p = @apellidoP, apellido_m = @apellidoM, id_area = @idArea 
                WHERE num_trabajador = @id;";

                using (MySqlCommand cmd = new MySqlCommand(queryPaciente, conn, trans))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@apellidoP", txtApellidoP.Text.Trim());
                    cmd.Parameters.AddWithValue("@apellidoM", txtApellidoM.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", idPaciente);
                    cmd.Parameters.AddWithValue("@idArea", idArea ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }

                // ACTUALIZAR o INSERTAR expediente (sin cambios)
                if (expedienteExiste)
                {
                    string q = @"UPDATE expediente 
                SET edad = @edad, tipo_sangre = @tipoSangre, alergias = @alergias, 
                    enfermedades = @enfermedades, peso = @peso, talla = @talla, 
                    nss = @nss, curp = @curp, sexo = @sexo, revision_ocular = @revisionOcular
                WHERE curp = @idPaciente;";

                    EjecutarExpediente(q, conn, trans, idPaciente);
                }
                else
                {
                    string q = @"INSERT INTO expediente 
                (curp, edad, nss, talla, peso, sexo, tipo_sangre, alergias, enfermedades, revision_ocular) 
                VALUES 
                (@curp, @edad, @nss, @talla, @peso, @sexo, @tipoSangre, @alergias, @enfermedades, @revisionOcular);";

                    EjecutarExpediente(q, conn, trans, idPaciente);
                    expedienteExiste = true;
                }

                trans.Commit();
                MessageBox.Show("Datos guardados correctamente.", "Éxito");
                VolverABusqueda();
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
        // AYUDANTE: Busca id_area por nombre. Si no existe, la crea.
        // ============================================================
        private int? ObtenerIdArea(MySqlConnection conn, MySqlTransaction trans, string nombreArea)
        {
            if (string.IsNullOrWhiteSpace(nombreArea)) return null;

            // Buscar si ya existe
            string q = "SELECT id_area FROM areas WHERE nombre_area = @nombre LIMIT 1;";
            using (MySqlCommand cmd = new MySqlCommand(q, conn, trans))
            {
                cmd.Parameters.AddWithValue("@nombre", nombreArea);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                    return Convert.ToInt32(result);
            }

            // Si no existe, insertarla y devolver el nuevo ID
            string qInsert = "INSERT INTO areas (nombre_area) VALUES (@nombre); SELECT LAST_INSERT_ID();";
            using (MySqlCommand cmd = new MySqlCommand(qInsert, conn, trans))
            {
                cmd.Parameters.AddWithValue("@nombre", nombreArea);
                object result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }

        // === AYUDANTE: Ejecuta consulta de expediente ===
        private void EjecutarExpediente(string query, MySqlConnection conn, MySqlTransaction trans, string id)
        {
            using (MySqlCommand cmd = new MySqlCommand(query, conn, trans))
            {
                cmd.Parameters.AddWithValue("@edad", ValorO_DBNull(txtEdad.Text));
                cmd.Parameters.AddWithValue("@tipoSangre", ValorO_DBNull(cboTipoSangre.Text));
                cmd.Parameters.AddWithValue("@alergias", ValorO_DBNull(txtAlergia.Text));
                cmd.Parameters.AddWithValue("@enfermedades", ValorO_DBNull(txtEnfemedades.Text));
                cmd.Parameters.AddWithValue("@peso", ValorO_DBNull(txtPeso.Text));
                cmd.Parameters.AddWithValue("@talla", ValorO_DBNull(txtAltura.Text));
                cmd.Parameters.AddWithValue("@nss", ValorO_DBNull(txtNSS.Text));
                cmd.Parameters.AddWithValue("@sexo", ValorO_DBNull(cboSexo.Text));
                cmd.Parameters.AddWithValue("@revisionOcular", ValorO_DBNull(cboRevicionOcular.Text));
                cmd.Parameters.AddWithValue("@idPaciente", id);
                cmd.Parameters.AddWithValue("@curp", id);
                cmd.ExecuteNonQuery();
            }
        }

        // ============================================================
        // ELIMINAR PACIENTE
        // ============================================================
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show(
                "¿Seguro que deseas eliminar completamente a este paciente?",
                "Eliminación total", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmar != DialogResult.Yes) return;

            Conexion conexionBD = new Conexion();
            MySqlConnection conn = conexionBD.obtenerconexion();
            if (conn == null) return;

            try
            {
                string qExp = "DELETE FROM expediente WHERE curp = @id;";
                using (MySqlCommand cmd = new MySqlCommand(qExp, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idPaciente);
                    cmd.ExecuteNonQuery();
                }

                string qPaciente = tipoPaciente == "Alumno"
                    ? "DELETE FROM alumno WHERE matricula = @id;"
                    : "DELETE FROM trabajador WHERE num_trabajador = @id;";

                using (MySqlCommand cmd = new MySqlCommand(qPaciente, conn))
                {
                    if (tipoPaciente == "Alumno")
                        cmd.Parameters.AddWithValue("@id", idPaciente);
                    else
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(idPaciente));

                    int filas = cmd.ExecuteNonQuery();

                    if (filas > 0)
                    {
                        MessageBox.Show("Paciente eliminado correctamente.", "Éxito");
                        VolverABusqueda();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el paciente.", "Aviso");
                    }
                }
            }
            catch
            {
                MessageBox.Show("No se pudo eliminar.", "Error");
            }
            finally
            {
                conn.Close();
            }
        }

        // === AYUDANTE: Vacío = NULL en base de datos ===
        private object ValorO_DBNull(string texto)
        {
            return string.IsNullOrEmpty(texto) ? (object)DBNull.Value : texto.Trim();
        }

        // === AYUDANTE: Regresa a búsqueda ===
        private void VolverABusqueda()
        {
            frmBusquedaAlumnos busqueda = new frmBusquedaAlumnos();
            busqueda.Show();
            this.Close();
        }

        // === HABILITA/DESHABILITA CAMPOS ===
        private void HabilitarCampos()
        {
            txtID.ReadOnly = false;
            txtNombre.ReadOnly = false;
            txtApellidoP.ReadOnly = false;
            txtApellidoM.ReadOnly = false;
            txtArea.ReadOnly = false;
            txtEdad.ReadOnly = false;
            txtNSS.ReadOnly = false;
            txtCURP.ReadOnly = false;
            txtPeso.ReadOnly = false;
            txtAltura.ReadOnly = false;
            txtAlergia.ReadOnly = false;
            txtEnfemedades.ReadOnly = false;

            cboSexo.Enabled = true;
            cboTipoSangre.Enabled = true;
            cboRevicionOcular.Enabled = true;
            cboTipo.Enabled = true;
        }

        private void DeshabilitarCampos()
        {
            txtID.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtApellidoP.ReadOnly = true;
            txtApellidoM.ReadOnly = true;
            txtArea.ReadOnly = true;
            txtEdad.ReadOnly = true;
            txtNSS.ReadOnly = true;
            txtCURP.ReadOnly = true;
            txtPeso.ReadOnly = true;
            txtAltura.ReadOnly = true;
            txtAlergia.ReadOnly = true;
            txtEnfemedades.ReadOnly = true;

            cboSexo.Enabled = false;
            cboTipoSangre.Enabled = false;
            cboRevicionOcular.Enabled = false;
            cboTipo.Enabled = false;
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            frmBusquedaAlumnos frmBusquedaPaciente = new frmBusquedaAlumnos();
            frmBusquedaPaciente.Show();
            this.Close();
        }
    }
}