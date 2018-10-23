using System;

namespace ConsoleApp7
{
    class Program
    {
        /*
         Crear una aplicación que pida 10 números y diga cuál es el mayor y cual el menor.
         */

        static void Main(string[] args)
        {
            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Ingrese un 10 numeros para determinar el mayor y el menor ****\n");

            Console.WriteLine("Numero 1:\n");
            int numero1 = int.Parse(Console.ReadLine());

           
            Console.WriteLine("Numero 2:\n");
            int numero2 = int.Parse(Console.ReadLine());

           
            Console.WriteLine("Numero 3:\n");
            int numero3 = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Numero 4:\n");
            int numero4 = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Numero 5:\n");
            int numero5 = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Numero 6:\n");
            int numero6 = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Numero 7:\n");
            int numero7 = int.Parse(Console.ReadLine());

           
            Console.WriteLine("Numero 8:\n");
            int numero8 = int.Parse(Console.ReadLine());

           
            Console.WriteLine("Numero 9:\n");
            int numero9 = int.Parse(Console.ReadLine());

          
            Console.WriteLine("Numero 10:\n");
            int numero10 = int.Parse(Console.ReadLine());

            int menor = 0, mayor = 0;

            if (numero1 > numero2)
            {
                mayor = numero1;                
            }else{
                mayor = numero2;
                menor = numero1;
            }
            
            if (numero3 >= mayor)
            {               
                mayor = numero3;
            } else if (numero3 <= menor)
            {               
                menor = numero3;
            }

            if (numero4 >= mayor)
            {
                mayor = numero4;
            }
            else if (numero4 <= menor)
            {
                menor = numero4;
            }

            if (numero5 >= mayor)
            {
                mayor = numero5;
            }
            else if (numero5 <= menor)
            {
                menor = numero5;
            }

            if (numero6 >= mayor)
            {
                mayor = numero6;
            }
            else if (numero6 <= menor)
            {
                menor = numero6;
            }

            if (numero7 >= mayor)
            {
                mayor = numero7;
            }
            else if (numero7 <= menor)
            {
                menor = numero7;
            }

            if (numero8 >= mayor)
            {
                mayor = numero8;
            }
            else if (numero8 <= menor)
            {
                menor = numero8;
            }

            if (numero9 >= mayor)
            {
                mayor = numero9;
            }
            else if (numero9 <= menor)
            {
                menor = numero9;
            }

            if (numero10 >= mayor)
            {
                mayor = numero10;
            }
            else if (numero10 <= menor)
            {
                menor = numero10;
            }

            Console.WriteLine($"El numero MENOR ES es {menor}\n");
            Console.WriteLine($"El numero MAYOR ES es {mayor}\n");


            Console.ReadLine();
        }
    }
}
