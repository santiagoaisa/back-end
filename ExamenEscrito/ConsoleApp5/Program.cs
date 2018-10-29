using System;

namespace ConsoleApp5
{
    class Program
    {
        /*
         6.	Realizar un algoritmo que calcule la edad de una persona en base a su año de nacimiento.
         */

        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese su año de nacimiento:");
            int añonacimiento = Int32.Parse(Console.ReadLine());            
            DateTime fechaActual = DateTime.Today;
            int añoactual= fechaActual.Year;
            int edad = añoactual - añonacimiento;

            Console.WriteLine($"Su edad es de {edad}");
            Console.ReadLine();
        }
    }
}
