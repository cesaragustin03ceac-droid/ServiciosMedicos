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
        public frmBusquedaAlumnos()
        {
            InitializeComponent();
        }

        private void frmBusquedaAlumnos_Load(object sender, EventArgs e)
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
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
