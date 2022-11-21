using System;
using System.Data;
using System.Windows.Forms;
using Biblioteca.Negocio;

namespace Biblioteca.Front
{
    public partial class frmConsultaIndividualPrestamo : Form
    {
        public frmConsultaIndividualPrestamo()
        {
            InitializeComponent();
        }
        DataTable tabla;

        private void frmConsultaIndividualPrestamo_Load(object sender, EventArgs e)
        {
            try
            {
                tabla = NPrestamo.ObtenPrestamo();
                cmbClavePresta.DataSource = tabla;
                this.cmbClavePresta.DisplayMember = "Clave";

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cmbClavePresta_SelectedIndexChanged(object sender, EventArgs e)
        {
            string isbnSeleccionado = cmbClavePresta.GetItemText(cmbClavePresta.SelectedItem);
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                string isbnTabla = tabla.Rows[i][0].ToString();
                if (isbnTabla.Equals(isbnSeleccionado))
                {
                    dgvIndPrestamos.Rows.Clear();
                    string ISBN = tabla.Rows[i][1].ToString();
                    dgvIndPrestamos.Rows.Add(tabla.Rows[i][1].ToString(),
                          tabla.Rows[i][2].ToString(),
                          tabla.Rows[i][3].ToString(),
                          tabla.Rows[i][4].ToString());
                }
            }
        }
    }
    
}
