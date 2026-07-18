using MySql.Data.MySqlClient;
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
            button1.Paint += DibujarBordeGrueso;       // BORDE DEL BOTON EDITAR  EXPEDIENTE 
            btnGuardar.Paint += DibujarBordeGrueso;
            btnVistaPrevia.Paint += DibujarBordeGrueso;
            button7.Paint += DibujarBordeGrueso;
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

        public void CargarDatosPaciente(string id, string tipo)
        {
            Conexion conexionBD = new Conexion();
            MySqlConnection conexionAbierta = conexionBD.obtenerconexion();

            if (conexionAbierta != null)
            {
                try
                {
                    string query = "";

                    if (tipo == "Alumno")
                    {
                        query = "SELECT Matricula, CONCAT(Nombre, ' ', Apellido_P, ' ', IFNULL(Apellido_M, '')) AS NombreCompleto, Carrera " +
                                "FROM alumno WHERE Matricula = @id";
                    }
                    else if (tipo == "Trabajador")
                    {
                        query = "SELECT Num_Trabajador AS Matricula, CONCAT(Nombre, ' ', Apellido_P, ' ', IFNULL(Apellido_M, '')) AS NombreCompleto, Areas AS Carrera " +
                                "FROM trabajador WHERE Num_Trabajador = @id";
                    }

                    MySqlCommand comando = new MySqlCommand(query, conexionAbierta);
                    comando.Parameters.AddWithValue("@id", id);

                    MySqlDataReader lector = comando.ExecuteReader();

                    if (lector.Read())
                    {
                        // ⚠️ IMPORTANTE: Cambia estos nombres por el 'Name' real 
                        // de los TextBox que tienes en tu interfaz de Receta:
                        txtMatricula.Text = lector["Matricula"].ToString();
                        txtNombre.Text = lector["NombreCompleto"].ToString();
                        txtCarrera.Text = lector["Carrera"].ToString();

                        // Coloca la fecha de hoy de forma automática
                        txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    }
                    lector.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos en la receta: " + ex.Message);
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
                // Validamos que no intente borrar la fila nueva automática (el asterisco)
                if (!dgvMedicamentos.Rows[e.RowIndex].IsNewRow)
                {
                    dgvMedicamentos.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
