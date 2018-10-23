using System;

namespace ConsoleApp10
{
    class Program
    {
        /*
         
        Crear una aplicación que calcule el aumento de sueldo que le corresponde al trabajador de una empresa que cobra 50.000 soles anuales, la aplicación debe poder realizar los siguientes cálculos:
	    a. Si lleva más de 10 años en la empresa se le aplica un aumento del 10%.
	    b. Si lleva menos de 10 años pero más que 5 se le aplica un aumento del 7%.
	    c. Si lleva menos de 5 años pero más que 3 se le aplica un aumento del 5%.
	    d. Si lleva menos de 3 años se le aplica un aumento del 3%.
         */
        static void Main(string[] args)
        {

            String menuPrincipal = "******** MENÚ PRINCIPAL ********\n";
          

            Console.WriteLine(menuPrincipal);
            Console.WriteLine("\n");
            Console.WriteLine("Ingrese el sueldo anual\n");
            double sueldoanual = Double.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Ingrese el numero de años en que labora en la empresa\n");
            double numeroano = Double.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            if (sueldoanual <= 0)
            {
                Console.WriteLine("El sueldo anual debe ser mayor que 0\n");
                Console.ReadLine();
                return;
            }


            if (numeroano<=0)
            {
                Console.WriteLine("El número de años debe ser mayor que 0\n");
                Console.ReadLine();
                return;
            }

            double porcentajeaumento = 0;
            
            if (numeroano >= 10)
            {
                porcentajeaumento = 0.10;
            }
            else if (numeroano >= 5 && numeroano <10) 
            {
                porcentajeaumento = 0.07;
            }
             else if (numeroano >= 3 && numeroano < 5)
            {
                porcentajeaumento = 0.05;
            }
            else
            {
                porcentajeaumento = 0.03;
            }

            Console.WriteLine($"El porcentaje de aumento es {porcentajeaumento*100}%\n");
            Console.WriteLine($"El Sueldo Anual con el aumento sera de {sueldoanual*(porcentajeaumento+1)}\n");
            Console.ReadLine();
        }
    }
}
