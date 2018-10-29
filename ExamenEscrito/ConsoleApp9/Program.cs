using System;

namespace ConsoleApp9
{
    class Program
    {
        /*
         10.	Calcular el número de pulsaciones que una persona debe tener por cada 10 segundos 
         de ejercicio, si la fórmula es: 
        núm. pulsaciones = (220 - edad)/10

         */
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su edad:");
            double edad = Double.Parse(Console.ReadLine());
            double pulsaciones = (220 - edad) / 10;

            Console.WriteLine($"El número de pulsaciones es {pulsaciones} por cada 10 segundos");
            Console.ReadLine();
        }
    }
}
