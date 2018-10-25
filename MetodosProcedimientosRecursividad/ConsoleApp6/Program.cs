using System;

namespace ConsoleApp6
{
    class Program
    {
        /*
         *7.	Implementar un método que calcule la potencia de un número, ingresando por teclado la base y el exponente.
         */
        static void Main(string[] args)
        {

            Console.WriteLine("** Ingrese la numero y su exponente para calcular su potencia ****");
            
            double numero = 0,exponente=0;
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
            Console.WriteLine($"La potencia de {numero}  con el exponente {exponente}  es {potencia(numero,exponente)}");

            Console.ReadLine();

        }

        public static double potencia(double numero,double exponente)
        {
            double total = 1;
            for (int i = 1; i <= exponente; i++)
            {
                total = total * numero;
            }
            return total;
        }
    }
}
