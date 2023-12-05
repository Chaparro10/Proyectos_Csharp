using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calis
{
    public class AdmEmpleado
    {
        //CREACION DE UNA LISTA DE ESTUDIANTES
        List<Empleado> ListdeEmpleados = new List<Empleado>();

        public void agregarEstudiantes(string nombre,  string carrera ,int semestre, string status)
        {
            ListdeEmpleados.Add(new Empleado(nombre,carrera,semestre,status));
        }


        //METODO REGRESAR LOS ESTUDIANTES
        public Empleado[] RegresaEstudiantes()
        {
            int pos = 0;
            Empleado[] arregloE = new Empleado[ListdeEmpleados.Count];

            foreach (Empleado elementos in ListdeEmpleados)
            {
                Empleado e = elementos;
                arregloE[pos] = e;
                pos++;
            }
            return arregloE;

        }
    }
}
