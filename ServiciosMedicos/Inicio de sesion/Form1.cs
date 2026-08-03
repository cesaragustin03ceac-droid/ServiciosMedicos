using MySql.Data.MySqlClient;
using ServiciosMedicos.Busqueda;
using ServiciosMedicos.DataConexion;

namespace ServiciosMedicos
{
    public partial class Form1 : Form
    {
        private bool modoOscuro = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = BtEntrar;
            this.AcceptButton = BtEntrar;
        }

        private void BtEntrar_Click(object sender, EventArgs e)
        {
            string usuario = TxbUsuario.Text.Trim();
            string password = TxbContrasena.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Ingresa usuario y contraseña.", "Campos vacíos");
                return;
            }

            Conexion conexionBD = new Conexion();
            MySqlConnection conn = conexionBD.obtenerconexion();

            if (conn == null)
            {
                MessageBox.Show("No se pudo conectar a la base de datos.", "Error");
                return;
            }

            try
            {
                string nombre = "";
                string apellido = "";
                string hash = "";
                string tipo = ""; 
                string id = "";

                
                string queryDoc = "SELECT cedula, nombre, apellido_p, contrasena FROM Doctora WHERE cedula = @user;";

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
                            id = lector["cedula"].ToString();
                        }
                    }
                }

                if (string.IsNullOrEmpty(tipo))
                {
                    string queryEnf = "SELECT id_enfermera, nombre, apellido_p, contrasena FROM Enfermera WHERE id_enfermera = @user;";

                    using (MySqlCommand cmd = new MySqlCommand(queryEnf, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", usuario);

                        using (MySqlDataReader lector = cmd.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                nombre = lector["nombre"].ToString();
                                apellido = lector["apellido_p"].ToString();
                                hash = lector["contrasena"].ToString();
                                tipo = "enfermera";
                                id = lector["id_enfermera"].ToString();
                            }
                        }
                    }
                }

                if (string.IsNullOrEmpty(tipo))
                {
                    MessageBox.Show("Usuario no encontrado.", "Acceso denegado");
                    return;
                }

                if (BCrypt.Net.BCrypt.Verify(password, hash))
                {
                    frmBusquedaAlumnos.UsuarioNombre = $"{nombre} {apellido}";
                    frmBusquedaAlumnos.UsuarioTipo = tipo;
                    frmBusquedaAlumnos.UsuarioId = id;
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
                conn.Close(); 
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void btnModoNegro_Click(object sender, EventArgs e)
        {
            modoOscuro = !modoOscuro;
            AplicarTema();
        }
        private void AplicarTema()
        {
            Color fondoOscuro = Color.FromArgb(30, 30, 30);
            Color textoOscuro = Color.White;
            Color panelOscuro = Color.FromArgb(45, 45, 45);
            Color botonOscuro = Color.FromArgb(60, 60, 60);
            Color iconoOscuro = Color.Black;
            Color iconoOscuro2 = Color.Black;

            Color fondoClaro = Color.FromArgb(173, 198, 207);
            Color textoClaro = Color.Black;
            Color panelClaro = Color.FromArgb(128, 155, 176);
            Color botonClaro = Color.LightGray;
            Color iconoClaro = Color.FromArgb(77, 115, 147);
            Color iconoClaro2 = Color.FromArgb(77,115,147);

            Color fondo = modoOscuro ? fondoOscuro : fondoClaro;
            Color texto = modoOscuro ? textoOscuro : textoClaro;
            Color panel = modoOscuro ? panelOscuro : panelClaro;
            Color boton = modoOscuro ? botonOscuro : botonClaro;
            Color icono = modoOscuro ? iconoOscuro : iconoClaro;
            Color icono2 = modoOscuro ? iconoOscuro2 : iconoClaro2;

            this.BackColor = fondo;

            void AplicarAControl(Control ctrl)
            {
                if (ctrl is Panel)
                {
                    ctrl.BackColor = panel;
                    foreach (Control hijo in ctrl.Controls)
                    {
                        AplicarAControl(hijo);
                    }
                }
                else if (ctrl is Button)
                {
                    ctrl.BackColor = boton;
                    ctrl.ForeColor = texto;
                }
                else if (ctrl is TextBox)
                {
                    ctrl.BackColor = modoOscuro ? Color.FromArgb(50, 50, 50) : Color.White;
                    ctrl.ForeColor = texto;
                }
                else if (ctrl is Label)
                {
                    ctrl.ForeColor = texto;
                }
                else if (ctrl is PictureBox)
                {
                    if (ctrl.Name == "pictureBox1")
                    {
                        ctrl.BackColor = icono;
                    }
                    else if(ctrl.Name == "pictureBox2")
                    {
                        ctrl.BackColor = icono2;
                    }
                }
            }

            foreach (Control ctrl in this.Controls)
            {
                AplicarAControl(ctrl);
            }
        }
    }
}