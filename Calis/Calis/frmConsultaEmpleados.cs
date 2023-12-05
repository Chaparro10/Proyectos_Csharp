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
    public partial class frmConsultaEmpleados : Form
    {
        AdmEmpleado admEmpleado;
        public frmConsultaEmpleados(AdmEmpleado admEmpleado)
        {
            InitializeComponent();
            this.admEmpleado = admEmpleado; 
        }

        private void frmConsultaEmpleados_Load(object sender, EventArgs e)
        {
            Empleado[] arreglo = admEmpleado.RegresaEstudiantes();
            //CargaAcademica[] ArregloCA = admiCargaAcademica.RegresaCargaAcademica();
            foreach (Empleado elementos in arreglo)
            {
                dgvEmpleados.Rows.Add( elementos.pNombre, elementos.pSemestre, elementos.pCarrera.ToString(), elementos.pEstatus);
            }
        }
    }
}
