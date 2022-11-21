using System;


namespace Biblioteca.Entidades
{
   public  class Editorial
    {
        private string NombreEdi;
        private string Telefono;
        private string Correo;

        public Editorial(string nombreEdi, string telefono, string correo)
        {
            NombreEdi = nombreEdi;
            Telefono = telefono;
            Correo = correo;
        }

        public string PNombreEdi
        {
            get
            {
                return NombreEdi;
            }
            set
            {
                NombreEdi = value;
            }
        }
        public string PTelefono
        {
            get
            {
                return Telefono;
            }
        }
        public string PCorreo
        {
            get
            {
                return Correo;
            }
        }
    }
}
