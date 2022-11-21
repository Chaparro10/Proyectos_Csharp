using System;
using System.Windows.Forms;
using Biblioteca.Negocio;
using System.Data;
namespace Biblioteca.Front
{
    public partial class frmConsultaIndEditorial : Form
    {
        public frmConsultaIndEditorial()
        {
            InitializeComponent();
        }
        DataTable tabla;

        private void ConsultaIndEditorial_Load(object sender, EventArgs e)
        {
            try
            {
                tabla = NEditorial.ObtenEditorial();
                cmbClaveEdi.DataSource = tabla;
                this.cmbClaveEdi.DisplayMember = "ClaveEditorial";

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cmbClaveEdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CveSeleccionado = cmbClaveEdi.SelectedItem.ToString();
           
            DataRow Edi = ((DataRowView)cmbClaveEdi.Items[cmbClaveEdi.SelectedIndex]).Row;
            txtNombre.Text = Edi.ItemArray[1].ToString();
            txtTelefono.Text = Edi.ItemArray[2].ToString();
            txtCorreo.Text = Edi.ItemArray[3].ToString();

           

        }
    }
  }

