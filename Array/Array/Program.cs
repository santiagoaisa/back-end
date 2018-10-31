using System;

namespace Array
{
    class Program
    {
        /*
         1.	Hacer un programa que inicialice un array con los 10 primeros naturales pares y luego los imprima. 
         */
        static void Main(string[] args)
        {
            

            Console.WriteLine("**** Hacer un programa que inicialice un array con los 10 primeros naturales pares  ****");
            int[] array=crearVector(10);
            imprimir(array);
            Console.ReadLine();
        }


        public static int[] crearVector(int tamañovector)
        {
            int[] vector = new int[tamañovector];

            string [,] hola= new string[2,1];

            int numero = 1;
            int i = 0;
            while (i<tamañovector)
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
            Console.WriteLine("Vector Ordenado");
            

            foreach (int item in vector)
            {
                Console.WriteLine($" {item}");
            }
        }
    }
}
