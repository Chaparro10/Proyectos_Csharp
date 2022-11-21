using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    public class Prestamo
    {
        private int ClavePrestamo;
        private string ISBN;
        private string NombreUsuario;
        private string Telefono;
        private char TipoUsuario;


        public Prestamo(int ClavePrestamo,string ISBN,string NombreUsuario,string Telefono,char TipoUsuario)
        {
            this.ClavePrestamo = ClavePrestamo;
            this.ISBN = ISBN;
            this.NombreUsuario = NombreUsuario;
            this.Telefono = Telefono;
            this.TipoUsuario = TipoUsuario;
        }

        //PROPIEDADES
        public int PClavePrestamo
        {
            get
            {
                return ClavePrestamo;
            }
            set
            {
                ClavePrestamo = value;
            }
        }
        public string PIsbn
        {
            get
            {
                return ISBN;
            }
            set
            {
                ISBN = value;
            }
        }
        public string PNombreUsuario
        {
            get
            {
                return NombreUsuario;
            }
            set
            {
                NombreUsuario = value;
            }
        }
       
      
        public char PTipoUsuario
        {
            get
            {
                return TipoUsuario;
            }
            set
            {
                TipoUsuario = value;
            }
        }
        public string PTelefono
        {
            get
            {
                return Telefono;
            }
            set
            {
                Telefono = value;
            }
        }
    }
}
