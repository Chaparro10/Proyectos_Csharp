using System;
using System.Collections.Generic;
using System.Text;

namespace ArrObjInventario
{
    public class PresentaArticulos
    {
        ManejaInventario Minventario;

        public PresentaArticulos(ManejaInventario Minventario)
        {
            this.Minventario = Minventario;
        }
        //PEDIR ARTICULOS PARA AGREGARLOS
        public void PedirArticulo()
        {
            Console.WriteLine("Ingresa la Clave");
            int Clave = Convert.ToInt32(Console.ReadLine());

           

            bool Repetida = Minventario.ValidaClave(Clave);
            if (Repetida == true)
            {
                Console.WriteLine("# Error #");
                Console.WriteLine("Ya existe esta clave");
            }
            else
            {
                Console.WriteLine("Ingresa la descripcion");
                string Descripcion = Console.ReadLine();

                    Console.WriteLine("Ingresa la cantidad");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    bool CantidadBien = Minventario.ValidaCantidad(Cantidad);

                    while (CantidadBien == false)
                    {
                        Console.WriteLine("# El numero es negativo #");
                        Console.WriteLine("Ingresa la cantidad otra vez");
                        Cantidad = Convert.ToInt32(Console.ReadLine());
                        CantidadBien = Minventario.ValidaCantidad(Cantidad);
                    }


                    Console.WriteLine("Ingresa el precio");
                    double Precio = Convert.ToDouble(Console.ReadLine());
                    bool CostoBien = Minventario.ValidaPrecio(Precio);


                    while (CostoBien == false)
                    {
                        Console.WriteLine("# El numero es negativo #");
                        Console.WriteLine("Ingresa el precio otra vez");
                        Precio = Convert.ToDouble(Console.ReadLine());
                        CostoBien = Minventario.ValidaPrecio(Precio);
                    }

                    Console.WriteLine("Ingresa la marca");
                    string Marca = Console.ReadLine();
                    Minventario.AgregaArticulo(Clave, Descripcion, Cantidad, Precio, Marca);
                }
            }
        //METODO PARA IMPRIMIR ARTICULOS(INVENTARIO)
        public void MuestraArticulos()
        {
            string[] ListaArticulos = Minventario.verArticulos();
            Console.WriteLine("===================== Estos son los articulos disponibles =====================");
            foreach (string item in ListaArticulos)
            {
                Console.WriteLine(item);
            }
        }
        public void MuestraArticulosxMarca()
        {
            Console.WriteLine("Ingresa la Marca: ");
            string marca = Console.ReadLine();
            if (Minventario.RevisaExisMarca(marca))
            {
                string[] arr = Minventario.RegresaArtsMarca(marca);
                foreach (string art in arr)
                {
                    Console.WriteLine(art);
                }
            }
            else
                Console.WriteLine("\nERORR: \t***No existe la marca***\n");

        }
        //METODO PARA MODIFICAR
        public void ModificarArticulo()
        {
            Console.WriteLine("Dame la clave del articulo que deseas modificar");
            int Clave = Convert.ToInt32(Console.ReadLine());
            bool Existencia = Minventario.ValidaExistenciaClave(Clave);
            if (Existencia == true)
            {
                Console.WriteLine("Dame la nueva Descripcion");
                string Descripcion = Console.ReadLine();
                Console.WriteLine("Dame la nueva Cantidad");
                int Cantidad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dame el nuevo Precio");
                double Precio = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Dame la nueva Marca");
                string Marca = Console.ReadLine();
                string Modificacion = Minventario.ModificarArticulo(Clave, Descripcion, Cantidad, Precio, Marca);
                Console.WriteLine(Modificacion);
            }
            else
            {
                Console.WriteLine("La clave es invalida");
            }
        }
      
        //METODO PARA VENDER
        public void VenderArticulo()
        {
            MuestraArticulos();
            Console.WriteLine("¿Que articulo quieres?");
            Console.WriteLine("Escribe su Clave");
            int clave =Convert.ToInt32(Console.ReadLine());
            bool Existencia = Minventario.ValidaClave(clave);
            if (Existencia == true)
            {
                Console.WriteLine("Escribe la cantidad");
                int cantidad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Minventario.VendeArticulo(clave, cantidad));
            }
            else
            {
                Console.WriteLine("# La clave no coincide con ningun articulo #");
            }
        }
        //Buscar Articulo


        //MENU INVENTARIO
        public void Menu()
        {
            int menu = 0;
            while (menu != 7)
            {

                Console.WriteLine("            MENU                ");
                Console.WriteLine("      |  1 ---- Agregar articulo ");
                Console.WriteLine("      |  2 ---- Mostrar Articulos ");
                Console.WriteLine("       |  3 ---- Modificar Articulo ");
                Console.WriteLine("       |  4 ---- Buscar articulo x Marca ");
                Console.WriteLine("       |  5 ---- $Vender$");
                Console.WriteLine("       |   ---- Salir             ");
                Console.WriteLine(" ===========================================");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        PedirArticulo();
                        break;
                    case 2:
                        MuestraArticulos();
                        break;
                    case 3:
                        ModificarArticulo();
                        break;
                    case 4:
                        MuestraArticulosxMarca();
                        break;
                    case 5:
                        VenderArticulo();
                        break;
                    case 6:
                        Console.WriteLine("# Saliste #");
                        Console.WriteLine("(Preciona cualquier tecla)");
                        break;
                    default:
                        Console.WriteLine("# Error #");
                        Console.WriteLine("(El numero no esta en el menu)");
                        break;
                }
            }
        }
    }
}


       

