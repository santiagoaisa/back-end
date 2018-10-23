﻿using System;

namespace EjercicioBucleFor
{
    class Program
    {

        static void Main(string[] args)
        {
            //ejercicio1();
            // ejercicio2();
            //ejercicio3();
            //ejercicio4();
            // ejercicio5();
            //  ejercicio6();
            //ejercicio7();
            //ejercicio8();
            //ejercicio9();
            // ejercicio10();
            ejercicio11();
        }


        private static void ejercicio1()
        {
            /*
            1.	 Calcular el promedio de un alumno que tiene 7 calificaciones en la materia de Algoritmos Avanzados y estructura de Datos.
            */
            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Ingrese 7 notas del curso Back-End para calcular su promedio ****\n");


            int notas = 0;
            int cantidadNotas = 7;

            for (int n = 1; n <= cantidadNotas; n++)
            {
                Console.Write("Ingrese la Nota " + n + "\n");
                notas = notas + Int32.Parse(Console.ReadLine());
            }

            Console.Write($"El promedio de las 7 notas es {notas / cantidadNotas} ");
            Console.ReadLine();
        }

        private static void ejercicio2()
        {
            /*
            2.	Leer 10 números y obtener su cubo y su cuarta.
            */
            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Ingrese 10 números para obtener su cubo y cuarta****\n");


            int cantidadNumeros = 10;

            int numero = 0;
            String cadena = "Numero  Cubo   Cuarta\n";
            cadena = cadena + "---------------------\n";
            for (int n = 1; n <= cantidadNumeros; n++)
            {
                Console.Write("Ingrese el numero " + n + "\n");
                numero = Int32.Parse(Console.ReadLine());
                cadena = cadena + "  " + numero + "    " + Math.Pow(numero, 3) + "   " + Math.Pow(numero, 4) + "\n";
            }

            Console.Write(cadena);
            Console.ReadLine();
        }

        private static void ejercicio3()
        {
            /*
           3.	Leer 10 números e imprimir solamente los números positivos (Posible solución “Concatenar positivos e imprimirlos”).
           */
            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Ingrese 10 números para determinar cual es positivo o negativo****\n");

            int cantidadNumeros = 10;
            int numero = 0;
            String cadena = " ";

            for (int n = 1; n <= cantidadNumeros; n++)
            {
                Console.Write("Ingrese el numero " + n + "\n");
                numero = Int32.Parse(Console.ReadLine());

                if (numero >= 0)
                {
                    cadena = cadena + $" {numero} \n";
                }


            }

            Console.Write("Números Positivos\n");
            Console.Write(cadena);
            Console.ReadLine();

        }


        private static void ejercicio4()
        {
            /*
           4.	Leer 20 números e imprimir cuantos son positivos, cuantos negativos y cuantos neutros.
           */
            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Ingrese 20 números para determinar cuantos son negativos,positivos y neutros****\n");

            int cantidadNumeros = 20;

            int positivo = 0;
            int negativo = 0;
            int neutro = 0;


            int numero = 0;
            for (int n = 1; n <= cantidadNumeros; n++)
            {
                Console.Write("Ingrese el numero " + n + "\n");
                numero = Int32.Parse(Console.ReadLine());

                if (numero < 0)
                {
                    negativo++;
                    continue;
                }

                if (numero==0){
                    neutro++;
                    continue;
                }

                if (numero > 0)
                {
                    positivo++;
                    continue;
                }


            }

            Console.Write("\n");
            Console.Write($"Negativo {negativo}\n");
            Console.Write($"Neutro {neutro}\n");
            Console.Write($"Positivo {positivo}\n");

            Console.ReadLine();

        }


        private static void ejercicio5()
        {
            /*
           5.	Leer 15 números negativos y convertirlos a positivos e imprimir dichos números, de no ser negativo el sistema me volverá a pedir el número.
           */
            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Ingrese 15 números negativos****\n");

            int cantidadNumeros = 15;

            int numero = 0;
            int n = 1;
            do
            {
                Console.Write("Ingrese el numero negativo " + n + "\n");
                numero = Int32.Parse(Console.ReadLine());

                while (numero>0)
                {
                    Console.Write($"Ingrese un numero {n} que sea NEGATIVO \n");
                    numero = Int32.Parse(Console.ReadLine());
                }

                Console.Write($"El numero POSITIVO para el numero {n}  es {Math.Abs(numero)} \n");
                Console.Write("\n");
                n++;

            } while (n<cantidadNumeros);


           

            Console.ReadLine();

        }

        private static void ejercicio6()
        {
            /*
           6.	Suponga que se tiene un conjunto de calificaciones de un grupo de 10 alumnos. Realizar un algoritmo para calcular la calificación media y la calificación más baja de todo el grupo.
           */
            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Ingrese 10 notas para determinar la nota mayor y media****\n");

            int cantidadNumeros = 10;
            int nota = 0;
            int mayor=0;
            int medio = 0;
            int menor = 0;

            for (int n = 1; n <= cantidadNumeros; n++)
            {
                Console.Write("Ingrese la nota del alumno " + n + "\n");
                nota = Int32.Parse(Console.ReadLine());

                if (nota>mayor)
                {
                    medio = mayor;
                    mayor = nota;                    
                }

                if (menor==0)
                {
                    menor = nota;
                }

                if (nota<menor)
                {
                    medio = menor;
                    menor = nota;
                }




            }

            Console.Write("\n");
            Console.Write($"Nota Menor {menor}\n");
            Console.Write($"Nota Media {medio}\n");

            Console.Write("\n");

            Console.ReadLine();

        }


        private static void ejercicio7()
        {
            /*
          7.	Calcular e imprimir la tabla de multiplicar de un número cualquiera. Imprimir el multiplicando, el multiplicador y el producto.
              4 * 1 = 4
              4 * 2 = 8
              */
            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Ingrese 1 numero para calcular su tabla de multiplicar ****\n");

            int cantidadNumeros = 12;
            
            Console.Write("Ingrese el numero \n");
            int numero  = Int32.Parse(Console.ReadLine());

            String cadena = "";
            for (int n = 1; n <= cantidadNumeros; n++)
            {
                cadena = cadena + $"{numero} * {n}  = {numero * n} \n";
            }

            Console.Write("\n");
           
            Console.Write(cadena);

            Console.ReadLine();

        }

        private static void ejercicio8()
        {
            /*
          8.	Simular el comportamiento de un reloj digital, imprimiendo la hora, minutos y segundos de un día desde las 0:00:00 horas hasta las 23:59:59 horas.
              */
            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Reloj Digital ****\n");

            for (int h=00;h<=23;h++)
            {

                for (int m=00;m<=59;m++)
                {
                    for (int s=00; s<=59;s++)
                    {
                        Console.WriteLine(h + ":" + m + ":" + s);
                    }

                }

            }


            Console.WriteLine("**** RELOJ TERMINADO ****\n");
            Console.ReadLine();

        }

        private static void ejercicio9()
        {
            /*
         9.	Una persona debe realizar un muestreo con 20 personas para determinar el promedio de peso de los niños, jóvenes, adultos y viejos que existen en su zona habitacional. Se determinan las categorías con base en la siguiente tabla: 
            CATEGORIA EDAD 
            Niños 0 - 12 
            Jóvenes 13 - 29 
            Adultos 30 - 59 
            Anciano 60 en adelante
             * */
            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Ingrese la edad de 20 personas ****\n");

            

            int cantidadPersona = 20;
            int niños = 0;
            int jovenes = 0;
            int adultos = 0;
            int anciano = 0;

            int edad = 0;
            for (int n = 1; n <= cantidadPersona; n++)
            {
                Console.Write("Ingrese edad de la persona " + n + "\n");
                edad = Int32.Parse(Console.ReadLine());

                if (edad>=0 && edad<=12)
                {
                    niños ++;
                }else if (edad >= 13 && edad <= 29)
                {
                    jovenes++;
                }
                else if (edad >= 30 && edad <= 59)
                {
                    adultos++;
                }
                else if (edad >60)
                {
                    anciano++;
                }

            }

            Console.Write($"Cantidad de Niños {niños} \n");
            Console.Write($"Cantidad de Jovenes {jovenes} \n");
            Console.Write($"Cantidad de Adultos {adultos} \n");
            Console.Write($"Cantidad de Anciano {anciano} \n");
            Console.ReadLine();

        }

        private static void ejercicio10()
        {
            /*
        10.	Al cerrar un expendio de naranjas, 15 clientes que aún no han pagado recibirán un 15% de descuento si compran más de 10 kilos. Determinar cuánto pagara cada cliente y cuanto percibirá la tienda por esas compras.
             * */
            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Ingrese la cantidad de KILOS de naranjas de los 15 clientes ****\n");
            Console.WriteLine("Precio por Kilo es de S/ 2.00\n");

            int cantidadPersona = 15;
            int precioKilo = 2;
            double descuento =1 - 0.15;
            double totalCliente = 0;
            double totalGeneral = 0;

            int kilos = 0;
            
            for (int n = 1; n <= cantidadPersona; n++)
            {
                Console.Write("Ingrese cantidad de kilos de naranja comprados para el cliente " + n + "\n");
                kilos = Int32.Parse(Console.ReadLine());
                totalCliente = kilos * precioKilo;

                if (kilos>10)
                {
                    totalCliente = kilos * (precioKilo*(descuento));
                }

                totalGeneral = totalGeneral + totalCliente;

                Console.Write($"Pago del cliente {n} es {totalCliente}\n");

            }

            Console.Write("-----------------------\n");
            Console.Write($"La tienda percibira {totalGeneral} \n");
           
            Console.ReadLine();

        }

        private static void ejercicio11()
        {
            /*
        11.	Un Zoólogo pretende determinar el porcentaje de animales que hay en las siguientes tres categorías de edades: de 0 a 1 año, de más de 1 año y menos de 3 y de 3 o más años. El zoológico todavía no está seguro del animal que va a estudiar. Si se decide por elefantes solo tomara una muestra de 20 de ellos; si se decide por las jirafas, tomara 15 muestras, y si son chimpancés tomara 40.
             * * */
            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Seleccione el tipo de Animal para determinar la cantidad de muestras ****\n");
            Console.WriteLine("1. Elefantes\n");
            Console.WriteLine("2. Jirafas\n");
            Console.WriteLine("3. Chimpancés\n");
            Console.WriteLine("Ingrese el tipo de animal de acuerdo al menú\n");

            String canimal = "";
            int opcion  = Int32.Parse(Console.ReadLine());
            int muestra = 0;

            if (opcion==1)
            {
                muestra = 20;
                canimal = "ELEFANTE";
            }else if (opcion == 2)
            {
                muestra = 15;
                canimal = "JIRAFA";
            }
            else if (opcion == 3)
            {
                muestra = 40;
                canimal = "CHIMPANCES";
            }
            else
            {
                Console.WriteLine("Opción Invalida\n");
                Console.ReadLine();
                return;
            }

            Console.WriteLine($"Ingrese {muestra} muestras de {canimal}\n");

            

            int edad = 0;
            double r_0_1 = 0;
            double r_2_2 = 0;
            double r_3__ = 0;


            for (int n = 1; n <= muestra; n++)
            {
                Console.Write($"Ingrese la edad del {canimal} " + n + "\n");
                edad = Int32.Parse(Console.ReadLine());
               

                if (edad >=0 && edad <= 1)
                {
                    r_0_1++;
                }else if (edad >= 2 && edad <= 2)
                {
                    r_2_2++;
                }
                else if (edad >= 2 && edad <= 2)
                {
                    r_3__++;
                }
                
                   

            }

            Console.Write("-----------------------\n");
            Console.Write($"Rango 0 - 1   años {(r_0_1/muestra)*100} \n");
            Console.Write($"Rango 2 - 2   años {(r_2_2 / muestra) * 100} \n");
            Console.Write($"Rango 3 - más años {(r_3__ / muestra) * 100} \n");

            Console.ReadLine();

        }


    }
}