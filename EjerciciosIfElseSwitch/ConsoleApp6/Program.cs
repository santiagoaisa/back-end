using System;

namespace ConsoleApp6
{
    class Program
    {
        /*
         Crear una aplicación que pida una letra y detecte si es una vocal.

             */
        static void Main(string[] args)
        {
            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Ingrese una letra para determinar si es una vocal ****\n");
            String letra = Console.ReadLine().ToUpper();
            Console.WriteLine("\n");

            if (letra.Contains('A') || letra.Contains('E') || letra.Contains('I') || letra.Contains('O') || letra.Contains('U')  )
            {
                Console.WriteLine($"La letra {letra} SI es una vocal");
            }
            else
            {
                Console.WriteLine($"La letra {letra} NO es una vocal");
            }

            
            Console.ReadLine();
        }
    }
}
