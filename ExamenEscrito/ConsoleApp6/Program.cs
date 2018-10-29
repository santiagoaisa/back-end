using System;

namespace ConsoleApp6
{
    class Program
    {
        /*
         7.	Dada una cantidad en Soles, obtener la equivalencia en dólares, 
         asumiendo que la unidad cambiaría es un dato desconocido.
         */
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un monto es soles para realizar el cambio a dolares:");
            double montoSoles= Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tipo de cambio:");
            double tipoCambio = Double.Parse(Console.ReadLine());

            double dolares = Math.Round(montoSoles / tipoCambio, 2);

            Console.WriteLine($"El monto ingresado en $ es {dolares}");

            Console.ReadLine();

        }

       

    }
}
