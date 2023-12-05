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
    public partial class frmAltaAlumno : Form
    {
        AdmEmpleado admEmpleado;
        public frmAltaAlumno(AdmEmpleado admEmpleado)
        {
            InitializeComponent();
            this.admEmpleado = admEmpleado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //BOTON PARA GUARDAR UN ESTUDIANTE
          
                string nombre = txtNombre.Text;
                string carrera = cmbCarreras.SelectedIndex.ToString();
                int semestre = (int)numericUpDown1.Value;
                string estatus = txtStatus.Text;

                admEmpleado.agregarEstudiantes(nombre, carrera, semestre, estatus);
                MessageBox.Show("AGREGADO CORRECTAMENTE", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            numericUpDown1.Value = 1;
            txtStatus.Text = "";
           
        }
    }
}
