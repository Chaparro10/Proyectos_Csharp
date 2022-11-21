using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Biblioteca.Negocio;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Layout;
using iText.Layout.Element;
using LibreriaUsoPdf;

namespace Biblioteca.Front
{
    public partial class frmConsultarPrestamos : Form
    {
        public frmConsultarPrestamos()
        {
            InitializeComponent();
        }

        private void frmConsultarPrestamos_Load(object sender, EventArgs e)
        {

            try
            {
                DataTable table = NPrestamo.ObtenPrestamo();
                this.dgvTodosPresta.DataSource = table;
                dgvTodosPresta.Columns[2].Width = 350;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR", MessageBoxButtons.OK);
                throw ex;
            }
            Carga_GRAFICO();
        }

        private void btnGeneraPdf_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            PdfFont fontNormal = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            Document documento = Utility.CreatePdf("PDF_TodosPrestamos.pdf");

            documento = Utility.EncabezadoPdf(documento, "PRESTAMOS AGREGADOS ", "Reporte de Prestamos");
            string[] columnas = { "CLAVE", "ISBN", "NOMBRE USUARIO", "TIPO USUARIO","TELEFONO" };
            float[] tam = { 5,5, 20, 10 ,10};
            Table tabla = Utility.EncabezadoTabla(columnas, tam);

            dt = NPrestamo.ObtenPrestamo();
            foreach (DataRow r in dt.Rows)
            {
                for (int h = 0; h < dt.Columns.Count; h++)
                {
                    tabla.AddCell(new Cell().Add(new Paragraph(r[h].ToString()).SetFont(fontNormal)));
                }
            }

            documento.Add(tabla);
            documento.Close();
            MessageBox.Show("PDF GENERADO!!...ABRIENDO PDF");

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            string ruta = Directory.GetCurrentDirectory();
            proc.StartInfo.FileName = ruta + "/PDF_TodosPrestamos.pdf";
            proc.Start();
            proc.Close();
        }
        private void Carga_GRAFICO()
        {
            try
            {
                DataTable table = NPrestamo.ObtenPrestamo();
                grafico.Titles.Add("LIBROS PRESTADOS");
                

                foreach (DataRow row in table.Rows)
                {
                    Series serie = grafico.Series.Add(row["Usuario"].ToString());
                    serie.Points.Add(Convert.ToDouble(row["ISBN"].ToString()));
                    serie.Label = row["ISBN"].ToString();

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR", MessageBoxButtons.OK);
                throw ex;
            }
        }
       
    }
}
