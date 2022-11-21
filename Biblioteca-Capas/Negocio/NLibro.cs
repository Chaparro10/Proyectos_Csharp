using System;
using System.Collections.Generic;
using System.Data;
using Biblioteca.Datos;
using Biblioteca.Entidades;

namespace Biblioteca.Negocio
{
    public class NLibro
    {

        public static DataTable ObtenLibros()
        {
            return DLibro.ObtenLibros();
        }
        public static  string Agregar(Libro libro)
        {
            string existe = DLibro.BuscarIsbn(libro.PIsbn);
            if (existe.Equals("0"))
            {
                return DLibro.Agregar(libro);
            }
            else
            {
                return "YA EXISTE";
            }
        }
        public static string BuscarNombreLibro(string nombreLibro)
        {
            string respuesta = "NO EXISTE";
            string retorno = DLibro.BuscarNombreLibro(nombreLibro);
            if (retorno.Equals("1"))
                respuesta = "YA EXISTE";
            return respuesta;
            
        }
        public static string BuscarISBNLibro(string ISBN)
        {
            string respuesta = "NO EXISTE";
            string retorno = DLibro.BuscarIsbn(ISBN);
            if (retorno.Equals("1"))
            respuesta = "YA EXISTE";
            return respuesta;
        }
        public static DataTable ObtenerLiS(string NombreLi)
        {
            return DLibro.BuscarLi(NombreLi);
        }
        public static string Actualizar(Libro libro)
        {
            return DLibro.Actualizar(libro);
        }
        public static string Eliminar(Libro libro)
        {
            return DLibro.Eliminar(libro);
        }
    }
}
