using System;
using System.Data;
using System.Windows.Forms;
using Biblioteca.Datos;
using Biblioteca.Entidades;
using Biblioteca.Negocio;


namespace Biblioteca.Front
{
    public partial class frmModificarLibro : Form
    {
        public frmModificarLibro()
        {
            InitializeComponent();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscaLibro Buscali = new frmBuscaLibro();
            Buscali.ShowDialog();
            txtNombre.Text = Variables.NombreLi;
            txtISBN.Text = Variables.ISBN;
            txtAutor.Text = Variables.Autor;
            txtExistencia.Text = (Variables.Existencia).ToString();
            cmbEditorial.Text = Variables.Editorial;

            if (txtISBN.Text.Length == 13)
            {
                btnEliminar.Enabled = true;
            }
        }

        private void frmModificarLibro_Load(object sender, EventArgs e)
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que quieres modificar?", "INFORMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string ISBN = txtISBN.Text;
                string NombreLi = txtNombre.Text;
                string Autor = txtAutor.Text;
                int Existencia = Convert.ToInt32(txtExistencia.Text);
                string Edi = cmbEditorial.Text;

                byte Con = 0;
                if (rdGeneral.Checked)
                {
                    Con = 1;
                }
                byte Consulta = Con;

                char TipoPrestamo = 'B';
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
                    MessageBox.Show("TIPO PRESTAMO NO PUEDE ESTAR VACIO");
                }

                string Respuesta = "";
                Libro libro = new Libro(ISBN, NombreLi, Autor, Existencia, Edi, Consulta, TipoPrestamo);
                try
                {
                    //OBTENER LA RESPUESTA DEL NEGOCIO
                    Respuesta = NLibro.Actualizar(libro);
                    if (Respuesta.Equals("OK"))
                    {
                        MessageBox.Show("LIBRO ACTUALIZADO CORRECTAMENTE");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                    return;
                }


            }
            else
            {
                MessageBox.Show("Se cancelo la modificacion", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtExistencia_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text;
            string nombreLibro = txtNombre.Text;
            string respuesta = "";
            byte consulta = 1; ;

            if (rdInterno.Checked)
            {
                consulta = 0;
            }

            char tipoprestamo;

            if (chkAlumnos.Checked && !chkMaestros.Checked)
            {
                tipoprestamo = 'A';

                if (!chkAlumnos.Checked && chkMaestros.Checked)
                {
                    tipoprestamo = 'M';
                }

                tipoprestamo = 'B';

                string autor = txtAutor.Text;
                string editorial = cmbEditorial.Text;
                byte existencia = Convert.ToByte(txtExistencia.Text);

                Libro libro = new Libro(isbn, nombreLibro, autor, existencia, editorial, consulta, tipoprestamo);

                try
                {
                    DialogResult DR = MessageBox.Show("Desea eliminar el libro?", "INFORMACIÓN", MessageBoxButtons.YesNo);
                    if (DR == DialogResult.Yes)
                    {
                        respuesta = NLibro.Eliminar(libro);
                        if (respuesta.Equals("OK"))
                        {
                            MessageBox.Show("El Libro ha sido eliminado correctamente", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }
                    }
                    else if (DR == DialogResult.No)
                    {
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No se puede eliminar el libro ya que existe un prestamo pendiente", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtISBN.Text = "";
            txtNombre.Text = "";
            txtExistencia.Text = "";
            cmbEditorial.SelectedIndex = 0;
            txtAutor.Text = "";
            rdInterno.Checked = true;
            chkAlumnos.Checked = true;
        }
    }
}
