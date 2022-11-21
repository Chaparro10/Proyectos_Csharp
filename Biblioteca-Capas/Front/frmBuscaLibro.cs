using System;
using System.Data;
using System.Windows.Forms;
using Biblioteca.Negocio;
using Biblioteca.Datos;

namespace Biblioteca.Front
{
    public partial class frmBuscaLibro : Form
    {
        public frmBuscaLibro()
        {
            InitializeComponent();
        }

        private void frmBuscaLibro_Load(object sender, EventArgs e)
        {
           
            try
            {
                DataTable table = NLibro.ObtenLibros();
                this.dgvBLibro.DataSource = table;
               dgvBLibro.Columns[1].Width = 350;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR", MessageBoxButtons.OK);
                throw ex;
            }

           
        }
        private void btnBuscarL_Click(object sender, EventArgs e)
        {

        }

        private void dgvBLibro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvBLibro.CurrentRow.Selected = true;
            Variables.ISBN = Convert.ToString(dgvBLibro.Rows[e.RowIndex].Cells[0].Value);
            Variables.NombreLi = Convert.ToString(dgvBLibro.Rows[e.RowIndex].Cells[1].Value);
            Variables.Autor = Convert.ToString(dgvBLibro.CurrentRow.Cells[2].Value);
            Variables.Existencia = Convert.ToInt32(dgvBLibro.CurrentRow.Cells[3].Value);
            Variables.Editorial = Convert.ToString(dgvBLibro.Rows[e.RowIndex].Cells[4].Value);
            Variables.ParaUso = Convert.ToString(dgvBLibro.CurrentRow.Cells[5].Value);
            Variables.PrestarA = Convert.ToString(dgvBLibro.CurrentRow.Cells[6].Value);

            this.Close();
        }

        private void txtNomBuscarL_TextChanged(object sender, EventArgs e)
        {
           
            try
            {
                DataTable table = NLibro.ObtenerLiS(this.txtNomBuscarL.Text.Trim());
                this.dgvBLibro.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR", MessageBoxButtons.OK);
                throw ex;
            }
        }
    }
  


}

