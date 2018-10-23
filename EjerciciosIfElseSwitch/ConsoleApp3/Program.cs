using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Crear una aplicación que pida un número del 1 al 12 y diga el nombre del mes correspondiente.

             */

            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Ingrese un numero del 1 al 12 para determinar el MES del AÑO ****\n");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            String mes = "";

            switch (numero)
            {
                case 1:
                    mes = "ENERO";
                    break;
                case 2:
                    mes = "FEBRERO";
                    break;
                case 3:
                    mes = "MARZO";
                    break;
                case 4:
                    mes = "ABRIL";
                    break;
                case 5:
                    mes = "MAYO";
                    break;
                case 6:
                    mes = "JUNIO";
                    break;
                case 7:
                    mes = "JULIO";
                    break;
                case 8:
                    mes = "AGOSTO";
                    break;
                case 9:
                    mes = "SETIEMBRE";
                    break;
                case 10:
                    mes = "OCTUBRE";
                    break;
                case 11:
                    mes = "NOVIEMBRE";
                    break;
                case 12:
                    mes = "DICIEMRE";
                    break;

                default:
                    mes = "No existe";
                    break;



            }//fin del switch

            Console.Write($"El MES es {mes}");
            Console.Read();

        }
    }
}
