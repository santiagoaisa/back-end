using System;

namespace ConsoleApp7
{
    class Program
    {
        /*
         7.	Implementar el ejercicio anterior usando recursividad.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Llenar un Array de 8 elementos");



            int[] array = crearArray(8);
            imprimir(array);

            int indice = 0;
            try
            {
                Console.WriteLine($"Ingrese el numero de elemento a devolver del 1 al {array.Length}\n");
                indice = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Debe ingresar un indice válido");
            }

            Console.WriteLine($"El indice {indice} corresponde al numero {buscar(array, indice)}");

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

        public static int buscar(int[] array, int indice)
        {
            return array[indice - 1];
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
}
