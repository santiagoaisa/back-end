using System;

namespace ConsoleApp4
{
    class Program
    {
        /*
          Crear una aplicación que pida 3 números y los muestre en pantalla de menor a mayor.

         */

        static void Main(string[] args)
        {

            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Ingrese un 3 numeros para ORDENARLOS en forma ascendente ****\n");

            Console.WriteLine("Numero 1:\n");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            Console.WriteLine("Numero 2:\n");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            Console.WriteLine("Numero 3:\n");
            int numero3 = int.Parse(Console.ReadLine());

            int menor=0, medio=0, mayor=0;

            if (numero1 > numero2)
            {
                mayor = numero1;
                menor = numero2;
            }
            else
            {
                mayor = numero2;
                menor = numero1;
            }


            if (numero3>=mayor){
                medio = mayor;
                mayor = numero3;
            }else if(numero3<=menor){             
                medio = menor;
                menor = numero3;
            }else
            {
                medio = numero3;
            }


            Console.WriteLine("Los numeros ordenados en forma ASCENDENTE es\n");
            Console.WriteLine(menor);
            Console.WriteLine(medio);
            Console.WriteLine(mayor);

            Console.ReadLine();


        }
    }
}
