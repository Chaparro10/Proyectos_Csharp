using System;
using System.Windows.Forms;
using System.Data;
using Biblioteca.Entidades;
using Biblioteca.Negocio;


namespace Biblioteca.Front
{
    public partial class frmAgregarPrestamo : Form
    {
        public frmAgregarPrestamo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            if (txtClave.Text == "" || txtNombrePresta.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("NO PUEDE HABER CAMPOS VACIOS");
                return;
            }

            int ClavePresta = Convert.ToInt32(txtClave.Text);
            string NombrePresta = txtNombrePresta.Text;
            string Telefono = txtTelefono.Text;
            string IsbnL = cmbLibro.Text;


            char TipoUser='M';
            if (rdEstudiante.Checked)
            {
                TipoUser = 'A';
            }

            string Respuesta = "";
            Prestamo Presta = new Prestamo(ClavePresta,IsbnL, NombrePresta,Telefono,TipoUser);

            try
            {
                //OBTENER LA RESPUESTA DEL NEGOCIO
                Respuesta = NPrestamo.Agregar(Presta);
                
                if (Respuesta.Equals("OK"))
                {
                    MessageBox.Show("PRESTAMO AGREGADO CORRECTAMENTE");
                }
                if (Respuesta.Equals("YA EXISTE"))
                {
                    MessageBox.Show("CLAVE PRESTAMO , YA EXISTE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return;
            }
        }

        private void frmAgregarPrestamo_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable table = NPrestamo.ObtenISBNPres();
                cmbLibro.DataSource = table;
                cmbLibro.DisplayMember = "ISBN";
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtNombrePresta_KeyPress(object sender, KeyPressEventArgs e)
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
        public bool ValidaTexto(string cadena)
        {
            if (string.IsNullOrWhiteSpace(cadena) || string.IsNullOrEmpty(cadena))
            {
                return false;
            }
            return true;
        }

        private void txtClave_Validated(object sender, EventArgs e)
        {
            string dato = txtClave.Text;
            if (ValidaTexto(dato))
            {
                errorP.SetError(txtClave, "");
            }
            else
            {
                errorP.SetError(txtClave, "El Campo Clave no puede estar vacio");
                txtClave.Focus();
            }
        }

        private void txtNombrePresta_Validated(object sender, EventArgs e)
        {
            string dato = txtNombrePresta.Text;
            if (ValidaTexto(dato))
            {
                errorP.SetError(txtNombrePresta, "");
            }
            else
            {
                errorP.SetError(txtNombrePresta, "El Nombre no puede estar vacio");
                txtNombrePresta.Focus();
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
                errorP.SetError(txtTelefono, "El Campo Telefono no puede estar vacio");
                txtTelefono.Focus();
            }
        }
    }
}
