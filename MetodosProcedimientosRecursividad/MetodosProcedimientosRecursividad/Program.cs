using System;

namespace MetodosProcedimientosRecursividad
{
    class Program
    {
        /*
         1.	Implementar un método que me permita sacar el promedio de N calificaciones de un alumno, una vez calculado el promedio, Crear otro método que me permita saber si el alumno aprobó “mayo a 10.5” o desaprobó “menor a 10.5”.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("** Ingrese N notas ****");

            Console.WriteLine("Ingrese el número de notas para calcular el promedio");
            int numeroNotas = 0;
            try
            {
                numeroNotas = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Debe ingresar una nota valida");

            }

           double promedio= calcularPromedio(numeroNotas);
           estadoPromedio(promedio);
           Console.ReadLine();

            
        }

        public static double calcularPromedio(int numeroNota)
        {

            double total = 0;
            double nota=0;
            for (int i=1;i<=numeroNota;i++)
            {
                Console.WriteLine($"Ingrese la nota {i}");
                nota = double.Parse(Console.ReadLine());

                total = total + nota;
            }

            return Math.Round(total / numeroNota,2);
        }


        public static void estadoPromedio(double promedio)
        {
            Console.WriteLine("-------------------------------");

            if (promedio>=10.50)
            {
                Console.WriteLine($"APROBO con un promedio de {promedio} ");
            }
            else
            {
                Console.WriteLine($"DESAPROBO con un promedio de {promedio} ");
            }

        }


        

    }
}
