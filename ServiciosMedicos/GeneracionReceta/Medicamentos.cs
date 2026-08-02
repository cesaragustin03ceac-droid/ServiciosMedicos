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
        private bool interno = false; // ← para evitar bucles

        public Medicamentos()
        {
            InitializeComponent();
            cboMedicamento.SelectedIndexChanged += cmbMedicamento_SelectedIndexChanged;
            btnAgregar.Click += btnAgregar_Click;
            btnInvemtario.Click += btnInvemtario_Click;
            cboMedicamento.KeyUp += cboMedicamento_KeyUp; // ← LIKE al escribir
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

        // ← NUEVO: filtra con LIKE mientras escribes
        private void cboMedicamento_KeyUp(object sender, KeyEventArgs e)
        {
            if (interno) return;
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
                return;

            string texto = cboMedicamento.Text.Trim();
            if (texto.Length < 2) return;

            Conexion conexionBD = new Conexion();
            MySqlConnection conn = conexionBD.obtenerconexion();
            if (conn == null) return;

            try
            {
                string query = "SELECT id_medicamento, nombre_medicamento, cantidad FROM inventario WHERE nombre_medicamento LIKE @filtro";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@filtro", "%" + texto + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                interno = true;
                int cursor = cboMedicamento.SelectionStart;
                cboMedicamento.DataSource = dt;
                cboMedicamento.DisplayMember = "nombre_medicamento";
                cboMedicamento.ValueMember = "id_medicamento";
                cboMedicamento.Text = texto;
                cboMedicamento.SelectionStart = cursor;
                cboMedicamento.DroppedDown = true;
                interno = false;
            }
            catch { }
            finally { conn.Close(); }
        }

        private void cmbMedicamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (interno) return; // ← ignora cambios del filtro
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}