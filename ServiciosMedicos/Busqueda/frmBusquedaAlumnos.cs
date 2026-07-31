using MySql.Data.MySqlClient;
using ServiciosMedicos.DataConexion;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ServiciosMedicos.Busqueda
{
    public partial class frmBusquedaAlumnos : Form
    {
        // Guarda quién inició sesión (nombre y tipo: doctora/enfermera)
        public static string UsuarioNombre = "";
        public static string UsuarioTipo = "";
        public static string UsuarioId = "";

        public frmBusquedaAlumnos()
        {
            InitializeComponent();
            RegistroAlumnos.SelectionChanged += RegistroAlumnos_SelectionChanged;
        }

        // Al cargar la ventana, llena la tabla y oculta el botón de expediente
        private void frmBusquedaAlumnos_Load(object sender, EventArgs e)
        {
            CargarDatos();
            RegistroAlumnos.ClearSelection();
            this.btnExpedientePaciente.Hide();
        }

        // ========================================================================
        // EXTRAER INFORMACIÓN DE LA BASE DE DATOS
        // ========================================================================
        private void CargarDatos()
        {
            Conexion conexionBD = new Conexion();
            MySqlConnection conexionAbierta = conexionBD.obtenerconexion();

            if (conexionAbierta == null) return;

            try
            {
                // Tabla donde se juntarán alumnos y trabajadores
                DataTable tablaDatos = new DataTable();
                tablaDatos.Columns.Add("Tipo de id");
                tablaDatos.Columns.Add("nombre");
                tablaDatos.Columns.Add("Apellido Paterno");
                tablaDatos.Columns.Add("Apellido Materno");
                tablaDatos.Columns.Add("Tipo de trabajador");

                // 1. Consulta los alumnos
                string queryAlumnos = @"SELECT matricula, nombre, apellido_p, apellido_m 
                                        FROM Alumno;";

                using (MySqlCommand cmd = new MySqlCommand(queryAlumnos, conexionAbierta))
                using (MySqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        DataRow fila = tablaDatos.NewRow();
                        fila["Tipo de id"] = lector["matricula"].ToString();
                        fila["nombre"] = lector["nombre"].ToString();
                        fila["Apellido Paterno"] = lector["apellido_p"].ToString();
                        fila["Apellido Materno"] = lector["apellido_m"].ToString();
                        fila["Tipo de trabajador"] = "Alumno"; // Se asigna desde el código
                        tablaDatos.Rows.Add(fila);
                    }
                }

                // 2. Consulta los trabajadores
                string queryTrabajadores = @"SELECT num_trabajador, nombre, apellido_p, apellido_m 
                                             FROM Trabajador;";

                using (MySqlCommand cmd = new MySqlCommand(queryTrabajadores, conexionAbierta))
                using (MySqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        DataRow fila = tablaDatos.NewRow();
                        fila["Tipo de id"] = lector["num_trabajador"].ToString();
                        fila["nombre"] = lector["nombre"].ToString();
                        fila["Apellido Paterno"] = lector["apellido_p"].ToString();
                        fila["Apellido Materno"] = lector["apellido_m"].ToString();
                        fila["Tipo de trabajador"] = "Trabajador"; // Se asigna desde el código
                        tablaDatos.Rows.Add(fila);
                    }
                }

                // 3. Muestra los datos en la tabla
                RegistroAlumnos.DataSource = tablaDatos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos en la tabla: " + ex.Message);
            }
            finally
            {
                conexionAbierta.Close();
            }
        }

        // ========================================================================
        // MOSTRAR BOTÓN SOLO SI HAY UN PACIENTE SELECCIONADO
        // ========================================================================
        private void RegistroAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            if (RegistroAlumnos.SelectedRows.Count > 0 &&
                RegistroAlumnos.CurrentRow != null &&
                !RegistroAlumnos.CurrentRow.IsNewRow)
            {
                this.btnExpedientePaciente.Show();
            }
            else
            {
                this.btnExpedientePaciente.Hide();
            }
        }

        // ========================================================================
        // BOTÓN EXPEDIENTE: Abre el formulario con los datos del paciente elegido
        // ========================================================================
        private void btnExpedientePaciente_Click(object sender, EventArgs e)
        {
            if (RegistroAlumnos.SelectedRows.Count == 0) return;

            DataGridViewRow fila = RegistroAlumnos.SelectedRows[0];
            string idSeleccionado = fila.Cells[0].Value?.ToString();
            string tipoSeleccionado = fila.Cells[4].Value?.ToString();

            if (string.IsNullOrEmpty(idSeleccionado)) return;

            AgregarPaciente ventana = new AgregarPaciente(idSeleccionado, tipoSeleccionado);
            ventana.Show();
            this.Hide();
        }

        // ========================================================================
        // DOBLE CLIC: Abre el historial médico del paciente
        // ========================================================================
        private void RegistroAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = RegistroAlumnos.Rows[e.RowIndex];
            string idSeleccionado = fila.Cells[0].Value?.ToString();
            string tipoSeleccionado = fila.Cells[4].Value?.ToString();

            if (string.IsNullOrEmpty(idSeleccionado)) return;

            ServiciosMedicos.HISTORIAL.HISTORIAL ventanaPerfil = new ServiciosMedicos.HISTORIAL.HISTORIAL();
            ventanaPerfil.CargarPerfilPaciente(idSeleccionado, tipoSeleccionado);
            ventanaPerfil.Show();
            this.Hide();
        }

        // ========================================================================
        // BUSCADOR: Filtra la tabla mientras se escribe
        // ========================================================================
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBusqueda.Text.Trim();

            if (RegistroAlumnos.DataSource is DataTable tabla)
            {
                if (string.IsNullOrEmpty(filtro))
                {
                    tabla.DefaultView.RowFilter = "";
                }
                else
                {
                    tabla.DefaultView.RowFilter = string.Format(
                        "[Tipo de id] LIKE '%{0}%'",
                        filtro.Replace("'", "''")
                    );
                }
            }
        }

        // ========================================================================
        // BOTÓN NUEVO PACIENTE: Abre formulario en blanco
        // ========================================================================
        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            AgregarPaciente ventana = new AgregarPaciente();
            ventana.Show();
            this.Hide();
        }

        // ========================================================================
        // BOTÓN SALIR: Cierra la aplicación
        // ========================================================================
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Métodos vacíos del diseñador (sin uso actual)
        private void textBox6_TextChanged(object sender, EventArgs e) 
        {

        }
        private void label1_Click(object sender, EventArgs e) 
        {

        }
        private void label3_Click(object sender, EventArgs e) 
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e) 
        {

        }
        private void groupBox2_Enter(object sender, EventArgs e) 
        {

        }
        private void btnNuevo_Click(object sender, EventArgs e) 
        {

        }
        private void btnEditar_Click(object sender, EventArgs e) 
        {

        }
        private void btnEliminar_Click(object sender, EventArgs e) 
        {

        }
        private void RegistroAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {

        }
    }
}