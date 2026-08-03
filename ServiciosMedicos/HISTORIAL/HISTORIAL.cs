using MySql.Data.MySqlClient;
using ServiciosMedicos.Busqueda;
using ServiciosMedicos.Consultas;
using ServiciosMedicos.DataConexion;
using ServiciosMedicos.GeneracionReceta;
using ServiciosMedicos.VistaPrevia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ServiciosMedicos.HISTORIAL
{
    public partial class HISTORIAL : Form
    {
        private string idPacienteActual;  // Variable privada. Guarda la matrícula o num. de trabajador del paciente mostrado.
        private string tipoPacienteActual;  // Variable privada. Guarda "Alumno" o "Trabajador".
        private string idExpedienteActual; // Variable privada. Guarda el ID numérico del expediente médico (para editarlo después).

        public HISTORIAL()  //  CONSTRUCTOR SE EJECUTA AL ABRIR LA VENTANA 
        {
            InitializeComponent();
            EstilarDataGridView(); //LLAMA AL METODO PARA ESTIRAR LA DATA GRED VI
            // DUBUJA UN B0RDE GRUESO
            groupBox1.Paint += DibujarBordeGrueso; 
            groupBox2perfil.Paint += DibujarBordeGrueso;
            groupBox3atenciones.Paint += DibujarBordeGrueso;
            button1.Paint += DibujarBordeGrueso;
            button2.Paint += DibujarBordeGrueso;
            //EVENTO DE CLIC EN CELDAS DE LA TABLA 
            dataGridView1atenciones.CellContentClick += dataGridView1atenciones_CellContentClick;
        }

        private void EstilarDataGridView()
        {
            dataGridView1atenciones.Columns.Clear(); // BORRA CUALQUIER COLUMNA ANTERIOR POR SI SE LLAMA 2 VECES 
            dataGridView1atenciones.EnableHeadersVisualStyles = false;  // DESACTIVA EL COLOR AZUL POR DEFECTO
            dataGridView1atenciones.AllowUserToResizeColumns = false; // EVITA QUE EL USUARIO ESTIRE LAS COLUMNAS
            dataGridView1atenciones.AllowUserToResizeRows = false;
            //ESTILO DEL ENCABEZADO LA FILA DE TITULOS 
            dataGridView1atenciones.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#6FA8DC"); // COLOR DE LA GUIA DE ESTILOS 
            dataGridView1atenciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;// TEXTO DEL ENCABEZADO DE NEGRO
            dataGridView1atenciones.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold); // TAMAÑO Y TIPO DE FUENTE 
            dataGridView1atenciones.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // CENTRA EL TEXTO VERTICALMENTE Y HORIZONTALMENTE 
            dataGridView1atenciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1atenciones.ColumnHeadersHeight = 35; // ALTURA FIJA NO SE ESTIRA NI SE HACE MAS PEQUEÑA 
            dataGridView1atenciones.BackgroundColor = Color.White; // FOND0O DE LA TABLA 
            dataGridView1atenciones.BorderStyle = BorderStyle.FixedSingle; // LINEAS DIVISORAS ENTRE CELDAS 
            dataGridView1atenciones.CellBorderStyle = DataGridViewCellBorderStyle.Single; //LIENAS DIVISORAS 
            dataGridView1atenciones.GridColor = Color.Black; // COLOR DE LAS LIENAS 
            dataGridView1atenciones.RowHeadersVisible = false; // OCULTA LA COLUMNA GRIS DE LA IZQUIERDA 
            dataGridView1atenciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // SE SELECCIONA TODO CUANDO EL USUARIO LE DA CLICK NO SOLO LA COLUMNA 
            dataGridView1atenciones.AllowUserToAddRows = false;// QUITA LAS FILAS VACIAS 
            dataGridView1atenciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // LAS COLUMNAS SE ESTIRAR PARA OCUPAR TODO EL ANCHO DISPONIBLE 

            dataGridView1atenciones.Columns.Add("colFecha", "Fecha"); // COLUMNA 0 FECHA 
            dataGridView1atenciones.Columns.Add("colMotivo", "Motivo");// COLUMNA 1 MOTIVO
            dataGridView1atenciones.Columns.Add("colDiagnostico", "Diagnostico");//COLUMNA 2 DIAGNOSTICO 

            DataGridViewLinkColumn colFormato = new DataGridViewLinkColumn();// COLUMNA ESPECIAL ES EL VINCULO
            colFormato.Name = "colFormato"; // NOMBRE DEL FORMATO 
            colFormato.HeaderText = "Formato";// LO QUE APARECE
            colFormato.UseColumnTextForLinkValue = false;// NO USA TEXTO FIJO CADA CELDA PUEDE TENER SU PROPIO TEXTO
            dataGridView1atenciones.Columns.Add(colFormato); // AGREGA LA COLUMNA ALA TABLA

            DataGridViewLinkColumn colReceta = new DataGridViewLinkColumn(); // VINCULO
            colReceta.Name = "colReceta"; //
            colReceta.HeaderText = "Receta";
            colReceta.UseColumnTextForLinkValue = false;
            dataGridView1atenciones.Columns.Add(colReceta);

            dataGridView1atenciones.Columns.Add("colIdConsulta", "ID"); // COLUMNA OCULTA GUARDA EL ID DE LA CONSULTA 
            dataGridView1atenciones.Columns["colIdConsulta"].Visible = false;
            // DISTRIBUICION DE ANCHOS 
            dataGridView1atenciones.Columns["colFecha"].FillWeight = 70;
            dataGridView1atenciones.Columns["colMotivo"].FillWeight = 90;
            dataGridView1atenciones.Columns["colDiagnostico"].FillWeight = 240;
            dataGridView1atenciones.Columns["colFormato"].FillWeight = 50;
            dataGridView1atenciones.Columns["colReceta"].FillWeight = 50;
        }
        
        // METODO QUE PINTA UN BORDE GRUESO  DE 3 PIXELES ALREDEDOR DE CUALQUIER TABLA O CAJA 
        private void DibujarBordeGrueso(object sender, PaintEventArgs e)
        {
            Control control = (Control)sender; // EL CONTROL QUE DISPARA EL EVENTO
            int grosor = 3;
            using (Pen lapizNegro = new Pen(Color.Black, grosor))
            {
                Rectangle rectangulo = new Rectangle(
                    grosor / 2,
                    grosor / 2,
                    control.Width - grosor,
                    control.Height - grosor
                );
                e.Graphics.DrawRectangle(lapizNegro, rectangulo); // LO DUBUJA
            }
        }
        // ESTE METODO RECIBE EL ID DEL PACIENTE Y EL TIPO 
        public void CargarPerfilPaciente(string idPaciente, string tipoPaciente)
        {
            this.idPacienteActual = idPaciente; //GUARDA SU ID PARA LUEGO USARLO 
            this.tipoPacienteActual = tipoPaciente;//GUARDA EL TIPO PACIENTE PARA LUEGO USARLO 
            this.idExpedienteActual = null; // REINICIA EL ID DEL EXPEDIENTE 

            Conexion conexionBD = new Conexion(); // OBJETO QUE CONECTA CON LA BASE DE DATOS 
            MySqlConnection conn = conexionBD.obtenerconexion();//ABRE LA CONEXION
            if (conn == null) return; // SI NO SE CONECTA SE SALE

            try //SI FALLA MUESTRA UN EROR
            {
                string query = "";
                // CONSULTA PARA EL ALUMNO 
                if (tipoPaciente == "Alumno")
                {
                    // UNE LA TABLA ALUMNOS CON AREA  EL LEFT JOIN ES TRAE EL ALUMNO AUNQUE NO TENGA AREA NI EXPEDIENTE 
                    query = @"SELECT a.matricula AS id, a.nombre, a.apellido_p, a.apellido_m,
                                     ar.nombre_area, 
                                     e.id_expediente, e.edad, e.nss, e.curp, e.sexo, 
                                     e.tipo_sangre, e.peso, e.talla, e.alergias, 
                                     e.enfermedades, e.revision_ocular
                              FROM alumno a
                              LEFT JOIN areas ar ON a.id_area = ar.id_area
                              LEFT JOIN expediente e ON e.curp = a.matricula
                              WHERE a.matricula = @id
                              LIMIT 1;";
                }
                else
                {// CONSULTA PARA EL TRABAJADOR 
                    query = @"SELECT t.num_trabajador AS id, t.nombre, t.apellido_p, t.apellido_m,
                                     ar.nombre_area, 
                                     e.id_expediente, e.edad, e.nss, e.curp, e.sexo, 
                                     e.tipo_sangre, e.peso, e.talla, e.alergias, 
                                     e.enfermedades, e.revision_ocular
                              FROM trabajador t
                              LEFT JOIN areas ar ON t.id_area = ar.id_area
                              LEFT JOIN expediente e ON e.curp = CAST(t.num_trabajador AS CHAR)
                              WHERE t.num_trabajador = @id
                              LIMIT 1;";
                }

                using (MySqlCommand cmd = new MySqlCommand(query, conn)) // PREPARA LA CONSULTA SQL
                {
                    cmd.Parameters.AddWithValue("@id", idPaciente);//SEGURIDAD EVITA EL SQL INJECTION

                    using (MySqlDataReader lector = cmd.ExecuteReader()) // SE EJECUTA Y ABRE EL LECTOR DE FILAS 
                    {
                        if (lector.Read()) // SI ENCUENTRA AL PACIENTE 
                        {
                            // SON LOS TEXBOX DE ARRIBA 
                            string nombre = lector["nombre"].ToString();
                            string apellidoP = lector["apellido_p"].ToString();
                            string apellidoM = lector["apellido_m"].ToString();
                            txtNombrePaciente.Text = $"{nombre} {apellidoP} {apellidoM}".Trim();
                            // CAMPOS DE ARRIBA 
                            txtArea.Text = ValorO_Vacio(lector["nombre_area"]);
                            txtEdad.Text = ValorO_Vacio(lector["edad"]);
                            //  ES DE LA DATAGRIDVIEW
                            PerfilPaciente.Columns.Clear(); // LIMPIA 
                            PerfilPaciente.AutoGenerateColumns = true; // GENERA COLUMNAS 
                             // CREA LAS TABLAS 
                            DataTable dtPerfil = new DataTable();
                            dtPerfil.Columns.Add("Sexo");
                            dtPerfil.Columns.Add("NSS");
                            dtPerfil.Columns.Add("CURP");
                            dtPerfil.Columns.Add("Tipo de Sangre");
                            dtPerfil.Columns.Add("Peso");
                            dtPerfil.Columns.Add("Talla");
                            dtPerfil.Columns.Add("Alergias");
                            dtPerfil.Columns.Add("Enfermedades");
                            dtPerfil.Columns.Add("Revisión Ocular");
                             // LENAN UNA FILA CON LOS DATOS 
                            DataRow fila = dtPerfil.NewRow();
                            fila["Sexo"] = ValorO_Vacio(lector["sexo"]);
                            fila["NSS"] = ValorO_Vacio(lector["nss"]);
                            fila["CURP"] = ValorO_Vacio(lector["curp"]);
                            fila["Tipo de Sangre"] = ValorO_Vacio(lector["tipo_sangre"]);
                            fila["Peso"] = ValorO_Vacio(lector["peso"]);
                            fila["Talla"] = ValorO_Vacio(lector["talla"]);
                            fila["Alergias"] = ValorO_Vacio(lector["alergias"]);
                            fila["Enfermedades"] = ValorO_Vacio(lector["enfermedades"]);
                            fila["Revisión Ocular"] = ValorO_Vacio(lector["revision_ocular"]);
                            dtPerfil.Rows.Add(fila);
                            // LO MUESTRAN EN LA TABLA 
                            PerfilPaciente.DataSource = dtPerfil;
                            PerfilPaciente.ReadOnly = true;
                            PerfilPaciente.AllowUserToAddRows = false;
                            PerfilPaciente.RowHeadersVisible = false;
                            PerfilPaciente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            // SE GUARDA EL ID DEL EXPEDIENTE SI EXISRTE PARA EDITARLO DESPUES 
                            if (lector["id_expediente"] != DBNull.Value)
                                this.idExpedienteActual = lector["id_expediente"].ToString();
                        }
                        else // MENSAJE SI NO SE ENCUENTRA EL PACIENTE
                        {
                            MessageBox.Show("No se encontró el paciente.", "Aviso");
                        }
                    }
                }
                // CARGA EL HISTORIAL DE ATENCIONES PASADAS 
                CargarAtenciones(idPaciente, tipoPaciente, conn);
            }
            catch (Exception ex) // SI HYA UN ERROR MUESTRA EL
            {
                MessageBox.Show("Error al cargar perfil: " + ex.Message, "Error");
            }
            finally
            {
                conn.Close(); // CIERRA LA CONEXION ALA BD 
            }
        }

        // LENA LA  TABALO DE ABAJO CPON LAS CONSULTAS PASADAS
        private void CargarAtenciones(string idPaciente, string tipoPaciente, MySqlConnection conn)
        {
            dataGridView1atenciones.Rows.Clear();

            string query = "";
            // CONSULTA DIFRENTE SI ES ALUMNO O TRABAJADOR 
            if (tipoPaciente == "Alumno")
            {
                query = @"SELECT c.id_consulta, c.fecha_consulta, e.motivo_consulta, d.diagnostico
                        FROM consulta c
                        LEFT JOIN diagnostico d ON c.id_consulta = d.id_consulta
                        LEFT JOIN expediente e ON d.id_expediente = e.id_expediente
                        WHERE c.matricula_alumno = @id
                        ORDER BY c.fecha_consulta DESC;"; // MAS RECIENTE LO MUESTRA PRIMERO 
            }
            else
            {
                query = @"SELECT c.id_consulta, c.fecha_consulta, e.motivo_consulta, d.diagnostico
                        FROM consulta c
                        LEFT JOIN diagnostico d ON c.id_consulta = d.id_consulta
                        LEFT JOIN expediente e ON d.id_expediente = e.id_expediente
                        WHERE c.num_trabajador = @id
                        ORDER BY c.fecha_consulta DESC;";
            }

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", idPaciente);

                using (MySqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read()) // MIENTRAS HAYA FILAS  SE EJCUTA LO DE ABAJO
                    { // SI ES NULL VA VACIO 
                        string idConsulta = lector["id_consulta"] != DBNull.Value ? lector["id_consulta"].ToString() : "0";
                        string fecha = lector["fecha_consulta"] != DBNull.Value
                            ? Convert.ToDateTime(lector["fecha_consulta"]).ToString("yyyy-MM-dd")
                            : "";
                        string motivo = lector["motivo_consulta"] != DBNull.Value ? lector["motivo_consulta"].ToString() : "";
                        string diagnostico = lector["diagnostico"] != DBNull.Value ? lector["diagnostico"].ToString() : "";
                         // AGEGAMOS LA FILA VISUAL DE FECHA MOTIVO 
                        dataGridView1atenciones.Rows.Add(fecha, motivo, diagnostico, "Ver", "Ver", idConsulta);
                    }
                }
            }
        }
         // CUANDO EL USUARIO LE DA CLICK
        private void dataGridView1atenciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // SI DA CLICK EN EL ENCABEZADO IGNORALO 

            if (dataGridView1atenciones.Columns[e.ColumnIndex].Name == "colReceta")
            {
                // OBTIENE EL ID DE  LA COLUMNA OCULTA 
                string idConsulta = dataGridView1atenciones.Rows[e.RowIndex].Cells["colIdConsulta"].Value?.ToString();

                if (!string.IsNullOrEmpty(idConsulta) && idConsulta != "0")
                {
                    VerRecetaGuardada(idConsulta); // ABRE LA RECETA 
                }
                else// SI MARCA ERROR
                {
                    MessageBox.Show("No se encontró el identificador de la consulta.", "Error");
                }
            }
        }

         // VE LA RECETA GUARDADA Y BUSCA LA RECETA DE LA CONSULTA Y LA MUESTRA 
        private void VerRecetaGuardada(string idConsulta)
        {
            Conexion conexionBD = new Conexion();
            MySqlConnection conn = conexionBD.obtenerconexion();
            if (conn == null) return;

            try
            {
                string queryReceta = @"SELECT r.id_receta, r.dia, r.mes, r.anio 
                                       FROM receta r
                                       INNER JOIN diagnostico d ON r.id_diagnostico = d.id_diagnostico
                                       WHERE d.id_consulta = @idConsulta
                                       LIMIT 1";

                int idReceta = 0;
                int dia = 0, mes = 0, anio = 0;
                bool recetaEncontrada = false;

                using (MySqlCommand cmd = new MySqlCommand(queryReceta, conn))
                {
                    cmd.Parameters.AddWithValue("@idConsulta", Convert.ToInt32(idConsulta));
                    using (MySqlDataReader lector = cmd.ExecuteReader())
                    {
                        if (lector.Read()) // SI EXISTE HACE LO SIGUIENTE 
                        {
                            idReceta = Convert.ToInt32(lector["id_receta"]);
                            dia = Convert.ToInt32(lector["dia"]);
                            mes = Convert.ToInt32(lector["mes"]);
                            anio = Convert.ToInt32(lector["anio"]);
                            recetaEncontrada = true;
                        }
                    }
                }

                if (!recetaEncontrada)
                {
                    MessageBox.Show("Esta consulta no tiene receta guardada.", "Sin receta");
                    return;
                }
                 // BUSCA LOS MEDICAMENTOS DE ESA RECETA 
                var listaMedicamentos = new List<frmGeneracionReceta.MedicamentoReceta>();

                string queryMed = @"SELECT dm.nombre_medicamento, dm.cant_medicamento, dm.indicaciones
                                    FROM detallemedicamento dm
                                    WHERE dm.id_receta = @idReceta";

                using (MySqlCommand cmd = new MySqlCommand(queryMed, conn))
                {
                    cmd.Parameters.AddWithValue("@idReceta", idReceta);
                    using (MySqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        { // CREAMO0S UN OBJETO CON LOS DATOS DEL MEDICAMENTO 
                            var med = new frmGeneracionReceta.MedicamentoReceta
                            {
                                Nombre = lector["nombre_medicamento"].ToString(),
                                Cantidad = lector["cant_medicamento"].ToString(),
                                Indicaciones = lector["indicaciones"].ToString()
                            };
                            listaMedicamentos.Add(med); // LO AGREGAMOS ALA LISTA 
                        }
                    }
                }

                if (listaMedicamentos.Count == 0)
                {
                    MessageBox.Show("La receta no contiene medicamentos.", "Receta vacía");
                    return;
                }
                 // RECOLECTA LOS DATOS 
                string nombreDoctora = frmBusquedaAlumnos.UsuarioNombre; // INICO DE SESION
                string cedulaDoctora = frmBusquedaAlumnos.UsuarioId; // CEDULA
                string nombrePaciente = txtNombrePaciente.Text.Trim(); // NOMBNRE DEL PACIENTE 
                string matricula = idPacienteActual;// SU ID 
                string area = txtArea.Text.Trim(); // AREA 

                string edad = txtEdad.Text.Trim(); // EDAD
                string sexo = ""; // SEXO 
                if (PerfilPaciente.Rows.Count > 0)
                {
                    // OBTENEMOS EL SEXO DEL PERFIL 
                    sexo = PerfilPaciente.Rows[0].Cells["Sexo"].Value?.ToString() ?? "";
                }
                // CONSTRUIMOS LA FECHA APARTIR DEL DIA MES Y AÑO EN LA BD 
                string fecha = new DateTime(anio, mes, dia).ToString("dd/MM/yyyy");
                // L VISTA PREVIA CON TODOS L0OS DATOS 
                frmVistaPrevia vista = new frmVistaPrevia();
                vista.CargarDatos(
                    nombreDoctora,
                    cedulaDoctora,
                    nombrePaciente,
                    matricula,
                    area,
                    edad,
                    sexo,
                    fecha,
                    listaMedicamentos
                );
                vista.PassDatosPaciente(this.idPacienteActual, this.tipoPacienteActual);
                // CUANDO SE CIERRE LA RECETA VUELVE AL HISTORIAL
                vista.FormClosed += (s, ev) => this.Show();
                vista.Show(); // MUESTRA LA RECETA 
                this.Hide(); // ESCONDE EL HISTORIAL 
            }
            catch (Exception ex)
            // MENSAJE SI HAY ERROR 
            {
                MessageBox.Show("Error al cargar la receta: " + ex.Message, "Error");
            }
            finally
            {
                conn.Close();// CIERRA LA CONEXION 
            }
        }

        private string ValorO_Vacio(object valor) // SI LA BD DEVUELVE NULL , DEVUELVE UN STRING VACIO Y NO DA ERROR
        {
            return valor != DBNull.Value ? valor.ToString() : "";
        }

         // BOTON DE EDITAR EXPEDIENTE, ABRE LA VENTANA PARA EDITAR LOS DATOS 
        private void button1_Click(object sender, EventArgs e)
        {
            //SI NO HA PACIENTE CARGADO NO DEJA ENTRAR
            if (string.IsNullOrEmpty(idPacienteActual) || string.IsNullOrEmpty(tipoPacienteActual))
            {
                // EL MENSAJE 
                MessageBox.Show("No hay paciente cargado para editar.", "Aviso");
                return;
            }

            AgregarPaciente ventana = new AgregarPaciente(idPacienteActual, tipoPacienteActual); // LA VENTANA DE AGREGAR 
            ventana.Show(); // SE ABRE 
            this.Close(); // CIERRA EL HISTORIAL 
        }

         // VA ALA CONSULTA  DONDE SE REGISTRA UNA NUEVA 
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                FrmConsultas ventanaConsulta = new FrmConsultas();
                // LE PASA LOS DATOS DEL PACIENTE 
                ventanaConsulta.PassDatosPaciente(this.idPacienteActual, this.tipoPacienteActual);
                ventanaConsulta.Show();
                this.Close();
            }
            catch (Exception ex) // SI HAY ERROR LO MUESTRA 
            {
                MessageBox.Show("Error al abrir la consulta: " + ex.Message, "Error");
            }
        }
         // BOTON DE ATRAS 
        private void BtnAtras_Click(object sender, EventArgs e)
        {
            frmBusquedaAlumnos busqueda = new frmBusquedaAlumnos();
            busqueda.Show();
            this.Close(); // CIERRA EL HISTORIAL 
        }

        private void HISTORIAL_Load(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }
    }
}