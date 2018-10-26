using System;

namespace ConsoleApp2
{
    class Program
    {
        /*
         * 2.	Hacer un programa que inicialice un array con los N primeros naturales pares y luego los imprima.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("** Hacer un programa que inicialice un array con los N primeros naturales pares ****");

            int tamaño = 0;
            try
            {
                Console.WriteLine("Ingrese la longitud del array\n");
                tamaño = Int32.Parse(Console.ReadLine());


            }
            catch (FormatException e)
            {
                Console.WriteLine("Debe ingresar un numero válido");
            }

            int[] array = crearVector(tamaño);         
            imprimir(array);
            Console.ReadLine();
        }

        public static int[] crearVector(int tamañovector)
        {
            int[] vector = new int[tamañovector];

            int numero = 1;
            int i = 0;
            while (i < tamañovector)
            {

                if (numero % 2 == 0)
                {
                    vector[i] = numero;
                    i++;
                }

                numero++;
            }



            return vector;
        }

        public static void imprimir(int[] vector)
        {
            Console.WriteLine("-------------------");
          
            foreach (int item in vector)
            {
                Console.WriteLine($" {item}");
            }
        }

    }
}
