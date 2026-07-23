using MySql.Data.MySqlClient;
using ServiciosMedicos.DataConexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace ServiciosMedicos.Busqueda
{
    public partial class frmBusquedaAlumnos : Form
    {
        public static string UsuarioNombre = "";
        public static string UsuarioTipo = "";
        public frmBusquedaAlumnos()
        {
            InitializeComponent();

        }

        private void frmBusquedaAlumnos_Load(object sender, EventArgs e)
        {
            if (CmbTipoPaciente.Items.Count == 0)
            {
                CmbTipoPaciente.Items.Add("Alumno");
                CmbTipoPaciente.Items.Add("Trabajador");
            }
            CargarDatos();


        }

        private void CargarDatos()
        {
            Conexion conexionBD = new Conexion();
            MySqlConnection conexionAbierta = conexionBD.obtenerconexion();

            if (conexionAbierta != null)
            {
                try
                {
                    string query = @"SELECT Matricula AS 'Tipo de id', 
                                Nombre, 
                                Apellido_P AS 'Apellido Paterno', 
                                Apellido_M AS 'Apellido Materno',
                                'Alumno' AS 'Tipo de trabajador'
                         FROM Alumno
                         UNION ALL
                         SELECT Num_Trabajador AS 'Tipo de id',
                         Nombre,
                         Apellido_P AS 'Apellido Paterno',
                         Apellido_M AS 'Apellido Materno',
                         'Trabajador' AS 'Tipo de trabajador'
                         FROM Trabajador;";

                    MySqlCommand comando = new MySqlCommand(query, conexionAbierta);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataTable tablaDatos = new DataTable();

                    adaptador.Fill(tablaDatos);

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
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RegistroAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string idSeleccionado = RegistroAlumnos.Rows[e.RowIndex].Cells[0].Value.ToString();
                string tipoSeleccionado = RegistroAlumnos.Rows[e.RowIndex].Cells[4].Value.ToString();

                ServiciosMedicos.HISTORIAL.HISTORIAL ventanaPerfil = new ServiciosMedicos.HISTORIAL.HISTORIAL();

                ventanaPerfil.Show();

                ventanaPerfil.CargarPerfilPaciente(idSeleccionado, tipoSeleccionado);
                this.Hide();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string matricula = txtMatricula.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string apellidoP = txtApellidoP.Text.Trim();
            string apellidoM = txtApellidoM.Text.Trim();
            string tipoPaciente = CmbTipoPaciente.Text.Trim();


            Conexion conexionBD = new Conexion();
            MySqlConnection conexionAbierta = conexionBD.obtenerconexion();

            if (conexionAbierta != null)
            {
                try
                {
                    string queryInsert = "";

                    if (tipoPaciente.Equals("Alumno", StringComparison.OrdinalIgnoreCase))
                    {
                        queryInsert = "INSERT INTO Alumno (Matricula, Nombre, Apellido_P, Apellido_M) VALUES (@mat, @nom, @app, @apm)";
                    }
                    else if (tipoPaciente.Equals("Trabajador", StringComparison.OrdinalIgnoreCase))
                    {
                        queryInsert = "INSERT INTO Trabajador (Num_Trabajador, Nombre, Apellido_P, Apellido_M) VALUES (@mat, @nom, @app, @apm)";
                    }
                    else
                    {
                        MessageBox.Show("Selecciona un tipo de paciente válido ('Alumno' o 'Trabajador').", "Aviso");
                        conexionAbierta.Close();
                        return;
                    }

                    using (MySqlCommand comando = new MySqlCommand(queryInsert, conexionAbierta))
                    {
                        comando.Parameters.AddWithValue("@mat", matricula);
                        comando.Parameters.AddWithValue("@nom", nombre);
                        comando.Parameters.AddWithValue("@app", apellidoP);
                        comando.Parameters.AddWithValue("@apm", apellidoM);

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Registro guardado correctamente.", "Éxito");

                        CargarDatos();
                        txtMatricula.Clear();
                        txtNombre.Clear();
                        txtApellidoP.Clear();
                        txtApellidoM.Clear();
                        CmbTipoPaciente.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el registro: " + ex.Message);
                }
                finally
                {
                    conexionAbierta.Close();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string matricula = txtMatricula.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string apellidoP = txtApellidoP.Text.Trim();
            string apellidoM = txtApellidoM.Text.Trim();
            string tipoPaciente = CmbTipoPaciente.Text.Trim();



            Conexion conexionBD = new Conexion();
            MySqlConnection conexionAbierta = conexionBD.obtenerconexion();

            if (conexionAbierta != null)
            {
                try
                {
                    string queryUpdate = "";

                    if (tipoPaciente.Equals("Alumno", StringComparison.OrdinalIgnoreCase))
                    {
                        queryUpdate = "UPDATE Alumno SET Nombre = @nom, Apellido_P = @app, Apellido_M = @apm WHERE Matricula = @mat";
                    }
                    else if (tipoPaciente.Equals("Trabajador", StringComparison.OrdinalIgnoreCase))
                    {
                        queryUpdate = "UPDATE Trabajador SET Nombre = @nom, Apellido_P = @app, Apellido_M = @apm WHERE Num_Trabajador = @mat";
                    }
                    else
                    {
                        MessageBox.Show("Selecciona si el paciente es 'Alumno' o 'Trabajador' para saber qué tabla actualizar.", "Aviso");
                        conexionAbierta.Close();
                        return;
                    }

                    using (MySqlCommand comando = new MySqlCommand(queryUpdate, conexionAbierta))
                    {
                        comando.Parameters.AddWithValue("@mat", matricula);
                        comando.Parameters.AddWithValue("@nom", nombre);
                        comando.Parameters.AddWithValue("@app", apellidoP);
                        comando.Parameters.AddWithValue("@apm", apellidoM);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Registro actualizado correctamente.", "Éxito");

                            CargarDatos();
                            txtMatricula.Clear();
                            txtNombre.Clear();
                            txtApellidoP.Clear();
                            txtApellidoM.Clear();
                            CmbTipoPaciente.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún registro con esa matrícula o número de trabajador.", "Aviso");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el registro: " + ex.Message);
                }
                finally
                {
                    conexionAbierta.Close();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string matricula = txtMatricula.Text.Trim();
            string tipoPaciente = CmbTipoPaciente.Text.Trim();

            if (string.IsNullOrEmpty(matricula))
            {
                MessageBox.Show("Por favor, ingresa o selecciona la matrícula del paciente que deseas eliminar.", "Aviso");
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Estás seguro de eliminar este registro? Se eliminarán también todas sus consultas médicas.",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                Conexion conexionBD = new Conexion();
                MySqlConnection conexionAbierta = conexionBD.obtenerconexion();

                if (conexionAbierta != null)
                {
                    MySqlTransaction transaccion = null;
                    try
                    {
                        transaccion = conexionAbierta.BeginTransaction();

                        if (tipoPaciente.Equals("Alumno", StringComparison.OrdinalIgnoreCase))
                        {
                            string queryDeleteConsultas = "DELETE FROM Consulta WHERE Matricula_Alumno = @mat";
                            using (MySqlCommand cmd = new MySqlCommand(queryDeleteConsultas, conexionAbierta, transaccion))
                            {
                                cmd.Parameters.AddWithValue("@mat", matricula);
                                cmd.ExecuteNonQuery();
                            }

                            string queryDeleteAlumno = "DELETE FROM Alumno WHERE Matricula = @mat";
                            using (MySqlCommand cmd = new MySqlCommand(queryDeleteAlumno, conexionAbierta, transaccion))
                            {
                                cmd.Parameters.AddWithValue("@mat", matricula);
                                int filas = cmd.ExecuteNonQuery();

                                if (filas > 0)
                                {
                                    transaccion.Commit();
                                    MessageBox.Show("Registro y consultas eliminados correctamente.", "Éxito");
                                }
                                else
                                {
                                    transaccion.Rollback();
                                    MessageBox.Show("No se encontró el alumno.", "Aviso");
                                    return;
                                }
                            }
                        }
                        else if (tipoPaciente.Equals("Trabajador", StringComparison.OrdinalIgnoreCase))
                        {
                            string queryDeleteConsultas = "DELETE FROM Consulta WHERE Num_Trabajador = @mat";
                            using (MySqlCommand cmd = new MySqlCommand(queryDeleteConsultas, conexionAbierta, transaccion))
                            {
                                cmd.Parameters.AddWithValue("@mat", matricula);
                                cmd.ExecuteNonQuery();
                            }

                            string queryDeleteTrabajador = "DELETE FROM Trabajador WHERE Num_Trabajador = @mat";
                            using (MySqlCommand cmd = new MySqlCommand(queryDeleteTrabajador, conexionAbierta, transaccion))
                            {
                                cmd.Parameters.AddWithValue("@mat", matricula);
                                int filas = cmd.ExecuteNonQuery();

                                if (filas > 0)
                                {
                                    transaccion.Commit();
                                    MessageBox.Show("Registro y consultas eliminados correctamente.", "Éxito");
                                }
                                else
                                {
                                    transaccion.Rollback();
                                    MessageBox.Show("No se encontró el trabajador.", "Aviso");
                                    return;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Selecciona si el paciente es 'Alumno' o 'Trabajador'.", "Aviso");
                            transaccion?.Rollback();
                            return;
                        }

                        CargarDatos();
                        txtMatricula.Clear();
                        txtNombre.Clear();
                        txtApellidoP.Clear();
                        txtApellidoM.Clear();
                        CmbTipoPaciente.SelectedIndex = -1;
                    }
                    catch (Exception ex)
                    {
                        transaccion?.Rollback();
                        MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                    }
                    finally
                    {
                        conexionAbierta.Close();
                    }
                }
            }
        }

        private void RegistroAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = RegistroAlumnos.Rows[e.RowIndex];

                txtMatricula.Text = fila.Cells[0].Value.ToString();
                txtNombre.Text = fila.Cells[1].Value.ToString();
                txtApellidoP.Text = fila.Cells[2].Value.ToString();
                txtApellidoM.Text = fila.Cells[3].Value.ToString();
                CmbTipoPaciente.Text = fila.Cells[4].Value.ToString();
            }
        }

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

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
