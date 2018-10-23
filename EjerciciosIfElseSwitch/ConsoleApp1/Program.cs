using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Crear una aplicación que pida el ingreso de un numero y que indique si es par o impar.
            */

            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Ingrese un numero para determinar si es PAR o IMPAR ****\n");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            String respuesta=( numero%2==0 ? "El numero es PAR" : "El numero es IMPAR");

            Console.WriteLine(respuesta);
            Console.ReadLine();

        }
    }
}
