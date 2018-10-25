using System;

namespace ConsoleApp2
{
    class Program
    {
        /*
         * 3.	Implementar un método que me permita saber cuál es el factorial de un número cualquiera.
         */

        static void Main(string[] args)
        {
            Console.WriteLine("** Ingrese un numero para calcular el factorial ****");
            Console.WriteLine("Ingrese un para calcular su factorial\n");
            int numero = 0;
            try
            {
                numero = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Debe ingresar un numero válido");

            }

            

            Console.WriteLine($"------------------------");
            Console.WriteLine($"El factorial de {numero}  es {factorial(numero)}");

            Console.ReadLine();
        }

        public static int factorial(int numero)
        {

            int factorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
        }
    }

}