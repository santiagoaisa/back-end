using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Crear una aplicación que pida un número del 1 al 7 y diga el día de la semana correspondiente en String.

             */

            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Ingrese un numero del 1 al 7 para determinar el dia de la semana ****\n");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            String dia = "";

            switch (numero)
            {
                case 1:
                    dia = "Lunes";
                    break;
                case 2:
                    dia = "Martes";
                    break;
                case 3:
                    dia = "Miercoles";
                    break;
                case 4:
                    dia = "Jueves";
                    break;
                case 5:
                    dia = "Viernes";
                    break;
                case 6:
                    dia = "Sabado";
                    break;
                case 7:
                    dia = "Domingo";
                    break;
                default:
                    dia = "No existe";
                    break;



            }//fin del switch

            Console.Write($"El dia de la semana es {dia}");
            Console.Read();

        }
    }
}
