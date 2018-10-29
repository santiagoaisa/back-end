using System;

namespace ConsoleApp10
{
    class Program
    {
        /*
         11. Calcular el nuevo salario de un obrero si obtuvo un 
         incremento del 25% sobre su salario anterior.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario mensual:");
            double salario = Double.Parse(Console.ReadLine());

            double porcentajeIncremento = 25;
            double incrementoSueldo = salario * (porcentajeIncremento / 100);
            Console.WriteLine($"De acuerdo a su salario mensual su incremento es {incrementoSueldo}");
            Console.ReadLine();

        }
    }
}
