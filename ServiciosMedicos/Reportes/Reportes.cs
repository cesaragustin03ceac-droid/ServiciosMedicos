using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace ServiciosMedicos.Reportes
{
    public partial class Reportes : Form
    {
        // Clase auxiliar para mostrar nombre del mes en el ComboBox
        private class MesItem
        {
            public string Texto { get; set; } // Ej: "Julio 2026"
            public string Valor { get; set; } // Ej: "2026-07"
        }

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

            if (dtpFechaEspecifica != null)
                this.dtpFechaEspecifica.ValueChanged += new System.EventHandler(this.dtpFechaEspecifica_ValueChanged);
            if (dtpFechaInicio != null)
                this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            if (dtpFechaFin != null)
                this.dtpFechaFin.ValueChanged += new System.EventHandler(this.dtpFechaFin_ValueChanged);
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            try
            {
                // Ocultar todos los DateTimePicker al inicio
                if (dtpFechaEspecifica != null)
                {
                    dtpFechaEspecifica.Visible = false;
                    dtpFechaEspecifica.Enabled = false;
                    dtpFechaEspecifica.Format = DateTimePickerFormat.Short;
                }
                if (dtpFechaInicio != null)
                {
                    dtpFechaInicio.Visible = false;
                    dtpFechaInicio.Enabled = false;
                    dtpFechaInicio.Format = DateTimePickerFormat.Short;
                }
                if (dtpFechaFin != null)
                {
                    dtpFechaFin.Visible = false;
                    dtpFechaFin.Enabled = false;
                    dtpFechaFin.Format = DateTimePickerFormat.Short;
                }

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
            cboOpciones.Items.Add("Consultas realizadas");
            cboOpciones.SelectedIndex = 0;
        }

        private void CargarPeriodos()
        {
            CboGrupo.Items.Clear();
            CboGrupo.Items.Add("Todos");
            CboGrupo.Items.Add("Mensual");
            CboGrupo.Items.Add("Diario");
            CboGrupo.Items.Add("Fecha específica");
            CboGrupo.Items.Add("Rango de fechas"); // <-- NUEVA OPCIÓN
            CboGrupo.SelectedIndex = 0;
        }

        private void CargarValoresPeriodo()
        {
            // Limpiar cualquier DataSource anterior
            CboDIagnostico.DataSource = null;
            CboDIagnostico.Items.Clear();

            if (CboGrupo.SelectedIndex < 0) return;

            string tipo = CboGrupo.SelectedItem.ToString();

            // Modo "Todos": sin selección de mes
            if (tipo == "Todos")
            {
                CboDIagnostico.DropDownStyle = ComboBoxStyle.DropDownList;
                CboDIagnostico.Enabled = false;
                CboDIagnostico.Items.Add("Todos los registros");
                CboDIagnostico.SelectedIndex = 0;
                return;
            }

            // Modo "Fecha específica" o "Rango de fechas": usa calendarios
            if (tipo == "Fecha específica" || tipo == "Rango de fechas")
            {
                CboDIagnostico.DropDownStyle = ComboBoxStyle.DropDownList;
                CboDIagnostico.Enabled = false;
                CboDIagnostico.Items.Add("—");
                CboDIagnostico.SelectedIndex = 0;
                return;
            }

            // "Mensual" y "Diario": cargan los MESES con nombre (ej. "Julio 2026")
            CboDIagnostico.DropDownStyle = ComboBoxStyle.DropDownList;
            CboDIagnostico.Enabled = true;

            try
            {
                var listaMeses = new List<MesItem>();
                using (var conn = ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT DISTINCT DATE_FORMAT(fecha_consulta,'%Y-%m') AS valor, " +
                                   "MIN(fecha_consulta) AS fecha_muestra " +
                                   "FROM consulta WHERE fecha_consulta IS NOT NULL " +
                                   "GROUP BY DATE_FORMAT(fecha_consulta,'%Y-%m') ORDER BY valor DESC";

                    var cmd = new MySqlCommand(query, conn);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string valor = reader["valor"].ToString(); // "2026-07"
                        DateTime fechaMuestra = Convert.ToDateTime(reader["fecha_muestra"]);
                        string texto = fechaMuestra.ToString("MMMM yyyy", new CultureInfo("es-ES"));
                        // Capitalizar primera letra: "julio 2026" → "Julio 2026"
                        texto = char.ToUpper(texto[0]) + texto.Substring(1);
                        listaMeses.Add(new MesItem { Texto = texto, Valor = valor });
                    }
                }

                CboDIagnostico.DisplayMember = "Texto";
                CboDIagnostico.ValueMember = "Valor";
                CboDIagnostico.DataSource = listaMeses;

                if (CboDIagnostico.Items.Count > 0)
                    CboDIagnostico.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando meses: " + ex.Message);
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

        private void cboOpciones_SelectedIndexChanged(object sender, EventArgs e) { GenerarReporte(); }

        private void CboGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = CboGrupo.SelectedItem?.ToString() ?? "";

            // Mostrar/ocultar DateTimePicker según el modo seleccionado
            if (dtpFechaEspecifica != null)
            {
                dtpFechaEspecifica.Visible = (tipo == "Fecha específica");
                dtpFechaEspecifica.Enabled = (tipo == "Fecha específica");
            }

            if (dtpFechaInicio != null)
            {
                dtpFechaInicio.Visible = (tipo == "Rango de fechas");
                dtpFechaInicio.Enabled = (tipo == "Rango de fechas");
            }

            if (dtpFechaFin != null)
            {
                dtpFechaFin.Visible = (tipo == "Rango de fechas");
                dtpFechaFin.Enabled = (tipo == "Rango de fechas");
            }

            CargarValoresPeriodo();
            GenerarReporte();
        }

        private void CboDIagnostico_SelectedIndexChanged(object sender, EventArgs e) { GenerarReporte(); }
        private void CboDia_SelectedIndexChanged(object sender, EventArgs e) { GenerarReporte(); }
        private void dtpFechaEspecifica_ValueChanged(object sender, EventArgs e) { GenerarReporte(); }
        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e) { GenerarReporte(); }
        private void dtpFechaFin_ValueChanged(object sender, EventArgs e) { GenerarReporte(); }

        private void GenerarReporte()
        {
            if (CboGrupo.SelectedIndex < 0 || CboDia.SelectedIndex < 0) return;

            string periodo = CboGrupo.SelectedItem.ToString();
            string area = CboDia.SelectedItem.ToString();

            // Obtener el valor YYYY-MM del ComboBox (funciona con DataSource de MesItem)
            string mesSeleccionado = "";
            if (CboDIagnostico.Enabled && CboDIagnostico.DataSource != null && CboDIagnostico.SelectedItem is MesItem mesItem)
            {
                mesSeleccionado = mesItem.Valor;
            }

            // Base de la consulta: une alumnos y trabajadores con sus áreas
            string sqlBase = @"
                FROM consulta c
                LEFT JOIN alumno al ON c.matricula_alumno = al.matricula
                LEFT JOIN trabajador t ON c.num_trabajador = t.num_trabajador
                LEFT JOIN areas ar ON COALESCE(al.id_area, t.id_area) = ar.id_area
                WHERE c.fecha_consulta IS NOT NULL ";

            var parametros = new List<MySqlParameter>();

            // Filtro por Área
            if (area != "Todas las áreas")
            {
                sqlBase += " AND ar.nombre_area = @area ";
                parametros.Add(new MySqlParameter("@area", area));
            }

            string sql = "";
            string groupBy = "";
            string orderBy = "";

            switch (periodo)
            {
                case "Todos":
                    // Acumulado general: por MES y ÁREA
                    sql = @"
                        SELECT DATE_FORMAT(c.fecha_consulta, '%Y-%m') AS `MES`,
                               COALESCE(ar.nombre_area, 'Sin área') AS `ÁREA`,
                               COUNT(*) AS `TOTAL CONSULTAS`,
                               COUNT(DISTINCT COALESCE(c.matricula_alumno, c.num_trabajador)) AS `PACIENTES ÚNICOS` ";
                    groupBy = " GROUP BY DATE_FORMAT(c.fecha_consulta, '%Y-%m'), COALESCE(ar.nombre_area, 'Sin área') ";
                    orderBy = " ORDER BY DATE_FORMAT(c.fecha_consulta, '%Y-%m') DESC, COALESCE(ar.nombre_area, 'Sin área') ";
                    break;

                case "Mensual":
                    // Resumen del MES seleccionado: solo por ÁREA
                    if (!string.IsNullOrEmpty(mesSeleccionado))
                    {
                        sqlBase += " AND DATE_FORMAT(c.fecha_consulta, '%Y-%m') = @mes ";
                        parametros.Add(new MySqlParameter("@mes", mesSeleccionado));
                    }
                    sql = @"
                        SELECT COALESCE(ar.nombre_area, 'Sin área') AS `ÁREA`,
                               COUNT(*) AS `TOTAL CONSULTAS`,
                               COUNT(DISTINCT COALESCE(c.matricula_alumno, c.num_trabajador)) AS `PACIENTES ÚNICOS` ";
                    groupBy = " GROUP BY COALESCE(ar.nombre_area, 'Sin área') ";
                    orderBy = " ORDER BY COALESCE(ar.nombre_area, 'Sin área') ";
                    break;

                case "Diario":
                    // Desglose DIARIO del MES seleccionado: por DÍA y ÁREA
                    if (!string.IsNullOrEmpty(mesSeleccionado))
                    {
                        sqlBase += " AND DATE_FORMAT(c.fecha_consulta, '%Y-%m') = @mes ";
                        parametros.Add(new MySqlParameter("@mes", mesSeleccionado));
                    }
                    sql = @"
                        SELECT DATE_FORMAT(c.fecha_consulta, '%Y-%m-%d') AS `DÍA`,
                               COALESCE(ar.nombre_area, 'Sin área') AS `ÁREA`,
                               COUNT(*) AS `TOTAL CONSULTAS`,
                               COUNT(DISTINCT COALESCE(c.matricula_alumno, c.num_trabajador)) AS `PACIENTES ÚNICOS` ";
                    groupBy = " GROUP BY DATE_FORMAT(c.fecha_consulta, '%Y-%m-%d'), COALESCE(ar.nombre_area, 'Sin área') ";
                    orderBy = " ORDER BY DATE_FORMAT(c.fecha_consulta, '%Y-%m-%d'), COALESCE(ar.nombre_area, 'Sin área') ";
                    break;

                case "Fecha específica":
                    // Día exacto del calendario: por ÁREA
                    if (dtpFechaEspecifica != null)
                    {
                        sqlBase += " AND c.fecha_consulta = @fecha ";
                        parametros.Add(new MySqlParameter("@fecha", dtpFechaEspecifica.Value.Date));
                    }
                    sql = @"
                        SELECT COALESCE(ar.nombre_area, 'Sin área') AS `ÁREA`,
                               COUNT(*) AS `TOTAL CONSULTAS`,
                               COUNT(DISTINCT COALESCE(c.matricula_alumno, c.num_trabajador)) AS `PACIENTES ÚNICOS` ";
                    groupBy = " GROUP BY COALESCE(ar.nombre_area, 'Sin área') ";
                    orderBy = " ORDER BY COALESCE(ar.nombre_area, 'Sin área') ";
                    break;

                case "Rango de fechas":
                    // NUEVO: Filtrar entre fecha inicio y fecha fin
                    if (dtpFechaInicio != null && dtpFechaFin != null)
                    {
                        // Validar que fecha inicio no sea mayor que fecha fin
                        if (dtpFechaInicio.Value.Date > dtpFechaFin.Value.Date)
                        {
                            // No mostrar error constante, solo no ejecutar
                            dataGridView1.DataSource = null;
                            return;
                        }

                        sqlBase += " AND c.fecha_consulta BETWEEN @fechaInicio AND @fechaFin ";
                        parametros.Add(new MySqlParameter("@fechaInicio", dtpFechaInicio.Value.Date));
                        parametros.Add(new MySqlParameter("@fechaFin", dtpFechaFin.Value.Date));
                    }
                    // Agrupado por DÍA y ÁREA dentro del rango
                    sql = @"
                        SELECT DATE_FORMAT(c.fecha_consulta, '%Y-%m-%d') AS `DÍA`,
                               COALESCE(ar.nombre_area, 'Sin área') AS `ÁREA`,
                               COUNT(*) AS `TOTAL CONSULTAS`,
                               COUNT(DISTINCT COALESCE(c.matricula_alumno, c.num_trabajador)) AS `PACIENTES ÚNICOS` ";
                    groupBy = " GROUP BY DATE_FORMAT(c.fecha_consulta, '%Y-%m-%d'), COALESCE(ar.nombre_area, 'Sin área') ";
                    orderBy = " ORDER BY DATE_FORMAT(c.fecha_consulta, '%Y-%m-%d'), COALESCE(ar.nombre_area, 'Sin área') ";
                    break;
            }

            string queryFinal = sql + sqlBase + groupBy + orderBy;

            try
            {
                using (var conn = ObtenerConexion())
                {
                    conn.Open();
                    var cmd = new MySqlCommand(queryFinal, conn);
                    cmd.Parameters.AddRange(parametros.ToArray());

                    var adapter = new MySqlDataAdapter(cmd);
                    var dt = new DataTable();
                    adapter.Fill(dt);

                    // Convertir fechas técnicas a nombres legibles en español
                    FormatearNombresMesEnTabla(dt, periodo);

                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generando reporte: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Convierte las fechas técnicas del DataTable a nombres legibles en español
        /// </summary>
        private void FormatearNombresMesEnTabla(DataTable dt, string periodo)
        {
            var culturaEs = new CultureInfo("es-ES");

            foreach (DataRow row in dt.Rows)
            {
                // Modo "Todos": columna MES (formato 2026-07)
                if (dt.Columns.Contains("MES") && row["MES"] != DBNull.Value)
                {
                    string valor = row["MES"].ToString(); // "2026-07"
                    if (DateTime.TryParseExact(valor, "yyyy-MM", CultureInfo.InvariantCulture,
                        DateTimeStyles.None, out DateTime fecha))
                    {
                        string texto = fecha.ToString("MMMM yyyy", culturaEs);
                        row["MES"] = char.ToUpper(texto[0]) + texto.Substring(1); // "Julio 2026"
                    }
                }

                // Modo "Diario" o "Rango de fechas": columna DÍA (formato 2026-07-27)
                if (dt.Columns.Contains("DÍA") && row["DÍA"] != DBNull.Value)
                {
                    string valor = row["DÍA"].ToString(); // "2026-07-27"
                    if (DateTime.TryParseExact(valor, "yyyy-MM-dd", CultureInfo.InvariantCulture,
                        DateTimeStyles.None, out DateTime fecha))
                    {
                        string texto = fecha.ToString("dd 'de' MMMM 'de' yyyy", culturaEs);
                        row["DÍA"] = char.ToUpper(texto[0]) + texto.Substring(1); // "27 de julio de 2026"
                    }
                }
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e) { GenerarReporte(); }
        private void btnRegresar_Click(object sender, EventArgs e) { this.Close(); }
    }
}