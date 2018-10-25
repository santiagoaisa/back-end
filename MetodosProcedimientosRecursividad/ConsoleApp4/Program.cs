using System;

namespace ConsoleApp4
{
    class Program
    {
        /*
         5.	Implementar un método que me permita saber la suma de todos los números anteriores de un número ingresado por teclado.
         */
        static void Main(string[] args)
        {

            Console.WriteLine("** Ingrese un numero para calcular la suma de todos los número anteriores ****");
            Console.WriteLine("Ingrese un numero\n");
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
            Console.WriteLine($"La suma de números anteriores a {numero}  es {sumadeNumeros(numero)}");

            Console.ReadLine();

        }


        public static int sumadeNumeros(int numero)
        {
            int suma = 0;
            for (int i = 0; i < numero; i++)
            {
                suma = suma + i;
            }
            return suma;
        }
    }
}
