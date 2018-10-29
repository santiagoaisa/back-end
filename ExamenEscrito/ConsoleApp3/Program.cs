using System;

namespace ConsoleApp3
{
    class Program
    {
        /*
         4.	Un alumno desea saber cuál será su calificación final en la materia de Algoritmos. 
         Dicha calificación se compone de los siguientes porcentajes: 
        55% del promedio de sus tres calificaciones parciales. 
        30% de la calificación del examen final. 
        15% de la calificación de un trabajo final.

         */

        static void Main(string[] args)
        {
            Console.WriteLine("*** Calificación final en la materia de Algoritmos ***");
            Console.WriteLine("Ingrese el Promedio de sus tres calificaciones parciales:");
            double promedioParciales = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la calificación final:");
            double examenFinal = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la calificación del trabajo final:");
            double trabajoFinal = Double.Parse(Console.ReadLine());

            double peso1 = 0.55;
            double peso2 = 0.30;
            double peso3 = 0.15;

            double promedio = (promedioParciales * peso1) + (examenFinal * peso2) + (trabajoFinal * peso3);
            
            Console.WriteLine($"Su promedio es {promedio}");
            Console.ReadLine();
        }

       

    }
}
