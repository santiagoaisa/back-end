using System;

namespace ConsoleApp15
{
    class Program
    {

        /*
         16.	Tres personas deciden invertir su dinero para fundar una empresa. 
         Cada una de ellas invierte una cantidad distinta. 
         Obtener el porcentaje que cada quien invierte con respecto a la cantidad total invertida.
          */

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el aporte del socio 1:");
            double aporte1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el aporte del socio 2:");
            double aporte2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el aporte del socio 3:");
            double aporte3 = Double.Parse(Console.ReadLine());

            double totalAporte = aporte1 + aporte2 + aporte3;

            double porcentajeAporte1 = Math.Round((aporte1 / totalAporte) * 100, 2);
            double porcentajeAporte2 = Math.Round((aporte2 / totalAporte) * 100, 2);
            double porcentajeAporte3 = Math.Round((aporte3 / totalAporte) * 100, 2);


            Console.WriteLine($"El aporte de los socios es dela siguiente forma forma");
            Console.WriteLine($"Socio 1 aporto el {aporte1} que representa el {porcentajeAporte1}%");
            Console.WriteLine($"Socio 2 aporto el {aporte2} que representa el {porcentajeAporte2}%");
            Console.WriteLine($"Socio 3 aporto el {aporte3} que representa el {porcentajeAporte3}%");


            Console.ReadLine();

        }
    }
}
