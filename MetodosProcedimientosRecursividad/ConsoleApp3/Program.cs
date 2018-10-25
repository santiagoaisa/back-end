using System;

namespace ConsoleApp3
{
    class Program
    {
        /*
         * 4.	Implementar el Método anterior usando una función recursiva.
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

            int factorialCalculado=factorial(numero);

            Console.WriteLine($"------------------------");
            Console.WriteLine($"El factorial de {numero}  es {factorialCalculado}");

            Console.ReadLine();
        }

        public static int factorial(int numero)
        {
            if (numero == 1)
                return 1;
            return numero * factorial(numero - 1);
        }
    }
}
