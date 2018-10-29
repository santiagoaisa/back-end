using System;

namespace ConsoleApp17
{
    class Program
    {
        /*
         18.	Obtener la edad de una persona en meses, si se ingresa su edad en años y meses.
         Ejm: 3 años 4 meses da 40 meses.
         */

        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese su edad en años y mese");

            Console.WriteLine("Ingrese años:");
            int años = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese meses:");
            int meses = Int32.Parse(Console.ReadLine());

            int edadMeses = años * 12 + meses;
            Console.WriteLine($"Su edad en meses es de {edadMeses}");
            Console.ReadLine();
        }
    }
}
