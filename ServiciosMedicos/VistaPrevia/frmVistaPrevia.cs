using ServiciosMedicos.GeneracionReceta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static ServiciosMedicos.GeneracionReceta.frmGeneracionReceta;

namespace ServiciosMedicos.VistaPrevia
{
    public partial class frmVistaPrevia : Form
    {
        // Campos privados
        private string _nombreDoctora;
        private string _cedulaDoctora;
        private string _nombrePaciente;
        private string _matricula;
        private string _area;
        private string _edad;
        private string _sexo;
        private string _fecha;
        private List<MedicamentoReceta> _medicamentos;

        // NUEVO: Guardar datos del paciente para devolverlos al regresar
        private string _idPaciente;
        private string _tipoPaciente;

        // Constructor VACÍO — el diseñador lo necesita
        public frmVistaPrevia()
        {
            InitializeComponent();
        }

        // Método que recibe los datos
        public void CargarDatos(
            string nombreDoctora,
            string cedulaDoctora,
            string nombrePaciente,
            string matricula,
            string area,
            string edad,
            string sexo,
            string fecha,
            List<MedicamentoReceta> medicamentos)
        {
            _nombreDoctora = nombreDoctora;
            _cedulaDoctora = cedulaDoctora;
            _nombrePaciente = nombrePaciente;
            _matricula = matricula;
            _area = area;
            _edad = edad;
            _sexo = sexo;
            _fecha = fecha;
            _medicamentos = medicamentos ?? new List<MedicamentoReceta>();

            LlenarControles();
        }

        // NUEVO: Recibir y guardar los datos del paciente
        public void PassDatosPaciente(string id, string tipo)
        {
            _idPaciente = id;
            _tipoPaciente = tipo;
        }

        private void LlenarControles()
        {
            lblDoctora.Text = "DRA. " + (_nombreDoctora ?? "");
            lblCedula.Text = "MÉDICA GENERAL, CÉDULA PROFESIONAL " + (_cedulaDoctora ?? "");

            lblNombre.Text = _nombrePaciente ?? "";
            lblMatricula.Text = _matricula ?? "";
            lblArea.Text = _area ?? "";
            lblEdad.Text = _edad ?? "";
            lblSexo.Text = _sexo ?? "";
            lblFecha.Text = _fecha ?? "";

            LlenarMedicamentos();
        }

        private void LlenarMedicamentos()
        {
            dgvMP.Columns.Clear();
            dgvMP.AutoGenerateColumns = false;
            dgvMP.Columns.Add("colMedicamento", "Medicamentos");
            dgvMP.Columns.Add("colIndicaciones", "Indicaciones");
            dgvMP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvMP.Rows.Clear();
            foreach (var med in _medicamentos)
            {
                dgvMP.Rows.Add(med.Nombre, med.Indicaciones);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGeneracionReceta frmReceta = new frmGeneracionReceta();

            // NUEVO: Pasarle los datos del paciente antes de mostrarlo
            if (!string.IsNullOrEmpty(_idPaciente))
            {
                frmReceta.PassDatosPaciente(_idPaciente, _tipoPaciente);
            }

            frmReceta.Show();
            this.Close();
        }
    }
}