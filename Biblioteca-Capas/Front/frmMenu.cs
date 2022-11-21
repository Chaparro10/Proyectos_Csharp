using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Front
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void cONSULTARToolSLibros_Click(object sender, EventArgs e)
        {
            
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void aGREGARLIBROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarLibro agregaLibro = new frmAgregarLibro();
            agregaLibro.ShowDialog();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void tODOSToolSLibros_Click(object sender, EventArgs e)
        {
            frmConsultaLibro TodosLosLibros = new frmConsultaLibro();
            TodosLosLibros.ShowDialog();
        }

        private void iNDIVIDUALToolSLibros_Click(object sender, EventArgs e)
        {
            frmConsultaIndLibros ConsultIndividualLibro = new frmConsultaIndLibros();
            ConsultIndividualLibro.ShowDialog();
        }

        private void aGREGARPRESTAMOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarPrestamo agregaPrestamo = new frmAgregarPrestamo();
            agregaPrestamo.ShowDialog();
        }

        private void tODOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarPrestamos consulPresta = new frmConsultarPrestamos();
            consulPresta.ShowDialog();
        }

        private void tODOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaEditorial ConsulEdito = new frmConsultaEditorial();
            ConsulEdito.ShowDialog();
        }

        private void aGREGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarEditorial AgregaEdi = new frmAgregarEditorial();
            AgregaEdi.ShowDialog();

        }

        private void mODIFICARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarLibro modLibro = new frmModificarLibro();
            modLibro.ShowDialog();
        }

        private void iNDIVIDUALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaIndividualPrestamo ConsulIndPresta = new frmConsultaIndividualPrestamo();
            ConsulIndPresta.ShowDialog();
        }

        private void iNDIVIDUALToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaIndEditorial ConsulIndEdi = new frmConsultaIndEditorial();
            ConsulIndEdi.ShowDialog();
        }
    }
}
