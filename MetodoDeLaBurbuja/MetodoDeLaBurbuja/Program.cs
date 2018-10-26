using System;

namespace MetodoDeLaBurbuja
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("** Metodo de la Burbija ****");

            int tamaño = 0;
            try
            {
                Console.WriteLine("Ingrese la longitud del vector\n");
                tamaño = Int32.Parse(Console.ReadLine());

                
            }
            catch (FormatException e)
            {
                Console.WriteLine("Debe ingresar un numero válido");
            }

            int[] vector = crearVector(tamaño);

            imprimir(vector);

            ordenarMetodoBurbuja(vector);
            imprimir(vector);

            Console.ReadLine();
        }


        public static int[] crearVector(int tamañovector)
        {
            int[] vector = new int[tamañovector];

            int numero = 0;

            for (int i = 0; i < vector.Length; i++)
            {

                Console.Write("Ingrese el elemento " + (i + 1) + ": ");
                numero = int.Parse(Console.ReadLine());
                vector[i] = numero;

            }

            return vector;
        }

        public static void ordenarMetodoBurbuja(int[] vector)
        {

            int numero=0;
            for (int i = 0; i < vector.Length; i++)
            {

                for (int j = vector.Length-1; j >i;j--)
                {
                    if (vector[j-1]>vector[j])
                    {
                        numero = vector[j - 1];
                        vector[j - 1] = vector[j];
                        vector[j] = numero;
                    }
                }

            }

        }

        public static void imprimir(int[] vector)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Vector Ordenado");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i] +" ");
            }
        }

    }
}
