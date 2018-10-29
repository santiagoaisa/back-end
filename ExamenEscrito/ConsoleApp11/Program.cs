using System;

namespace ConsoleApp11
{
    class Program
    {
        /*
         12.	En un hospital existen tres áreas: Ginecología, Pediatría, Traumatología. 
         El presupuesto anual del hospital se reparte conforme a la sig. Tabla: 
        Área Porcentaje del presupuesto 
        Ginecología 40% 
        Traumatología 30% 
        Pediatría 30%

         */

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el presupuesto anual:");
            double presupuesto = Double.Parse(Console.ReadLine());

            double porcentajeGinecologia = 40;
            double porcentajeTraumatologia = 30;
            double porcentajePediatria = 30;

            double ginecologia = Math.Round((porcentajeGinecologia / 100) * presupuesto,2);
            double traumatologia = Math.Round((porcentajeTraumatologia / 100) * presupuesto, 2);
            double pediatria = Math.Round((porcentajePediatria / 100) * presupuesto, 2);

            Console.WriteLine($"El presupuesto se repartira de la siguiente forma");
            Console.WriteLine($"Ginecologia {ginecologia}");
            Console.WriteLine($"Traumatologia {traumatologia}");
            Console.WriteLine($"Pediatria {pediatria}");

            Console.ReadLine();

        }
    }
}
