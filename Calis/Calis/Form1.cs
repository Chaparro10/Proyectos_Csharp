using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calis
{
    public partial class frmMenu : Form
    {
        AdmEmpleado admEmpleado;
        public frmMenu(AdmEmpleado admEmpleado)
        {
            InitializeComponent();
            this.admEmpleado = admEmpleado;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnAltaEmpleado_Click(object sender, EventArgs e)
        {
            frmAltaAlumno altaAlumno = new frmAltaAlumno(admEmpleado);
            altaAlumno.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultaEmpleados consulta = new frmConsultaEmpleados(admEmpleado);
            consulta.ShowDialog();
        }
    }
}
