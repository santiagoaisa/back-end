using System;

namespace ConsoleApp8
{
    class Program
    {
        /*
         Crear una aplicación que pida tres números e indicar si el tercero es igual a la suma del primero y el segundo.

         */
        static void Main(string[] args)
        {

            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Ingrese 3 números para indicar si el 3ro es la suma del 1er y el 2do****\n");

            Console.WriteLine("Numero 1:\n");
            int numero1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Numero 2:\n");
            int numero2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Numero 3:\n");
            int numero3 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            if (numero3==(numero1+numero2))
            {
                Console.WriteLine($"El {numero3} SI es la suma de {numero1} y {numero2}");
            }
            else
            {
                Console.WriteLine($"{numero3} NO es la suma de {numero1} y {numero2}");
            }

            Console.ReadLine();
        }
    }
}
