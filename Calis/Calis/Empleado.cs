using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calis
{
    public  class Empleado
    {
        //Declaracion de Variables
        private string Nombre;
        private string carrera;
        private int semestre;
        private string status;
        private int NumControl;


        //CONSTRUCTOR
        public Empleado(string nombre,string carrera,int semestre,string status)
        {
            this.Nombre = nombre;
            this.carrera=carrera;
            this.semestre=semestre; 
            this.status=status;
           
        }
        //Propiedades

        public int pNumControl
        {
            get
            {
                return NumControl;
            }
        }
        public string pNombre
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
            }
        }

        public int pSemestre
        {
            get
            {
                return semestre;
            }
            set
            {
                semestre = value;
            }
        }
        public string pCarrera
        {
            get
            {
                return carrera;
            }
            set
            {
                carrera = value;
            }
        }
        public string pEstatus
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

    }
}
