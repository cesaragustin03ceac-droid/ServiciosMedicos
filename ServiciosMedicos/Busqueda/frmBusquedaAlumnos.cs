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
                    string query = @"SELECT Matricula, 
                                Nombre, 
                                Apellido_P AS 'Apellido Paterno', 
                                Apellido_M AS 'Apellido Materno'
                          
                         FROM Alumno
                         UNION ALL
                        
                         SELECT Num_Trabajador,
                         Nombre,
                         Apellido_P AS 'Apellido Paterno',
                         Apellido_M AS 'Apellido Materno'
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
    }
}
