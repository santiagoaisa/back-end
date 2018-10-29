using System;

namespace ConsoleApp8
{
    class Program
    {
        /*
         9.	La presión, el volumen y la temperatura de una masa de aire se relacionan por la fórmula: 
         Masa = (presión * volumen)/(0.37 * (temperatura + 460))
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un valor para la presión:");
            double presion = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un valor para el volumen:");
            double volumen = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un valor para la temperatura:");
            double temperatura = Double.Parse(Console.ReadLine());

            double masa = (presion * volumen) / (0.37 * (temperatura + 460));

            Console.WriteLine($"La masa es: {temperatura} ");
            Console.ReadLine();
        }
    }
}
