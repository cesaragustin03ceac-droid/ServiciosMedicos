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

        }

        private void BtEntrar_Click(object sender, EventArgs e)
        {
            if (TxbUsuario.Text == "admin" && TxbContrasena.Text == "1234")
            {
                MessageBox.Show("Ingresando", "Éxito");

            }
            else
            {
                MessageBox.Show("error usuario o contraeña incorrecto", "Error de acceso");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
