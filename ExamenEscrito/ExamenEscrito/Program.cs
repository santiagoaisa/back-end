using System;

namespace ExamenEscrito
{
    class Program
    {
        /*
         1.	Suponga que un individuo desea invertir su capital en un banco y 
         desea saber cuánto dinero ganará después de un mes si el banco paga a razón de 2% mensual.
         */

        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese su Capital:");
            double capital = Double.Parse(Console.ReadLine());

            double meses = 1;
            double interes = 2;
            double interesCalculado =  Math.Round(capital * (interes / 100) * meses, 2);


            Console.WriteLine($"Por su capital de {capital} UD. ganará un Interes de {interesCalculado}");
            Console.ReadLine();
        }

        
    }
}
