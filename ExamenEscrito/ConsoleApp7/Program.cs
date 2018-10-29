using System;

namespace ConsoleApp7
{
    class Program
    {
        /*
       8.	Leer un número y escribir el valor absoluto del mismo.
       */

        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un número:");
            double numero = Double.Parse(Console.ReadLine());

            Console.WriteLine($"El valor absoluto del numero es {Math.Abs(numero)}");

            Console.ReadLine();
        }


    }
}
