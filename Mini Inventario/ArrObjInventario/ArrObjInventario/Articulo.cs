using System;
using System.Collections.Generic;
using System.Text;

namespace ArrObjInventario
{
    public class Articulo
    {
        private int ClaveArt;
        private string NombreArt;
        private int Existencia;
        private double Precio;
        private string Marca;

        public Articulo(int claveArt, string nombreArt, int existencia, double precio, string marca)
        {
            ClaveArt = claveArt;
            NombreArt = nombreArt;
            Existencia = existencia;
            Precio = precio;
            Marca = marca;
        }

        public int pClaveArt
        {
            get
            {
                return ClaveArt;
            }
        }

        public string pNombreArt
        {
            get
            {
                return NombreArt;
            }
            set
            {
                NombreArt = value;
            }
        }

        public int pExistencia
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
       

        public double pPrecio
        {
            get
            {
                return Precio;
            }
            set
            {
                Precio = value;
            }
        }

        public string pMarca
        {
            get
            {
                return Marca;
            }
            set
            {
                Marca = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Clave {0} Nombre {1} Precio {2} Existencia {3} Marca {4}",ClaveArt,NombreArt,Precio,Existencia,Marca);
        }

    }
}
