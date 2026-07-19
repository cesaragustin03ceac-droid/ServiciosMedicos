using MySql.Data.MySqlClient;
using ServiciosMedicos.Busqueda;
using ServiciosMedicos.DataConexion;

namespace ServiciosMedicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = BtEntrar;
        }

        private void BtEntrar_Click(object sender, EventArgs e)
        {
            string usuario = TxbUsuario.Text;
            string pass = TxbContrasena.Text;

            Conexion conexionBD = new Conexion();
            using (MySqlConnection conn = conexionBD.obtenerconexion())
            {
                if (conn != null)
                {
                    try
                    {
                        string query = @"
                            SELECT Nombre FROM enfermera 
                            WHERE Id_Enfermera = @user AND Contrasena = @pass
                            UNION
                            SELECT Nombre FROM doctora 
                            WHERE Cedula = @user AND Contrasena = @pass;";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@user", usuario);
                            cmd.Parameters.AddWithValue("@pass", pass);

                            using (MySqlDataReader lector = cmd.ExecuteReader())
                            {
                                if (lector.Read()) 
                                {


                                    frmBusquedaAlumnos ventanaBuscador = new frmBusquedaAlumnos();
                                    ventanaBuscador.Show();

                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso denegado");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error");
                    }
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
