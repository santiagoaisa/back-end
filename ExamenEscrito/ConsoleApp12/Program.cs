using System;

namespace ConsoleApp12
{
    class Program
    {
        /*
         13.	Obtener la cantidad de dinero que recibirá cada área,
         para cualquier monto presupuestal.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el presupuesto anual:");
            double presupuesto = Double.Parse(Console.ReadLine());

            double porcentajeGinecologia = 40;
            double porcentajeTraumatologia = 30;
            double porcentajePediatria = 30;

            double ginecologia = Math.Round((porcentajeGinecologia / 100) * presupuesto, 2);
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
