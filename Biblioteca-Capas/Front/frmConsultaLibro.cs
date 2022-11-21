using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Biblioteca.Negocio;
using Biblioteca.Entidades;
using iText.Kernel.Font;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Font.Constants;
using LibreriaUsoPdf;
using System.IO;


namespace Biblioteca.Front
{
    public partial class frmConsultaLibro : Form
    {
        
        public frmConsultaLibro()
        {
            InitializeComponent();
        }

        private void frmConsultaLibro_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable table = NLibro.ObtenLibros();
                this.dgvConsultaLibro.DataSource = table;
                dgvConsultaLibro.Columns[1].Width = 350;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace,"ERROR", MessageBoxButtons.OK);
                throw ex;
            }
        }

        private void btnGeneraPdf_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();


            PdfFont fontNormal = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            Document documento = Utility.CreatePdf("PDF_TodosLibros.pdf");

            documento = Utility.EncabezadoPdf(documento, "LIBROS AGREGADOS", "Reporte de Libros");
            string[] columnas = { "ISBN LIBRO", "NOMBRE LIBRO","AUTOR", "Existencia","EDITORIAL", "CONSULTA", "TIPO PRESTAMO" };
            float[] tam = { 5, 10, 10, 3, 10, 10 ,2};
            Table tabla = Utility.EncabezadoTabla(columnas, tam);

            dt = NLibro.ObtenLibros();
            foreach (DataRow r in dt.Rows)
            {
               for (int h=0;h<dt.Columns.Count;h++)
                {
                  tabla.AddCell(new Cell().Add(new Paragraph(r[h].ToString()).SetFont(fontNormal)));
                }  
            }
            
            documento.Add(tabla);
            documento.Close();
            MessageBox.Show("PDF GENERADO!!...ABRIENDO PDF");



            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            string ruta = Directory.GetCurrentDirectory();
            proc.StartInfo.FileName = ruta + "/PDF_TodosLibros.pdf";
            proc.Start();
            proc.Close();
        }
    }
}
