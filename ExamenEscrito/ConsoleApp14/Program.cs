using System;

namespace ConsoleApp14
{
    class Program
    {
        /*
         15.Todos los lunes, miércoles y viernes, una persona corre la misma ruta y cronometra los tiempos 
         obtenidos. Determinar el tiempo promedio que la persona tarda en 
         recorrer la ruta en una semana cualquiera.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el tiempo en minutos del dia Lunes");
            double tiempoLunes = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tiempo en minutos del dia Miercoles");
            double tiempoMiercoles = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tiempo en minutos del dia Viernes");
            double tiempoViernes = Double.Parse(Console.ReadLine());

            double tiempoTotal = tiempoLunes + tiempoMiercoles + tiempoViernes;

            Console.WriteLine($"Su tiempo promedio en minutos es {Math.Round(tiempoTotal / 3,2)}");
            Console.ReadLine();
        }
    }
}
