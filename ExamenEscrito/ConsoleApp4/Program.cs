using System;

namespace ConsoleApp4
{
    class Program
    {
        /*
         5.	Un maestro desea saber qué porcentaje de hombres y que porcentaje de mujeres 
         hay en un grupo de estudiantes.
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de hombres en el salon:");
            double hombres = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de mujeres en el salon:");
            double mujeres = Double.Parse(Console.ReadLine());

            double total = hombres + mujeres;
            
            double porcentajeHombres = Math.Round((hombres / total) * 100, 2); 
            double porcentajeMujeres = Math.Round((mujeres / total) * 100, 2); 

            Console.WriteLine($"Hay {hombres} hombres que representa el  {porcentajeHombres}%");
            Console.WriteLine($"Hay {mujeres} mujeres que representa el  {porcentajeMujeres}%");

            Console.ReadLine();
        }

       
    }
}
