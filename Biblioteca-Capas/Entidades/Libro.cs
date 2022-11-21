using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    public class Libro
    {
        private string ISBN;
        private string nombreLibro;
        private string autor;
        private int Existencia;
        private string Editorial;
        private byte Consulta;
        private char PrestarA;

        //CONSTRUCTOR
        public Libro(string ISBN,string nombreLibro,string autor,int Existencia,string Editorial,byte Consulta,char PrestarA)
        {
            this.ISBN = ISBN;
            this.nombreLibro = nombreLibro;
            this.autor = autor;
            this.Existencia = Existencia;
            this.Editorial = Editorial;
            this.Consulta = Consulta;
            this.PrestarA = PrestarA;

        }
        //PROPIEDADES
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
        public string PNombreLibro
        {
            get
            {
                return nombreLibro;
            }
            set
            {
                nombreLibro = value;
            }
        }
        public string Pautor
        {
            get
            {
                return autor;
            }
            set
            {
                autor = value;
            }
        }
        public int PExistencia
        {
            get
            {
                return Existencia;
            }
            set
            {
                Existencia = value;
            }
        }
        public string PEditorial
        {
            get
            {
                return Editorial;
            }
            set
            {
                Editorial = value;
            }
        }
        public byte PConsulta
        {
            get
            {
                return Consulta;
            }
            set
            {
                Consulta = value;
            }
        }
        public char PPrestarA
        {
            get
            {
                return PrestarA;
            }
            set
            {
                PrestarA = value;
            }
        }
    }
}
