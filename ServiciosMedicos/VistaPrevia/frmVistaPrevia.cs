using MySql.Data.MySqlClient;
using ServiciosMedicos.DataConexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ServiciosMedicos.VistaPrevia
{
    public partial class frmVistaPrevia : Form
    {
        public frmVistaPrevia(string nombreDoctora, string cedulaDoctora)
        {
            InitializeComponent();
            lblDoctora.Text = nombreDoctora;
            lblCedula.Text = cedulaDoctora;
        }

        public void FechaVistaPrevia()
        {
            lblFecha.Text = DateTime.Now.ToString();
        }



        private void DatosEnVistaPrevia() 
        {
            Conexion conexionDB = new Conexion();
            MySqlConnection conexionAbierta = conexionDB.obtenerconexion();

            if (conexionAbierta != null)
            {
                try
                {
                    string query = @"SELECT 
                                c.Matricula_Alumno, c.Num_Trabajador,
                                COALESCE(a.Matricula, t.Num_Trabajador) AS MatriculaFinal,
                                CONCAT(COALESCE(a.Nombre, t.Nombre), ' ', COALESCE(a.Apellido_P, t.Apellido_P), ' ', COALESCE(a.Apellido_M, t.Apellido_M)) AS NombreCompleto
                             FROM consulta c
                             LEFT JOIN alumno a ON c.Matricula_Alumno = a.Matricula
                             LEFT JOIN trabajador t ON c.Num_Trabajador = t.Num_Trabajador
                             ORDER BY c.Id_Consulta DESC 
                             LIMIT 1;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexionAbierta))
                    {
                        using (MySqlDataReader lector = cmd.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                lblMatricula.Text = lector["MatriculaFinal"].ToString();
                                lblNobre.Text = lector["NombreCompleto"].ToString();
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
    }
}
