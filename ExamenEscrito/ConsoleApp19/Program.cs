using System;

namespace ConsoleApp19
{
    class Program
    {
        /*
         20.	Escriba un algoritmo que permita convertir un valor ingresado en pies a metros. 
                Si 1 pie = 30.48 cm.

         */

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de pies para convertirla a metros:");
            double pies = Double.Parse(Console.ReadLine());
            double metros = (pies * 30.48) / 100;

            Console.WriteLine($"Los {pies} pies convertido a metros es {metros}");
            Console.ReadLine();
        }
    }
}
