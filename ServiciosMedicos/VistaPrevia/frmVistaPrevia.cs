using ServiciosMedicos.Consultas;
using ServiciosMedicos.GeneracionReceta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
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

        // Constructor VACÍO — el diseñador lo necesita
        public frmVistaPrevia()
        {
            InitializeComponent();
            printDocument1.PrintPage += printDocument1_PrintPage;
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
            dgvMP.Rows.Clear();

            int contador = 1;
            foreach (var med in _medicamentos)
            {
                dgvMP.Rows.Add(
                    contador,
                    $"{med.Nombre} (Cant: {med.Cantidad})",
                    med.Indicaciones
                );
                contador++;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmGeneracionReceta frmcondultas = new frmGeneracionReceta();
            frmcondultas.Show();
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            // Fuentes que usaremos
            Font fuenteTitulo = new Font("Arial", 16, FontStyle.Bold);
            Font fuenteSub = new Font("Arial", 11, FontStyle.Bold);
            Font fuenteNormal = new Font("Arial", 10, FontStyle.Regular);
            Font fuenteEtiqueta = new Font("Arial", 9, FontStyle.Bold);

            // Punto de inicio (márgenes de la hoja)
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;
            int ancho = e.MarginBounds.Width;

            // ═══════════════════════════════════════════════════════
            // 1. TÍTULO PRINCIPAL
            // ═══════════════════════════════════════════════════════
            string titulo = "RECETA MÉDICA ESCOLAR";
            SizeF tamTitulo = g.MeasureString(titulo, fuenteTitulo);
            g.DrawString(titulo, fuenteTitulo, Brushes.Black,
                x + (ancho - tamTitulo.Width) / 2, y);
            y += 50;

            // ═══════════════════════════════════════════════════════
            // 2. DATOS DE LA DOCTORA
            // ═══════════════════════════════════════════════════════
            DibujarSeccionImpresion(g, "DATOS DE LA DOCTORA", ref y, x, ancho, fuenteSub);

            DibujarLineaTexto(g, "DRA.", _nombreDoctora, ref y, x, ancho, fuenteEtiqueta, fuenteNormal);
            DibujarLineaTexto(g, "MÉDICA GENERAL, CÉDULA PROFESIONAL", _cedulaDoctora, ref y, x, ancho, fuenteEtiqueta, fuenteNormal);
            y += 10;

            // ═══════════════════════════════════════════════════════
            // 3. DATOS DEL PACIENTE (dos columnas)
            // ═══════════════════════════════════════════════════════
            DibujarSeccionImpresion(g, "DATOS DEL PACIENTE", ref y, x, ancho, fuenteSub);

            int mitad = ancho / 2;
            int yCol = y;

            // Columna izquierda
            DibujarLineaTexto(g, "Paciente:", _nombrePaciente, ref yCol, x, mitad - 10, fuenteEtiqueta, fuenteNormal);
            DibujarLineaTexto(g, "Matrícula:", _matricula, ref yCol, x, mitad - 10, fuenteEtiqueta, fuenteNormal);
            DibujarLineaTexto(g, "Área:", _area, ref yCol, x, mitad - 10, fuenteEtiqueta, fuenteNormal);

            // Columna derecha
            yCol = y;
            DibujarLineaTexto(g, "Edad:", _edad, ref yCol, x + mitad + 10, mitad - 10, fuenteEtiqueta, fuenteNormal);
            DibujarLineaTexto(g, "Sexo:", _sexo, ref yCol, x + mitad + 10, mitad - 10, fuenteEtiqueta, fuenteNormal);
            DibujarLineaTexto(g, "Fecha:", _fecha, ref yCol, x + mitad + 10, mitad - 10, fuenteEtiqueta, fuenteNormal);

            y = Math.Max(y, yCol) + 15;

            // ═══════════════════════════════════════════════════════
            // 4. MEDICAMENTOS PRESCRITOS (tabla)
            // ═══════════════════════════════════════════════════════
            DibujarSeccionImpresion(g, "MEDICAMENTOS PRESCRITOS", ref y, x, ancho, fuenteSub);

            // Encabezados
            int colNum = 40;
            int colMed = 250;
            int colInd = ancho - colNum - colMed;

            DibujarCelda(g, "#", x, y, colNum, 28, fuenteSub, Brushes.LightGray);
            DibujarCelda(g, "Medicamentos", x + colNum, y, colMed, 28, fuenteSub, Brushes.LightGray);
            DibujarCelda(g, "Indicaciones", x + colNum + colMed, y, colInd, 28, fuenteSub, Brushes.LightGray);
            y += 28;

            // Filas
            int numero = 1;
            foreach (var med in _medicamentos)
            {
                string textoMed = $"{med.Nombre} (Cant: {med.Cantidad})";
                string textoInd = med.Indicaciones ?? "";

                // Calculamos alto según el texto más largo (indicaciones)
                SizeF sizeInd = g.MeasureString(textoInd, fuenteNormal, colInd - 10);
                int altoFila = Math.Max(30, (int)sizeInd.Height + 10);

                // Si no cabe en la página, pedimos otra
                if (y + altoFila > e.MarginBounds.Bottom - 40)
                {
                    e.HasMorePages = true;
                    return;
                }

                DibujarCelda(g, numero.ToString(), x, y, colNum, altoFila, fuenteNormal, Brushes.White);
                DibujarCelda(g, textoMed, x + colNum, y, colMed, altoFila, fuenteNormal, Brushes.White);
                DibujarCeldaMultilinea(g, textoInd, x + colNum + colMed, y, colInd, altoFila, fuenteNormal);

                y += altoFila;
                numero++;
            }

            y += 20;

            // ═══════════════════════════════════════════════════════
            // 5. INDICACIONES GENERALES
            // ═══════════════════════════════════════════════════════
            if (y + 80 < e.MarginBounds.Bottom - 40)
            {
                DibujarSeccionImpresion(g, "INDICACIONES Y RECOMENDACIONES", ref y, x, ancho, fuenteSub);

                Rectangle rect = new Rectangle(x, y, ancho, 80);
                g.DrawRectangle(Pens.Black, rect);
                g.DrawString(
                    "Tomar los medicamentos según indicación médica.\n" +
                    "En caso de malestar, acudir al servicio médico escolar.",
                    fuenteNormal, Brushes.Black,
                    new RectangleF(x + 5, y + 5, ancho - 10, 70));
                y += 90;
            }

            // ═══════════════════════════════════════════════════════
            // 6. FIRMA
            // ═══════════════════════════════════════════════════════
            if (y + 50 < e.MarginBounds.Bottom - 40)
            {
                y += 30;
                g.DrawLine(Pens.Black, x + ancho - 220, y, x + ancho, y);
                g.DrawString(
                    $"Dra. {_nombreDoctora}\nCédula: {_cedulaDoctora}",
                    fuenteNormal, Brushes.Black,
                    x + ancho - 220, y + 5);
            }

            // No hay más páginas
            e.HasMorePages = false;

            // Limpiar fuentes
            fuenteTitulo.Dispose();
            fuenteSub.Dispose();
            fuenteNormal.Dispose();
            fuenteEtiqueta.Dispose();
        }

        // ═══════════════════════════════════════════════════════════
        // MÉTODOS AUXILIARES PARA DIBUJAR EN LA IMPRESIÓN
        // ═══════════════════════════════════════════════════════════

        private void DibujarSeccionImpresion(Graphics g, string titulo, ref int y, int x, int ancho, Font fuente)
        {
            g.FillRectangle(Brushes.LightGray, x, y, ancho, 24);
            g.DrawRectangle(Pens.Black, x, y, ancho, 24);
            g.DrawString(titulo, fuente, Brushes.Black, x + 5, y + 3);
            y += 29;
        }

        private void DibujarLineaTexto(Graphics g, string etiqueta, string valor, ref int y, int x, int ancho, Font fuenteEtiqueta, Font fuenteValor)
        {
            g.DrawString(etiqueta, fuenteEtiqueta, Brushes.Black, x, y);
            int anchoEtiqueta = (int)g.MeasureString(etiqueta, fuenteEtiqueta).Width + 5;
            g.DrawString(valor ?? "", fuenteValor, Brushes.Black, x + anchoEtiqueta, y);
            g.DrawLine(Pens.Gray, x, y + 18, x + ancho, y + 18);
            y += 25;
        }

        private void DibujarCelda(Graphics g, string texto, int x, int y, int ancho, int alto, Font fuente, Brush fondo)
        {
            g.FillRectangle(fondo, x, y, ancho, alto);
            g.DrawRectangle(Pens.Black, x, y, ancho, alto);
            g.DrawString(texto, fuente, Brushes.Black, x + 5, y + (alto - 14) / 2);
        }

        private void DibujarCeldaMultilinea(Graphics g, string texto, int x, int y, int ancho, int alto, Font fuente)
        {
            g.FillRectangle(Brushes.White, x, y, ancho, alto);
            g.DrawRectangle(Pens.Black, x, y, ancho, alto);
            g.DrawString(texto, fuente, Brushes.Black,
                new RectangleF(x + 5, y + 5, ancho - 10, alto - 10));
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}