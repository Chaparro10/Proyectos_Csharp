using System;
using System.Windows.Forms;
using Biblioteca.Entidades;
using Biblioteca.Negocio;

namespace Biblioteca.Front
{
    public partial class frmAgregarEditorial : Form
    {
        public frmAgregarEditorial()
        {
            InitializeComponent();
        }

        private void frmAgregarEditorial_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string NombreEdi = txtNombre.Text;
            if (txtNombre.Text=="")
            {
                MessageBox.Show("EL NOMBRE NO PUEDE ESTAR VACION");
                return;
            }
            string TelefonEdi = txtTelefono.Text;
            if (txtTelefono.Text=="")
            {
                MessageBox.Show("EL TELEFONO NO PUEDE ESTAR VACIO");
                return;
            }
            string CorreoEdi = txtCorreo.Text;

            string Respuesta = "";
            Editorial Edi = new Editorial(NombreEdi,TelefonEdi,CorreoEdi);

            try
            {
                //OBTENER LA RESPUESTA DEL NEGOCIO
                Respuesta = NEditorial.Agregar(Edi);
                if (Respuesta.Equals("OK"))
                {
                    MessageBox.Show("EDITORIAL AGREGADO CORRECTAMENTE");
                }
                if (Respuesta.Equals("YA EXISTE"))
                {
                    MessageBox.Show("EDITORIAL , YA EXISTE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultaEditorial ConsulEditorial = new frmConsultaEditorial();
            ConsulEditorial.ShowDialog();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        public bool ValidaTexto(string cadena)
        {
            if (string.IsNullOrWhiteSpace(cadena) || string.IsNullOrEmpty(cadena))
            {
                return false;
            }
            return true;
        }
        private void txtNombre_Validated(object sender, EventArgs e)
        {
            string dato = txtNombre.Text;
            if (ValidaTexto(dato))
            {
                errorP.SetError(txtNombre, "");
            }
            else
            {
                errorP.SetError(txtNombre, "El Nombre no puede estar vacio");
                txtNombre.Focus();
            }
        }

        private void txtTelefono_Validated(object sender, EventArgs e)
        {
            string dato = txtTelefono.Text;
            if (ValidaTexto(dato))
            {
                errorP.SetError(txtTelefono, "");
            }
            else
            {
                errorP.SetError(txtTelefono, "El Telefono no puede estar vacio");
                txtTelefono.Focus();
            }
        }
    }
}
