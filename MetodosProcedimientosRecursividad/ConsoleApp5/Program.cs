using System;

namespace ConsoleApp5
{
    class Program
    {
        /*
         * 6.	Implementar el ejercicio anterior usando recursividad.
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
            Console.WriteLine($"La suma de números anteriores a {numero}  es {sumadeNumeros(numero-1)}");

            Console.ReadLine();
        }

        public static int sumadeNumeros(int numero)
        {

            if (numero==1)
            {
                return 1;
            }

            return numero+sumadeNumeros(numero-1);
        }
    }
}
