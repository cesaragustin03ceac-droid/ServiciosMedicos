using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ServiciosMedicos.DataConexion;

namespace ServiciosMedicos.GeneracionReceta
{
    public partial class Medicamentos : Form
    {
        public int IdMedicamento { get; set; }
        public string Medicamento { get; set; }
        public string Cantidad { get; set; }
        public string Indicaciones { get; set; }

        private DataTable dtMedicamentos = new DataTable();

        public Medicamentos()
        {
            InitializeComponent();
            cboMedicamento.SelectedIndexChanged += cmbMedicamento_SelectedIndexChanged;
            btnAgregar.Click += btnAgregar_Click;
            btnGuardar.Click += btnGuardar_Click;
            btnEditar.Click += btnEditar_Click;
            btnInvemtario.Click += btnInvemtario_Click;
            CargarMedicamentos();
        }

        private void CargarMedicamentos()
        {
            Conexion conexionBD = new Conexion();
            MySqlConnection conexionAbierta = conexionBD.obtenerconexion();
            if (conexionAbierta != null)
            {
                try
                {
                    string query = "SELECT id_medicamento, nombre_medicamento, cantidad FROM inventario";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conexionAbierta);
                    dtMedicamentos.Clear();
                    da.Fill(dtMedicamentos);
                    cboMedicamento.DataSource = null;
                    cboMedicamento.DisplayMember = "nombre_medicamento";
                    cboMedicamento.ValueMember = "id_medicamento";
                    cboMedicamento.DataSource = dtMedicamentos;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar inventario: " + ex.Message);
                }
                finally
                {
                    conexionAbierta.Close();
                }
            }
        }

        private void cmbMedicamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMedicamento.SelectedItem == null) return;
            try
            {
                DataRowView drv = cboMedicamento.SelectedItem as DataRowView;
                if (drv != null)
                {
                    txtCantidadMedicamento.Text = drv["cantidad"].ToString();
                }
            }
            catch
            {
                txtCantidadMedicamento.Text = "0";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboMedicamento.SelectedItem == null || string.IsNullOrWhiteSpace(txtCantidadDar.Text))
            {
                MessageBox.Show("Seleccione un medicamento y la cantidad a dar");
                return;
            }

            DataRowView drv = cboMedicamento.SelectedItem as DataRowView;
            if (drv != null)
            {
                IdMedicamento = Convert.ToInt32(drv["id_medicamento"]);
            }

            Medicamento = cboMedicamento.Text;
            Cantidad = txtCantidadDar.Text.Trim();
            Indicaciones = txtIndicaciones.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e) { }
        private void btnEditar_Click(object sender, EventArgs e) { }
        private void btnInvemtario_Click(object sender, EventArgs e) { }
    }
}