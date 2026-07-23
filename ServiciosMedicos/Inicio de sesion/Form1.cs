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
        private bool modoOscuro = false;


        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = BtEntrar;
            this.AcceptButton = BtEntrar;

        }

        private void BtEntrar_Click(object sender, EventArgs e)
        {
            string usuario = TxbUsuario.Text;
            string password = TxbContrasena.Text;

            Conexion conexionBD = new Conexion();
            using (MySqlConnection conn = conexionBD.obtenerconexion())
            {
                if (conn != null)
                {
                    try
                    {
                        string query = @"
                    SELECT Nombre, Contrasena, 'enfermera' as Tipo FROM enfermera WHERE Id_Enfermera = @user
                    UNION
                    SELECT Nombre, Contrasena, 'doctora' as Tipo FROM doctora WHERE Cedula = @user;";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@user", usuario);

                            using (MySqlDataReader lector = cmd.ExecuteReader())
                            {
                                if (lector.Read())
                                {
                                    string Cifrado = lector["Contrasena"].ToString();
                                    bool esValida = BCrypt.Net.BCrypt.Verify(password, Cifrado);

                                    if (esValida)
                                    {
                                        frmBusquedaAlumnos.UsuarioNombre = lector["Nombre"].ToString();
                                        frmBusquedaAlumnos.UsuarioTipo = lector["Tipo"].ToString();

                                        frmBusquedaAlumnos ventanaBuscador = new frmBusquedaAlumnos();
                                        ventanaBuscador.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Contraseña incorrecta.", "Acceso denegado");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El usuario no existe.", "Acceso denegado");
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

        private void btnModoNegro_Click(object sender, EventArgs e)
        {
    

        }                         
    }
}

