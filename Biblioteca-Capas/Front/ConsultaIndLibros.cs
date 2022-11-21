using System;
using System.Data;
using System.Windows.Forms;
using Biblioteca.Negocio;

namespace Biblioteca.Front
{
    public partial class frmConsultaIndLibros : Form
    {
        public frmConsultaIndLibros()
        {
            InitializeComponent();
        }
        DataTable tabla; //CREO VAR TABLA A NIVEL DE CLASE
        private void ConsultaIndLibros_Load(object sender, EventArgs e)
        {
            try
            {
                tabla = NLibro.ObtenLibros();
                cmbISBN.DataSource = tabla;
                this.cmbISBN.DisplayMember ="ISBN";
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void cmbISBN_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string isbnSeleccionado = cmbISBN.GetItemText(cmbISBN.SelectedItem);
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                string isbnTabla = tabla.Rows[i][0].ToString();
                if (isbnTabla.Equals(isbnSeleccionado))
                {
                    dgvIndividualLibro.Rows.Clear();
                    string nombreLibro = tabla.Rows[i][1].ToString();
                    dgvIndividualLibro.Rows.Add(tabla.Rows[i][1].ToString(), tabla.Rows[i][2].ToString(),
                         tabla.Rows[i][3].ToString(),
                         tabla.Rows[i][4].ToString(),
                         tabla.Rows[i][5].ToString(),
                         tabla.Rows[i][6].ToString());

                }
            } 
        }
        private void dgvIndividualLibro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
