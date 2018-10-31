using System;

namespace ConsoleApp4
{
    class Program
    {
        /*
         4.	Implementar el ejercicio anterior usando recursividad.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("** Realizar un programa que te permita sumar todos los elementos de un array,  ****");

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
            Console.WriteLine($"La suma del array es {sumar(array,array.Length-1)}");
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

                numero =  random.Next(0, 20);
                vector[i] = numero;
                i++;

                numero++;
            }



            return vector;
        }

        public static int sumar(int[] array,int index)
        {

            if (index==0)
            {
                return array[index];
            }
            

            return array[index] + sumar(array,index-1);
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
