using System;

namespace ConsoleApp5
{
    class Program
    {
        /*
         Crear una aplicación que pida un número y diga si es positivo o negativo.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Ingrese un numero para determinar si es POSITIVO o NEGATIVO ****\n");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            String resultado = (numero > 0 ? "ES POSITIVO" : "ES NEGATIVO");
            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}
