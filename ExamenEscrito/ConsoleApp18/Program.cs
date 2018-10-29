using System;

namespace ConsoleApp18
{
    class Program
    {
        /*
        19.	Colocar a un apellido el prefijo Profesor Ejm:
        Ingresado Gómez imprima Profesor Gómez
         */

        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese el prefijo para Profesor :");
            String  prefijo = Console.ReadLine();
            String cadena = "Profesor";

            Console.WriteLine($"La frase es {cadena} {prefijo}");
            Console.ReadLine();

        }
    }
}
