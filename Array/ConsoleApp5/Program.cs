using System;

namespace ConsoleApp5
{
    class Program
    {
        /*
         5.	Encontrar el máximo y el mínimo elemento de array.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Encontrar el máximo y el mínimo elemento de array.");

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

            int[] array = crearArray(tamaño);
            imprimir(array);

            Console.WriteLine($"El Maximo del array es {maximo(array)}");
            Console.WriteLine($"El Minimo del array es {minimo(array)}");

            Console.ReadLine();

        }

        public static int[] crearArray(int tamañovector)
        {
            int[] vector = new int[tamañovector];
            Random random = new Random();

            int numero = 1;
            int i = 0;
            while (i < tamañovector)
            {

                numero = random.Next(0, 100);
                vector[i] = numero;
                i++;

                numero++;
            }
            return vector;
        }

        public static int maximo(int[] array)
        {
            int maximo = 0;

            foreach (int item in array)
            {
                if (item>maximo)
                {
                    maximo = item;
                }
            }
            return maximo;
        }

        public static int minimo(int[] array)
        {
            int minimo = 0;

            foreach (int item in array)
            {
                if (minimo == 0)
                {
                   minimo=item;
                    
                }

                if (item < minimo)
                {
                    minimo = item;
                }
            }
            return minimo;
        }

        public static void imprimir(int[] array)
        {
            Console.WriteLine("-------------------");

            foreach (int item in array)
            {
                Console.WriteLine($" {item}");
            }
        }
    }
}
