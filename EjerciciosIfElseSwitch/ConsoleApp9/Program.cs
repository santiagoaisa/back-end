using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            

            String menuPrincipal = "******** MENÚ PRINCIPAL ********\n";
            menuPrincipal = menuPrincipal + "Ingrese dos números y seleccione la operacion Matemática que desee realizar\n";

            menuPrincipal = menuPrincipal + "1 - Sumar\n";
            menuPrincipal = menuPrincipal + "2 - Restar\n";
            menuPrincipal = menuPrincipal + "3 - Multiplicar\n";
            menuPrincipal = menuPrincipal + "4 - División\n";           
            menuPrincipal = menuPrincipal + "5 - Potencia\n";
          

            Console.WriteLine(menuPrincipal);
            Console.WriteLine("\n");
            Console.WriteLine("Ingrese el número 1 :");
            double numero1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Ingrese el número 2 :");
            double numero2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Ingrese la Operación a realizar de acuerdo al Menú Principal:");
            int operacion = int.Parse(Console.ReadLine());

            String operacionRealizada = "";
            double resultado = 0;

            bool esValido = true;
            Console.WriteLine("\n");
            switch (operacion)
            {
                case 1:
                    operacionRealizada = "Sumar";
                    resultado = numero1+ numero2;
                    break;
                case 2:
                    operacionRealizada = "Restar";
                    resultado = numero1 - numero2;
                    break;
                case 3:
                    operacionRealizada = "Multiplicar";
                    resultado = numero1 * numero2;
                    break;
                case 4:
                    operacionRealizada = "Dividir";
                    resultado = numero1 / numero2;
                    break;
               
                case 5:
                    operacionRealizada = "La Potencia";
                    resultado = Math.Pow(numero1, numero2);
                    break;
                default:

                    resultado = 0;

                    Console.WriteLine("No existe la operación seleccionada\n");
                    esValido = false;
                    break;
            }

            if (esValido)
            {
                Console.WriteLine($"El Resultado de {operacionRealizada}  {numero1} y {numero2} es {resultado} ");
                
            }
            Console.ReadLine();
        }
    }
}
