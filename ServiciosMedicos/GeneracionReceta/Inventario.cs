using MySql.Data.MySqlClient;
using ServiciosMedicos.DataConexion;
using System;
using System.Windows.Forms;

namespace ServiciosMedicos.GeneracionReceta
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();

            cboNombreModificar.DropDownStyle = ComboBoxStyle.DropDown;
            cboNombreModificar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboNombreModificar.AutoCompleteSource = AutoCompleteSource.ListItems;

            cboNombreModificar.SelectedIndexChanged += cboNombreModificar_SelectedIndexChanged;
            cboNombreModificar.Leave += cboNombreModificar_Leave;

            CargarComboMedicamentos();
        }

        private void CargarComboMedicamentos()
        {
            cboNombreModificar.Items.Clear();
            Conexion conexionBD = new Conexion();
            MySqlConnection conn = conexionBD.obtenerconexion();
            if (conn == null) return;

            try
            {
                string query = "SELECT nombre_medicamento FROM inventario ORDER BY nombre_medicamento";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        cboNombreModificar.Items.Add(lector["nombre_medicamento"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar medicamentos: " + ex.Message, "Error");
            }
            finally
            {
                conn.Close();
            }
        }
        private void cboNombreModificar_Leave(object sender, EventArgs e)
        {
            string nombre = cboNombreModificar.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombre)) return;

            Conexion conexionBD = new Conexion();
            MySqlConnection conn = conexionBD.obtenerconexion();
            if (conn == null) return;

            try
            {
                string query = "SELECT cantidad FROM inventario WHERE nombre_medicamento = @nombre LIMIT 1";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    object res = cmd.ExecuteScalar();
                    if (res != null)
                        txtCantidadAnterior.Text = res.ToString();
                    else
                        txtCantidadAnterior.Clear();
                }
            }
            catch { }
            finally { conn.Close(); }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreAgregar.Text.Trim();
            int cantidad = (int)numCantidadAgregar.Value;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingrese el nombre del medicamento.", "Campo vacío");
                return;
            }

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.", "Cantidad inválida");
                return;
            }

            Conexion conexionBD = new Conexion();
            MySqlConnection conn = conexionBD.obtenerconexion();
            if (conn == null) return;

            try
            {
                string queryVerificar = "SELECT COUNT(*) FROM inventario WHERE LOWER(nombre_medicamento) = LOWER(@nombre)";
                using (MySqlCommand cmd = new MySqlCommand(queryVerificar, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    int existe = Convert.ToInt32(cmd.ExecuteScalar());
                    if (existe > 0)
                    {
                        MessageBox.Show("El medicamento ya existe en el inventario.", "Duplicado");
                        return;
                    }
                }

                string queryInsertar = "INSERT INTO inventario (nombre_medicamento, cantidad) VALUES (@nombre, @cantidad)";
                using (MySqlCommand cmd = new MySqlCommand(queryInsertar, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Medicamento agregado correctamente.", "Éxito");
                txtNombreAgregar.Clear();
                numCantidadAgregar.Value = 0;

                CargarComboMedicamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message, "Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            string nombre = cboNombreModificar.Text.Trim();
            int cantidadNueva = 0;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Seleccione o escriba un medicamento.", "Error");
                return;
            }

            if (!int.TryParse(txtCantidadNueva.Text.Trim(), out cantidadNueva) || cantidadNueva < 0)
            {
                MessageBox.Show("Ingrese una cantidad nueva válida.", "Error");
                return;
            }

            Conexion conexionBD = new Conexion();
            MySqlConnection conn = conexionBD.obtenerconexion();
            if (conn == null) return;

            try
            {
                string queryBuscar = @"SELECT id_medicamento, cantidad 
                                       FROM inventario 
                                       WHERE nombre_medicamento LIKE CONCAT('%', @nombre, '%') 
                                       LIMIT 1";
                int idMedicamento = 0;
                int cantidadActual = 0;

                using (MySqlCommand cmd = new MySqlCommand(queryBuscar, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    using (MySqlDataReader lector = cmd.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            idMedicamento = Convert.ToInt32(lector["id_medicamento"]);
                            cantidadActual = Convert.ToInt32(lector["cantidad"]);
                        }
                        else
                        {
                            MessageBox.Show("El medicamento no existe en el inventario.", "No encontrado");
                            return;
                        }
                    }
                }

                txtCantidadAnterior.Text = cantidadActual.ToString();

                string queryUpdate = "UPDATE inventario SET cantidad = @cantidad WHERE id_medicamento = @id";
                using (MySqlCommand cmd = new MySqlCommand(queryUpdate, conn))
                {
                    cmd.Parameters.AddWithValue("@cantidad", cantidadNueva);
                    cmd.Parameters.AddWithValue("@id", idMedicamento);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cantidad actualizada correctamente.", "Éxito");
                txtCantidadNueva.Clear();
                CargarComboMedicamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message, "Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void cboNombreModificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre = cboNombreModificar.Text;
            if (string.IsNullOrWhiteSpace(nombre)) return;

            Conexion conexionBD = new Conexion();
            MySqlConnection conn = conexionBD.obtenerconexion();
            if (conn == null) return;

            try
            {
                string query = "SELECT cantidad FROM inventario WHERE nombre_medicamento = @nombre LIMIT 1";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    object res = cmd.ExecuteScalar();
                    if (res != null)
                        txtCantidadAnterior.Text = res.ToString();
                }
            }
            catch { }
            finally { conn.Close(); }
        }
    }
}