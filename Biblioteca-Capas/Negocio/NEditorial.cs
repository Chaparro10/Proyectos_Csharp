using System;
using System.Collections.Generic;
using System.Data;
using Biblioteca.Datos;
using Biblioteca.Entidades;

namespace Biblioteca.Negocio
{
   public  class NEditorial
    {
        
        public static DataTable ObtenEditorial()
        {
            return DEditorial.ObtenEditorial();
        }
        public static string Agregar(Editorial Edi)
        {
            string existe = DEditorial.BuscarNombreEdi(Edi.PNombreEdi);
            if (existe.Equals("0"))
            {
                return DEditorial.Agregar(Edi);
            }
            else
            {
                return "YA EXISTE";
            }
        }
    }
}
