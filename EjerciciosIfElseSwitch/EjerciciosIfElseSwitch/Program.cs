using System;

namespace EjerciciosIfElseSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Crear una aplicación .net core que pida un numero del 1 al 5 y que imprima si es Primo.
             */

            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Ingrese un numero del 1 al 5 ****\n");
            int numero = int.Parse(Console.ReadLine()) ;
            Console.WriteLine("\n");

            if (numero>0 && numero<=6) {

                int conteo = 0;

                for (int i = 1; i <= numero; i++)
                {

                    if (numero % i == 0)
                    {
                        conteo = conteo + 1;
                    }

                }

                if (conteo == 2)
                {
                    Console.WriteLine($"El numero {numero} SI es primo ");
                }
                else
                {
                    Console.WriteLine($"El numero {numero} NO es primo ");
                }

            }
            else
            {
                Console.WriteLine("Debe Ingresar un numero del 1 al 5\n");
            }

            Console.Read();
        }
    }
}
