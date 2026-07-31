using MySql.Data.MySqlClient;
using ServiciosMedicos.Busqueda;
using ServiciosMedicos.DataConexion;

namespace ServiciosMedicos
{
    public partial class Form1 : Form
    {
        // Bandera para cambiar entre modo claro y oscuro
        private bool modoOscuro = false;

        public Form1()
        {
            InitializeComponent();
        }

        // Al cargar la ventana, pone el foco en el botón Entrar
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = BtEntrar;
            this.AcceptButton = BtEntrar;
        }

        // ========================================================================
        // BOTÓN ENTRAR: Revisa usuario y contraseña en la base de datos
        // ========================================================================
        private void BtEntrar_Click(object sender, EventArgs e)
        {
            // 1. Lee lo que escribió el usuario
            string usuario = TxbUsuario.Text.Trim();
            string password = TxbContrasena.Text;

            // 2. Valida que no estén vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Ingresa usuario y contraseña.", "Campos vacíos");
                return;
            }

            // 3. Abre conexión con la base de datos
            Conexion conexionBD = new Conexion();
            MySqlConnection conn = conexionBD.obtenerconexion();

            if (conn == null)
            {
                if (conn != null)
                {
                    try
                    {
                        string query = @"
                     SELECT id_Enfermera, Nombre, apellido_p, apellido_m, Contrasena, 'enfermera' as Tipo FROM enfermera WHERE Id_Enfermera = @user
                     UNION
                     SELECT Cedula, Nombre, apellido_p, apellido_m, Contrasena, 'doctora' as Tipo FROM doctora WHERE Cedula = @user;";

                using (MySqlCommand cmd = new MySqlCommand(queryDoc, conn))
                {
                    cmd.Parameters.AddWithValue("@user", usuario);

                    using (MySqlDataReader lector = cmd.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            nombre = lector["nombre"].ToString();
                            apellido = lector["apellido_p"].ToString();
                            hash = lector["contrasena"].ToString();
                            tipo = "doctora";
                        }
                    }
                }

                // 5. Si no estaba en Doctora, busca en Enfermera
                if (string.IsNullOrEmpty(tipo))
                {
                    string queryEnf = "SELECT nombre, apellido_p, contrasena FROM Enfermera WHERE id_enfermera = @user;";

                                    if (esValida)
                                    {
                                        frmBusquedaAlumnos.UsuarioNombre = lector["Nombre"].ToString();
                                        frmBusquedaAlumnos.UsuarioTipo = lector["Tipo"].ToString();
                                        frmBusquedaAlumnos.UsuarioId = lector["id_Enfermera"].ToString();

                        using (MySqlDataReader lector = cmd.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                nombre = lector["nombre"].ToString();
                                apellido = lector["apellido_p"].ToString();
                                hash = lector["contrasena"].ToString();
                                tipo = "enfermera";
                            }
                        }
                    }
                }

                // 6. Si no lo encontró en ninguna tabla, muestra error
                if (string.IsNullOrEmpty(tipo))
                {
                    MessageBox.Show("Usuario no encontrado.", "Acceso denegado");
                    return;
                }

                // 7. Compara la contraseña ingresada con la de la base (encriptada)
                if (BCrypt.Net.BCrypt.Verify(password, hash))
                {
                    // 8. Guarda datos del usuario logueado para usarlos después
                    frmBusquedaAlumnos.UsuarioNombre = $"{nombre} {apellido}";
                    frmBusquedaAlumnos.UsuarioTipo = tipo;

                    // 9. Abre la ventana principal y cierra el login
                    frmBusquedaAlumnos ventana = new frmBusquedaAlumnos();
                    ventana.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta.", "Acceso denegado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
            finally
            {
                conn.Close(); // Cierra la conexión con la base de datos
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