using System;
using System.Data;
using System.Windows.Forms;
using Biblioteca.Negocio;
using iText.Kernel.Font;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Font.Constants;
using LibreriaUsoPdf;
using System.IO;




namespace Biblioteca.Front
{
    public partial class frmConsultaEditorial : Form
    {
        public frmConsultaEditorial()
        {
            InitializeComponent();
        }

        private void frmConsultaEditorial_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable table = NEditorial.ObtenEditorial();
                this.dgvConsultaEdi.DataSource = table;
                dgvConsultaEdi.Columns[1].Width = 350;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR", MessageBoxButtons.OK);
                throw ex;
            }
        }

        private void btnGeneraPdf_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            PdfFont fontNormal = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            Document documento = Utility.CreatePdf("PDF_TodasEditoriales.pdf");

            documento = Utility.EncabezadoPdf(documento, "EDITORIALES AGREGADAS ", "Reporte de Editoriales");
            string[] columnas = { "CLAVE", "NOMBRE EDITORIAL", "TELEFONO", "EMAIL"};
            float[] tam = { 5, 20, 10, 10};
            Table tabla = Utility.EncabezadoTabla(columnas, tam);

            dt = NEditorial.ObtenEditorial();
            foreach (DataRow r in dt.Rows)
            {
                for (int h = 0; h <dt.Columns.Count; h++)
                {
                    tabla.AddCell(new Cell().Add(new Paragraph(r[h].ToString()).SetFont(fontNormal)));
                }
            }

            documento.Add(tabla);
            documento.Close();
            MessageBox.Show("PDF GENERADO!!...ABRIENDO PDF");

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            string ruta = Directory.GetCurrentDirectory();
            proc.StartInfo.FileName = ruta + "/PDF_TodasEditoriales.pdf";
            proc.Start();
            proc.Close();
        }
    
    }
}
