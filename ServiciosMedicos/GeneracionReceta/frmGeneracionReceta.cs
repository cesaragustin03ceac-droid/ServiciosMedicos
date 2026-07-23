using MySql.Data.MySqlClient;
using ServiciosMedicos.Consultas;
using ServiciosMedicos.DataConexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ServiciosMedicos.GeneracionReceta
{
    public partial class frmGeneracionReceta : Form
    {
        public frmGeneracionReceta()
        {
            InitializeComponent();
            btonCancelar.Paint += DibujarBordeGrueso;       // BORDE DEL BOTON EDITAR  EXPEDIENTE 
            btnGuardar.Paint += DibujarBordeGrueso;
            btnVistaPrevia.Paint += DibujarBordeGrueso;
            btnImprimir.Paint += DibujarBordeGrueso;
            groupBox2.Paint += DibujarBordeGrueso;
            groupBox3.Paint += DibujarBordeGrueso;
            FechaConsulta();

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
                    string query = @"SELECT 
                                c.Matricula_Alumno, c.Num_Trabajador,
                                COALESCE(a.Matricula, t.Num_Trabajador) AS MatriculaFinal,
                                CONCAT(COALESCE(a.Nombre, t.Nombre), ' ', COALESCE(a.Apellido_P, t.Apellido_P), ' ', COALESCE(a.Apellido_M, t.Apellido_M)) AS NombreCompleto,
                                COALESCE(a.Carrera, t.Areas) AS AreaFinal
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
                                txtMatricula.Text = lector["MatriculaFinal"].ToString();
                                txtNombre.Text = lector["NombreCompleto"].ToString();
                                txtArea.Text = lector["AreaFinal"].ToString();
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
            dgvMedicamentos.Rows.Add("");
        }

        private void dgvMedicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dgvMedicamentos.Columns[e.ColumnIndex].Name == "colEliminar")
            {

                if (!dgvMedicamentos.Rows[e.RowIndex].IsNewRow)
                {
                    dgvMedicamentos.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Close();
        }

        private void frmGeneracionReceta_Load(object sender, EventArgs e)
        {
            CargarDatosPacienteEnReceta();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmConsultas frmcondultas = new FrmConsultas();
            frmcondultas.Show();

            this.Close();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            FrmConsultas frmcondultas = new FrmConsultas();
            frmcondultas.Show();

            this.Close();
        }
    }
}
