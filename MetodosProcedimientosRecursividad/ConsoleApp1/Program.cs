using System;

namespace ConsoleApp1
{
    class Program
    {
        /*
         2.	Implementar Métodos que me permita saber de 3 números cual es el mayor y el menor.
         */
          
        static void Main(string[] args)
        {

            Console.WriteLine("** Ingrese 3 numero ****");
            Console.WriteLine("Ingrese N para calcular el mayor y menor de los números ingresados\n");
            int cantidadNumeros = 0;
            try
            {
                cantidadNumeros = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Debe ingresar un numero válido");

            }

            
           Console.WriteLine($"Ingrese el número 1");
           int numero1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Ingrese el número 2");
            int numero2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Ingrese el número 3");
            int numero3 = Int32.Parse(Console.ReadLine());

            int mayor = calculaMayor(numero1,numero2,numero3);
            int menor = calculaMenor(numero1, numero2, numero3);

            Console.WriteLine($"------------------------");
            Console.WriteLine($"El número Mayor es {mayor}");
            Console.WriteLine($"El número Menor es {menor}");

            Console.ReadLine();

        }

        public static int calculaMayor(int numero1,int numero2, int numero3)
        {

            int mayor = 0;

            if (numero1 > numero2)
            {
                mayor = numero1;
              
            }
            else
            {
                mayor = numero2;
            }

            if (numero3 > mayor)
            {
                mayor=numero3;
            }

            return mayor;

        }

        public static int calculaMenor(int numero1, int numero2, int numero3)
        {

            int  menor = 0;

            if (numero1 < numero2)
            {
                menor = numero1;
            }
            else
            {
               
                menor = numero2;
            }

            if (numero3 < menor)
            {
                menor = numero3;
            }

            return menor;

        }

    }
}
