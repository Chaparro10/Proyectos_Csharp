using System;
using System.Data;
using System.Windows.Forms;
using Biblioteca.Entidades;
using Biblioteca.Negocio;


namespace Biblioteca.Front
{
    public partial class frmAgregarLibro : Form
    {
        public frmAgregarLibro()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text;
            
            if (txtISBN.Text=="" || txtNombre.Text=="" || txtAutor.Text=="" ||txtExistencia.Text=="")
            {
                MessageBox.Show("NO PUEDE HABER ESPACIOS EN BLANCO","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string nombreLibro = txtNombre.Text;
            string Autor = txtAutor.Text;
            int Existencia = Convert.ToInt32(txtExistencia.Text);

            if (Existencia<=0)
            {
                MessageBox.Show("LA EXISTENCIA NO PUEDE SER 0");
            }
            string Editorial = cmbEditorial.Text;
            if (txtISBN.Text.Length<13)
            {
                MessageBox.Show("EL ISBN NO PUEDE SER MENOR A 13 CARACTERES","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            byte Con=0;
            if (rdGeneral.Checked)
            {
                Con = 1;
            }
            byte Consulta = Con;

            char TipoPrestamo='B';
            if (chkAlumnos.Checked && !chkMaestros.Checked)
            {
                TipoPrestamo = 'A';
            }
            if (!chkAlumnos.Checked && chkMaestros.Checked)
            {
                TipoPrestamo = 'M';
            }
            if (!chkAlumnos.Checked && !chkMaestros.Checked)
            {
                MessageBox.Show("TIENE QUE SELECCIONAR EL TIPO PRESTAMO");
            }
          
                string Respuesta = "";
            Libro libro = new Libro(isbn, nombreLibro, Autor, Existencia,Editorial,Consulta,TipoPrestamo);
            try
            {
                Respuesta = NLibro.BuscarNombreLibro(nombreLibro);
                if(Respuesta.Equals("YA EXISTE"))
                { 
                    MessageBox.Show("NOMBRE DE LIBRO DUPLICADO");
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }


            try
            {
                //OBTENER LA RESPUESTA DEL NEGOCIO
                Respuesta = NLibro.Agregar(libro);
                if (Respuesta.Equals("OK"))
                {
                    MessageBox.Show("LIBRO AGREGADO CORRECTAMENTE");
                }
                if (Respuesta.Equals("YA EXISTE"))
                {
                    MessageBox.Show("ISBN , YA EXISTE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return;
            }
            
        }

        private void frmAgregarLibro_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable table = NEditorial.ObtenEditorial();
                cmbEditorial.DataSource = table;
                cmbEditorial.DisplayMember = "ClaveEditorial";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtISBN.Text = "";
            txtExistencia.Text = "";
            txtAutor.Text = ""; 
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultaLibro ConsultaLi = new frmConsultaLibro();
                ConsultaLi.ShowDialog();
        }

        private void txtExistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtAutor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAutor_Validated(object sender, EventArgs e)
        {
            string dato = txtAutor.Text;
            if (ValidaTexto(dato))
            {
                errorP.SetError(txtAutor, "");
            }
            else
            {
                errorP.SetError(txtAutor, "El Autor no puede estar vacio");
                txtAutor.Focus();
            }
        }

        private void txtISBN_Validated(object sender, EventArgs e)
        {
            string dato = txtISBN.Text;
            if (ValidaTexto(dato))
            {
                errorP.SetError(txtISBN, "");
            }
            else
            {
                errorP.SetError(txtISBN, "El ISBN no puede estar vacio");
                txtISBN.Focus();
            }
        }

        private void txtExistencia_Validated(object sender, EventArgs e)
        {
            string dato = txtExistencia.Text;
            if (ValidaTexto(dato))
            {
                errorP.SetError(txtExistencia, "");
            }
            else
            {
                errorP.SetError(txtExistencia, "La Existencia no puede estar vacia");
                txtExistencia.Focus();
            }
        }
    }
}
