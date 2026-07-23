using MySql.Data.MySqlClient;
using ServiciosMedicos.Busqueda;
using ServiciosMedicos.DataConexion;
using ServiciosMedicos.GeneracionReceta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ServiciosMedicos.Consultas
{
    public partial class FrmConsultas : Form
    {

        public FrmConsultas()
        {
            InitializeComponent();
            CargarOpcionesGenerales();

        }
        private void CargarOpcionesGenerales()
        {
            CboMotivo.Items.Clear();
            CboMotivo.Items.Add("Chequeo general de rutina");
            CboMotivo.Items.Add("Malestar general");
            CboMotivo.Items.Add("Dolor");
            CboMotivo.SelectedIndex = -1;

            cboSintomas.Items.Clear();
            cboSintomas.Items.Add("Fiebre y escalofríos");
            cboSintomas.Items.Add("Dolor de cabeza");
            cboSintomas.Items.Add("Tos y congestión nasal");

            cboSintomas.SelectedIndex = -1;

            cboDiagnostico.Items.Clear();
            cboDiagnostico.Items.Add("Infecion de estomago");
            cboDiagnostico.Items.Add("Resfriado común)");
            cboDiagnostico.Items.Add("Gastroenteritis aguda");
            cboDiagnostico.SelectedIndex = -1;
        }
        private string idPaciente;
        private string tipoPaciente;

        public void PassDatosPaciente(string id, string tipo)
        {
            this.idPaciente = id;
            this.tipoPaciente = tipo;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                frmGeneracionReceta ventanaConsulta = new frmGeneracionReceta();

                ventanaConsulta.Show();

                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la consulta: " + ex.Message, "Error");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string motivoFinal = !string.IsNullOrWhiteSpace(txtMotivo.Text) ? txtMotivo.Text.Trim() : CboMotivo.SelectedItem?.ToString();
            string sintomasFinal = !string.IsNullOrWhiteSpace(txtSintomas.Text) ? txtSintomas.Text.Trim() : cboSintomas.SelectedItem?.ToString();
            string diagnosticoFinal = !string.IsNullOrWhiteSpace(TxtDiagnostico.Text) ? TxtDiagnostico.Text.Trim() : cboDiagnostico.SelectedItem?.ToString();

            string presion = txtPrecion?.Text.Trim() ?? "";
            string temperatura = txtTemperatura?.Text.Trim() ?? "";

            if (string.IsNullOrEmpty(motivoFinal) || string.IsNullOrEmpty(diagnosticoFinal))
            {
                MessageBox.Show("Por favor, seleccione o escriba al menos el Motivo y el Diagnóstico.", "Campos Incompletos");
                return;
            }

            Conexion conexionBD = new Conexion();
            MySqlConnection conexionAbierta = conexionBD.obtenerconexion();

            if (conexionAbierta != null)
            {
                MySqlTransaction transaccion = null;
                try
                {
                    transaccion = conexionAbierta.BeginTransaction();

                    int idExpediente = 0;
                    string queryBuscarExp = @"SELECT d.Id_Expediente 
                                      FROM Consulta c
                                      INNER JOIN Diagnostico d ON c.Id_Diagnostico = d.Id_Diagnostico
                                      WHERE c.Matricula_Alumno = @id OR c.Num_Trabajador = @id 
                                      LIMIT 1;";

                    using (MySqlCommand cmdBuscar = new MySqlCommand(queryBuscarExp, conexionAbierta, transaccion))
                    {
                        cmdBuscar.Parameters.AddWithValue("@id", idPaciente);
                        object resultado = cmdBuscar.ExecuteScalar();
                        if (resultado != null)
                        {
                            idExpediente = Convert.ToInt32(resultado);
                        }
                    }

                    if (idExpediente == 0)
                    {
                        throw new Exception("No se encontró el expediente asociado a este paciente.");
                    }

                    string queryDiag = "INSERT INTO diagnostico (Diagnostico, Id_Expediente) VALUES (@diag, @idExp);";
                    long idNuevoDiagnostico = 0;

                    using (MySqlCommand cmdDiag = new MySqlCommand(queryDiag, conexionAbierta, transaccion))
                    {
                        cmdDiag.Parameters.AddWithValue("@diag", diagnosticoFinal);
                        cmdDiag.Parameters.AddWithValue("@idExp", idExpediente);
                        cmdDiag.ExecuteNonQuery();
                        idNuevoDiagnostico = cmdDiag.LastInsertedId;
                    }

                    string queryUpdateExp = "UPDATE expediente SET Motivo_Consulta = @motivo WHERE Id_Expediente = @idExp;";

                    using (MySqlCommand cmdUpdateExp = new MySqlCommand(queryUpdateExp, conexionAbierta, transaccion))
                    {
                        cmdUpdateExp.Parameters.AddWithValue("@motivo", motivoFinal);
                        cmdUpdateExp.Parameters.AddWithValue("@idExp", idExpediente);
                        cmdUpdateExp.ExecuteNonQuery();
                    }

                    string queryConsulta = @"INSERT INTO consulta (Matricula_Alumno, Num_Trabajador, Cedula_Doctora, Id_Enfermera, Id_Diagnostico, Fecha, Sintomas, Presion, Temperatura) 
                                     VALUES (@matAlu, @numTrab, NULL, NULL, @idDiag, CURDATE(), @sintomas, @presion, @temperatura);";

                    using (MySqlCommand cmdConsulta = new MySqlCommand(queryConsulta, conexionAbierta, transaccion))
                    {
                        cmdConsulta.Parameters.AddWithValue("@matAlu", tipoPaciente == "Alumno" ? idPaciente : (object)DBNull.Value);
                        cmdConsulta.Parameters.AddWithValue("@numTrab", tipoPaciente == "Trabajador" ? idPaciente : (object)DBNull.Value);
                        cmdConsulta.Parameters.AddWithValue("@idDiag", idNuevoDiagnostico);
                        cmdConsulta.Parameters.AddWithValue("@sintomas", sintomasFinal);
                        cmdConsulta.Parameters.AddWithValue("@presion", presion);
                        cmdConsulta.Parameters.AddWithValue("@temperatura", temperatura);

                        cmdConsulta.ExecuteNonQuery();
                    }

                    transaccion.Commit();
                    MessageBox.Show("Consulta guardada correctamente en la base de datos.", "Éxito");

                }
                catch (Exception ex)
                {
                    transaccion?.Rollback();
                    MessageBox.Show("Error al registrar la consulta: " + ex.Message, "Error");
                }
                finally
                {
                    conexionAbierta.Close();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void FrmConsultas_Load(object sender, EventArgs e)
        {
            if (frmBusquedaAlumnos.UsuarioTipo != null && frmBusquedaAlumnos.UsuarioTipo.Trim().ToLower() == "enfermera")
            {
                btnReceta.Enabled = false;
                btnReceta.Visible = false;
            }
            else
            {
                btnReceta.Enabled = true;
                btnReceta.Visible = true;
            }
        }

        private void cboDiagnostico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            HISTORIAL.HISTORIAL frmHistorial = new HISTORIAL.HISTORIAL();
            frmHistorial.Show();

            this.Close();
        }
    }
}
