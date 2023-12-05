using System;
using System.Collections.Generic;
using System.Text;

namespace ArrObjInventario
{
    public class ManejaInventario
    {
        private Articulo[] ArrArticulos = new Articulo[15];
        private int NumArt = 0;

        //AGREGA ARTICULOS *
        public void AgregaArticulo(int clave, string nombre, int existencia, double precio, string marca)
        {
            ArrArticulos[NumArt] = new Articulo(clave, nombre, existencia, precio, marca);
            NumArt++;
        }


        //BUSCA ARTICULOS X CLAVE
        public bool buscaArticulo(int clave)
        {
            bool encontro = false;
            foreach (Articulo item in ArrArticulos)
            {
                if (item != null)
                {
                    if (item.pClaveArt == clave)
                    {
                        encontro = true;
                        break;
                    }
                }
            }
            return encontro;
        }

        //REGRESA ARTICULOS X MARCA
        public string[] RegresaArtsMarca(string marca)
        {
            string[] arreglo = new string[NumArt];

            for (int i = 0; i < NumArt; i++)
            {
                if (ArrArticulos[i] != null)
                {
                    if (ArrArticulos[i].pMarca.Equals(marca))
                    {
                        arreglo[i] = ArrArticulos[i].ToString();
                    }
                }

            }
            return arreglo;
        }
        // Manda Articulos *
            public string[] verArticulos()
        {
            string []regresa = new string[NumArt];
            for (int i =0;i<NumArt;i++)
            {
                regresa[i]= ArrArticulos[i].ToString();
            }
            return regresa;
        }
        //Modificar Articulos *
        public string ModificarArticulo(int Clave, string Descripcion, int Cantidad, double Precio, string Marca)
        {
            string Retorno = "";
            for (int i = 0; i < NumArt; i++)
            {
                if (Clave == ArrArticulos[i].pClaveArt)
                {
                    ArrArticulos[i] = new Articulo(Clave, Descripcion, Cantidad, Precio, Marca);
                    Retorno = "Se a modificado el articulo con Clave: " + Clave + ". Los nuevos valores:" +
                     " Descripcion: " + Descripcion + ", Cantidad: " + Cantidad + ", Precio: " + Precio + ", Marca: " + Marca;
                }
            }
            return Retorno;
        }

        //VENDER ARTICULOS *
        public string VendeArticulo(int Clave, int Cantidad)
        {
            string EstadoDeVenta = "Venta Exitosa";
            for (int i = 0; i < NumArt; i++)
            {
                if ((Clave == ArrArticulos[i].pClaveArt))
                {
                    if ((ArrArticulos[i].pExistencia - Cantidad) < 0)
                    {
                        EstadoDeVenta = "Error en venta, No existe la cantidad suficiente en inventario";
                    }
                    else
                    {
                        ArrArticulos[i].pExistencia = ArrArticulos[i].pExistencia - Cantidad;
                    }
                }

            }
            return EstadoDeVenta;
        }
        //VALIDAR CLAVE REPETIDA
        public bool ValidaClave(int Clave)
        {
            bool Repetido = false;
            for (int i = 0; i < NumArt; i++)
            {
                if (Clave == ArrArticulos[i].pClaveArt)
                {
                    Repetido = true;
                }
            }
            return Repetido;
        }

        //VALIDA EXISTENCIA DE LA CLAVE
        public bool ValidaExistenciaClave(int Clave)
        {
            bool Existe = false;
            for (int i = 0; i < NumArt; i++)
            {
                if (Clave == ArrArticulos[i].pClaveArt)
                {
                    Existe = true;
                }
            }
            return Existe;
        }
        //REVISA MARCA
        public bool RevisaExisMarca(string marca)
        {
            bool bandera = false;
            for (int i = 0; i < NumArt; i++)
            {
                if (ArrArticulos[i].pMarca.Equals(marca))
                {
                    bandera = !bandera;
                    break;
                }
            }
            return bandera;
        }
        //VALIDAR CANTIDAD MAYOR A 0
        public  bool ValidaCantidad(int cantidad)
        {
            bool CantidadBien = true;
            if (cantidad <= 0)
            {
                CantidadBien = false;
            }
            return CantidadBien;
        }
        //VALIDAR PRECIO MAYOR A 0
        public bool ValidaPrecio(double Precio)
        {
            bool CostoBien = true;
            if (Precio <= 0)
            {
                CostoBien = false;
            }
            return CostoBien;
        }

    }
 
}
