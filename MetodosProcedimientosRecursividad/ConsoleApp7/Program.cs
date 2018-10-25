using System;

namespace ConsoleApp7
{
    class Program
    {
        /*
         * 8.	Implementar el ejercicio anterior usando recursividad.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("** La potencia usando recursividad. ****");

            double numero = 0, exponente = 0;
            try
            {
                Console.WriteLine("Ingrese la base\n");
                numero = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el exponente\n");
                exponente = double.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Debe ingresar un numero válido");
            }

            Console.WriteLine($"------------------------");
            Console.WriteLine($"La potencia de {numero}  con el exponente {exponente}  es {potencia(numero, exponente)}");

            Console.ReadLine();
        }


        public static double potencia(double numero, double exponente)
        {

            if (exponente==0)
            {
                return 1;
            }

            return numero*potencia(numero,exponente-1);
        }
    }
}
