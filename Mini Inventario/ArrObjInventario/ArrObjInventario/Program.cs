using System;

namespace ArrObjInventario
{

    public class Program
    {
        ManejaInventario m;
        PresentaArticulos presenta;
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.m = new ManejaInventario();
            p.presenta = new PresentaArticulos(p.m);

            p.presenta.Menu();
            
            Console.ReadKey();
        }
    }
}
