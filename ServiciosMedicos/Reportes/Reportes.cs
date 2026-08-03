using System;
using System.Data;
using System.Drawing;
using System.Text;
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
                CargarOpcionesReporte();
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

     
        
     
        private void CargarOpcionesReporte()
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
                CboDIagnostico.Enabled = false;
                CboDIagnostico.Items.Add("Todos los registros");
                CboDIagnostico.SelectedIndex = 0;
                return;
            }

            CboDIagnostico.Enabled = true;

            try
            {
                using (var conn = ObtenerConexion())
                {
                    conn.Open();
                    string query = "";

                    switch (CboGrupo.SelectedItem.ToString())
                    {
                        case "Mensual":
                            query = "SELECT DISTINCT DATE_FORMAT(fecha_consulta,'%Y-%m') AS valor " +
                                    "FROM consulta WHERE fecha_consulta IS NOT NULL ORDER BY valor DESC";
                            break;
                        case "Diario":
                            query = "SELECT DISTINCT DATE_FORMAT(fecha_consulta,'%Y-%m-%d') AS valor " +
                                    "FROM consulta WHERE fecha_consulta IS NOT NULL ORDER BY valor DESC";
                            break;
                        case "Fecha específica":
                            query = "SELECT DISTINCT fecha_consulta AS valor " +
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
            if (cboOpciones.SelectedIndex == -1 || CboGrupo.SelectedIndex == -1) return;

            try
            {
                using (var conn = ObtenerConexion())
                {
                    conn.Open();
                    string query = ConstruirQuery();
                    var cmd = new MySqlCommand(query, conn);

                    if (CboGrupo.SelectedIndex > 0 && CboDIagnostico.SelectedIndex >= 0)
                    {
                        string valor = CboDIagnostico.SelectedItem.ToString();
                        switch (CboGrupo.SelectedItem.ToString())
                        {
                            case "Mensual":
                                cmd.Parameters.AddWithValue("@periodo", valor + "%");
                                break;
                            case "Diario":
                            case "Fecha específica":
                                cmd.Parameters.AddWithValue("@fecha", valor);
                                break;
                        }
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

   
        private string ConstruirQuery()
        {
            string periodo = CboGrupo.SelectedItem.ToString();
            string area = CboDia.SelectedIndex > 0 ? CboDia.SelectedItem.ToString() : "";

            // Filtro de tiempo
            string whereTiempo = "";
            if (periodo == "Mensual")
                whereTiempo = " AND c.fecha_consulta LIKE @periodo ";
            else if (periodo == "Diario" || periodo == "Fecha específica")
                whereTiempo = " AND c.fecha_consulta = @fecha ";

            // Filtro de área
            string whereArea = "";
            if (!string.IsNullOrEmpty(area))
                whereArea = " AND ar.nombre_area = @area ";

            switch (cboOpciones.SelectedIndex)
            {
                case 0: // Consultas realizadas
                    return $@"
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

                case 1: // Diagnósticos frecuentes
                    return $@"
                        SELECT 
                            d.diagnostico AS 'DIAGNOSTICO',
                            COUNT(*) AS 'CANTIDAD CASOS',
                            COUNT(DISTINCT c.matricula_alumno) AS 'PACIENTES AFECTADOS',
                            c.fecha_consulta AS 'FECHA'
                        FROM diagnostico d
                        JOIN consulta c ON d.id_consulta = c.id_consulta
                        JOIN alumno al ON c.matricula_alumno = al.matricula
                        LEFT JOIN areas ar ON al.id_area = ar.id_area
                        WHERE 1=1 {whereTiempo} {whereArea}
                        GROUP BY d.diagnostico, c.fecha_consulta
                        ORDER BY COUNT(*) DESC, c.fecha_consulta DESC";

                case 2: // Medicamentos recetados
                    return $@"
                        SELECT 
                            dm.nombre_medicamento AS 'MEDICAMENTO',
                            SUM(dm.cant_medicamento) AS 'CANTIDAD RECETADA',
                            COUNT(DISTINCT dm.id_receta) AS 'N° RECETAS',
                            i.cantidad AS 'STOCK ACTUAL'
                        FROM detallemedicamento dm
                        JOIN receta r ON dm.id_receta = r.id_receta
                        JOIN diagnostico d ON r.id_diagnostico = d.id_diagnostico
                        JOIN consulta c ON d.id_consulta = c.id_consulta
                        JOIN alumno al ON c.matricula_alumno = al.matricula
                        LEFT JOIN inventario i ON dm.id_medicamento = i.id_medicamento
                        LEFT JOIN areas ar ON al.id_area = ar.id_area
                        WHERE 1=1 {whereTiempo} {whereArea}
                        GROUP BY dm.id_medicamento, dm.nombre_medicamento
                        ORDER BY SUM(dm.cant_medicamento) DESC";

                case 3: // Pacientes por área
                    return $@"
                        SELECT 
                            ar.nombre_area AS 'AREA',
                            COUNT(DISTINCT al.matricula) AS 'CANTIDAD PACIENTES',
                            COUNT(c.id_consulta) AS 'TOTAL CONSULTAS'
                        FROM areas ar
                        LEFT JOIN alumno al ON ar.id_area = al.id_area
                        LEFT JOIN consulta c ON al.matricula = c.matricula_alumno
                        WHERE 1=1 {whereTiempo} {whereArea}
                        GROUP BY ar.id_area, ar.nombre_area
                        ORDER BY COUNT(DISTINCT al.matricula) DESC";

                case 4: // Atenciones por personal
                    return $@"
                        SELECT 
                            CONCAT(doc.nombre,' ',doc.apellido_p) AS 'DOCTORA',
                            CONCAT(enf.nombre,' ',enf.apellido_p) AS 'ENFERMERA',
                            COUNT(*) AS 'CANTIDAD ATENCIONES',
                            c.fecha_consulta AS 'FECHA'
                        FROM consulta c
                        JOIN doctora doc ON c.cedula_doctora = doc.cedula
                        JOIN enfermera enf ON c.id_enfermera = enf.id_enfermera
                        JOIN alumno al ON c.matricula_alumno = al.matricula
                        LEFT JOIN areas ar ON al.id_area = ar.id_area
                        WHERE 1=1 {whereTiempo} {whereArea}
                        GROUP BY doc.cedula, enf.id_enfermera, c.fecha_consulta
                        ORDER BY COUNT(*) DESC";

                case 5: // Inventario
                    return @"
                        SELECT 
                            nombre_medicamento AS 'MEDICAMENTO',
                            cantidad AS 'CANTIDAD',
                            fecha_caducidad AS 'CADUCIDAD',
                            estado AS 'ESTADO',
                            CASE 
                                WHEN cantidad = 0 THEN 'AGOTADO'
                                WHEN cantidad < 10 THEN 'BAJO STOCK'
                                ELSE 'OK'
                            END AS 'ALERTA'
                        FROM inventario
                        ORDER BY cantidad ASC";

                default:
                    return "SELECT 'Seleccione un reporte' AS MENSAJE";
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