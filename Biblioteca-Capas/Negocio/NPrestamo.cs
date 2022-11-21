using System;
using System.Data;
using Biblioteca.Datos;
using Biblioteca.Entidades;

namespace Biblioteca.Negocio
{
    public class NPrestamo
    {
        public static DataTable ObtenPrestamo()
        {
            return DPrestamo.ObtenPrestamo();
        }
        public static DataTable ObtenISBNPres()
        {
            return DPrestamo.ObtenISBNPre();
        }
        public static string Agregar(Prestamo Prestar)
        {
            string existe = DPrestamo.BuscarCvePrestamo(Prestar.PClavePrestamo);
            if (existe.Equals("0"))
            {
                return DPrestamo.Agregar(Prestar);
            }
            else
            {
                return "YA EXISTE";
            }
        }
    }
}
