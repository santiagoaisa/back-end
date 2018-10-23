using System;

namespace EjercicioBucleFor
{
    class Program
    {

        static void Main(string[] args)
        {
            //ejercicio1();
            // ejercicio2();
            ejercicio3();
        }


        private static void ejercicio1()
        {
            /*
            1.	 Calcular el promedio de un alumno que tiene 7 calificaciones en la materia de Algoritmos Avanzados y estructura de Datos.
            */
            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Ingrese 7 notas del curso Back-End para calcular su promedio ****\n");


            int notas = 0;
            int cantidadNotas = 7;

            for (int n = 1; n <= cantidadNotas; n++)
            {
                Console.Write("Ingrese la Nota " + n + "\n");
                notas = notas + Int32.Parse(Console.ReadLine());
            }

            Console.Write($"El promedio de las 7 notas es {notas / cantidadNotas} ");
            Console.ReadLine();
        }

        private static void ejercicio2()
        {
            /*
            2.	Leer 10 números y obtener su cubo y su cuarta.
            */
            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Ingrese 10 números para obtener su cubo y cuarta****\n");


            int cantidadNumeros = 10;

            int numero = 0;
            String cadena = "Numero  Cubo   Cuarta\n";
            cadena = cadena + "---------------------\n";
            for (int n = 1; n <= cantidadNumeros; n++)
            {
                Console.Write("Ingrese el numero " + n + "\n");
                numero = Int32.Parse(Console.ReadLine());
                cadena = cadena + "  " + numero + "    " + Math.Pow(numero, 3) + "   " + Math.Pow(numero, 4) + "\n";
            }

            Console.Write(cadena);
            Console.ReadLine();
        }

        private static void ejercicio3()
        {
            /*
           3.	Leer 10 números e imprimir solamente los números positivos (Posible solución “Concatenar positivos e imprimirlos”).
           */
            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Ingrese 10 números para determinar cual es positivo o negativo****\n");

            int cantidadNumeros = 10;
            int numero = 0;
            String cadena = " ";

            for (int n = 1; n <= cantidadNumeros; n++)
            {
                Console.Write("Ingrese el numero " + n + "\n");
                numero = Int32.Parse(Console.ReadLine());

                if (numero >= 0)
                {
                    cadena = cadena + $" {numero} \n";
                }


            }

            Console.Write("Números Positivos\n");
            Console.Write(cadena);
            Console.ReadLine();

        }


        private static void ejercicio4()
        {
            /*
           4.	Leer 20 números e imprimir cuantos son positivos, cuantos negativos y cuantos neutros.
           */
            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Ingrese 10 números para determinar cual es positivo o negativo****\n");

            int cantidadNumeros = 10;
            int numero = 0;
            String cadena = " ";

            for (int n = 1; n <= cantidadNumeros; n++)
            {
                Console.Write("Ingrese el numero " + n + "\n");
                numero = Int32.Parse(Console.ReadLine());

                if (numero >= 0)
                {
                    cadena = cadena + $" {numero} \n";
                }


            }

            Console.Write("Números Positivos\n");
            Console.Write(cadena);
            Console.ReadLine();

        }

    }
}