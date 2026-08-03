using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ServiciosMedicos.Reportes
{
    public partial class Reportes : Form
    {
        private MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(
                "Server=localhost;Database=sistema_medico;Uid=root;Pwd=;Port=3306;Charset=utf8mb4;");
        }

        public Reportes()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.cboOpciones.SelectedIndexChanged += new System.EventHandler(this.cboOpciones_SelectedIndexChanged);
            this.CboGrupo.SelectedIndexChanged += new System.EventHandler(this.CboGrupo_SelectedIndexChanged);
            this.CboDIagnostico.SelectedIndexChanged += new System.EventHandler(this.CboDIagnostico_SelectedIndexChanged);
            this.CboDia.SelectedIndexChanged += new System.EventHandler(this.CboDia_SelectedIndexChanged);
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            try
            {
                CargarOpciones();
                CargarPeriodos();
                CargarAreas();
                CargarValoresPeriodo();
                GenerarReporte();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void CargarOpciones()
        {
            cboOpciones.Items.Clear();
            cboOpciones.Items.Add("1. Consultas realizadas");
            cboOpciones.Items.Add("2. Diagnósticos frecuentes");
            cboOpciones.Items.Add("3. Medicamentos recetados");
            cboOpciones.Items.Add("4. Pacientes por área");
            cboOpciones.Items.Add("5. Atenciones por personal médico");
            cboOpciones.Items.Add("6. Inventario de medicamentos");
            cboOpciones.SelectedIndex = 0;
        }

        private void CargarPeriodos()
        {
            CboGrupo.Items.Clear();
            CboGrupo.Items.Add("Todos");
            CboGrupo.Items.Add("Mensual");
            CboGrupo.Items.Add("Diario");
            CboGrupo.Items.Add("Fecha específica");
            CboGrupo.SelectedIndex = 0;
        }

        private void CargarValoresPeriodo()
        {
            CboDIagnostico.Items.Clear();

            if (CboGrupo.SelectedIndex <= 0)
            {
                CboDIagnostico.DropDownStyle = ComboBoxStyle.DropDownList;
                CboDIagnostico.Enabled = false;
                CboDIagnostico.Items.Add("Todos los registros");
                CboDIagnostico.SelectedIndex = 0;
                return;
            }

            string tipo = CboGrupo.SelectedItem.ToString();

            if (tipo == "Fecha específica")
            {
                CboDIagnostico.DropDownStyle = ComboBoxStyle.DropDownList;
                CboDIagnostico.Enabled = false;
                CboDIagnostico.Items.Add("No disponible");
                CboDIagnostico.SelectedIndex = 0;
                return;
            }

            CboDIagnostico.DropDownStyle = ComboBoxStyle.DropDownList;
            CboDIagnostico.Enabled = true;

            try
            {
                using (var conn = ObtenerConexion())
                {
                    conn.Open();
                    string query = "";

                    switch (tipo)
                    {
                        case "Mensual":
                            query = "SELECT DISTINCT DATE_FORMAT(fecha_consulta,'%Y-%m') AS valor " +
                                    "FROM consulta WHERE fecha_consulta IS NOT NULL ORDER BY valor DESC";
                            break;
                        case "Diario":
                            query = "SELECT DISTINCT DATE_FORMAT(fecha_consulta,'%Y-%m-%d') AS valor " +
                                    "FROM consulta WHERE fecha_consulta IS NOT NULL ORDER BY valor DESC";
                            break;
                    }

                    if (!string.IsNullOrEmpty(query))
                    {
                        var cmd = new MySqlCommand(query, conn);
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            CboDIagnostico.Items.Add(reader["valor"].ToString());
                        }
                    }
                }

                if (CboDIagnostico.Items.Count > 0)
                    CboDIagnostico.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando fechas: " + ex.Message);
            }
        }

        private void CargarAreas()
        {
            CboDia.Items.Clear();
            CboDia.Items.Add("Todas las áreas");

            try
            {
                using (var conn = ObtenerConexion())
                {
                    conn.Open();
                    var cmd = new MySqlCommand("SELECT nombre_area FROM areas ORDER BY nombre_area", conn);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        CboDia.Items.Add(reader["nombre_area"].ToString());
                    }
                }
                CboDia.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando áreas: " + ex.Message);
            }
        }

        private void cboOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerarReporte();
        }

        private void CboGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarValoresPeriodo();
            GenerarReporte();
        }

        private void CboDIagnostico_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerarReporte();
        }

        private void CboDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerarReporte();
        }

        private void GenerarReporte()
        {
         
            if (cboOpciones.SelectedIndex != 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
                return;
            }

       
            if (CboGrupo.SelectedItem?.ToString() == "Fecha específica")
            {
                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
                return;
            }

            if (CboGrupo.SelectedIndex == -1) return;

            try
            {
                using (var conn = ObtenerConexion())
                {
                    conn.Open();

                    string whereTiempo = "";
                    string whereArea = "";

                    // Filtro tiempo
                    if (CboGrupo.SelectedIndex > 0)
                    {
                        string tipo = CboGrupo.SelectedItem.ToString();
                        string valor = CboDIagnostico.SelectedItem?.ToString() ?? "";

                        switch (tipo)
                        {
                            case "Mensual":
                                whereTiempo = " AND c.fecha_consulta LIKE @filtro ";
                                break;
                            case "Diario":
                                whereTiempo = " AND c.fecha_consulta = @filtro ";
                                break;
                        }
                    }

                    if (CboDia.SelectedIndex > 0)
                    {
                        whereArea = " AND ar.nombre_area = @area ";
                    }

                    string query = $@"
                        SELECT 
                            c.fecha_consulta AS 'FECHA',
                            COUNT(*) AS 'CANTIDAD CONSULTAS',
                            COUNT(DISTINCT c.matricula_alumno) AS 'PACIENTES UNICOS'
                        FROM consulta c
                        JOIN alumno al ON c.matricula_alumno = al.matricula
                        LEFT JOIN areas ar ON al.id_area = ar.id_area
                        WHERE 1=1 {whereTiempo} {whereArea}
                        GROUP BY c.fecha_consulta
                        ORDER BY c.fecha_consulta DESC";

                    var cmd = new MySqlCommand(query, conn);

                    if (CboGrupo.SelectedIndex > 0)
                    {
                        string tipo = CboGrupo.SelectedItem.ToString();
                        string valor = CboDIagnostico.SelectedItem?.ToString() ?? "";

                        if (tipo == "Mensual")
                            cmd.Parameters.AddWithValue("@filtro", valor + "%");
                        else if (tipo == "Diario")
                            cmd.Parameters.AddWithValue("@filtro", valor);
                    }

                    if (CboDia.SelectedIndex > 0)
                    {
                        cmd.Parameters.AddWithValue("@area", CboDia.SelectedItem.ToString());
                    }

                    var adapter = new MySqlDataAdapter(cmd);
                    var dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;

                    foreach (DataGridViewColumn col in dataGridView1.Columns)
                        col.HeaderText = col.HeaderText.ToUpper();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generando reporte:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            GenerarReporte();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}