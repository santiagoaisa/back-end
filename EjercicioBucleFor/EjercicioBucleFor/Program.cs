using System;

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
            //ejercicio11();
            //ejercicio12();
            //ejercicio13();
            //ejercicio14();
            //ejercicio15();
            //ejercicio16();
            //ejercicio17();
            //ejercicio18();
            //ejercicio19();
            //ejercicio20();
            //ejercicio21();
            // ejercicio22();
            ejercicio23();
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
            double rango1 = 0;
            double rango2 = 0;
            double rango3 = 0;


            for (int n = 1; n <= muestra; n++)
            {
                Console.Write($"Ingrese la edad del {canimal} " + n + "\n");
                edad = Int32.Parse(Console.ReadLine());
               

                if (edad >=0 && edad <= 1)
                {
                    rango1 = rango1 +1;
                }else if (edad >= 2 && edad <= 2)
                {
                    rango2 = rango2 +1;
                }
                else if (edad >= 3)
                {
                    rango3= rango3 +1;
                }
                
                   

            }

            Console.Write("-----------------------\n");

           

            Console.Write($"Rango 0 - 1   años { Math.Round((rango1/muestra)*100,2)}% \n");
            Console.Write($"Rango 2 - 2   años {Math.Round((rango2 / muestra) * 100,2)}% \n");
            Console.Write($"Rango 3 - más años {Math.Round((rango3 / muestra) * 100,2)}% \n");

            Console.ReadLine();

        }


        private static void ejercicio12()
        {
            /*
            12.	Mostrar un listado con los números de 1 al 100.
             * * * */
            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Números del 1 al 100 ****\n");
            
            int numero = 0;

           while (numero < 100)
            {
                numero+=1;
              Console.WriteLine($"Número {numero}\n");
               
            }

            Console.ReadLine();
        }

        private static void ejercicio13()
        {
            /*
            13.	Mostrar los números pares de 2 al 200.
             * * * */
            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Números pares del 2 al 200 ****\n");

            int numero = 0;

            while (numero < 200)
            {
                numero += 1;

                if (numero % 2==0)
                {
                    Console.WriteLine($"Número par {numero}\n");
                }

                

            }

            Console.ReadLine();
        }


        private static void ejercicio14()
        {
            /*
            14.	Mostrar los números pares de 2 hasta un número N (que es leído por la computadora)
             * * * */
            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Números pares del 2 a N ****\n");

            Console.Write("Ingrese el número N para determinar cuales son pares\n");
            int final = 0;
            try
            {
                final = Int32.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.Write("\n");
                Console.Write("Debio Ingresar un Numero\n");
                Console.ReadLine();
                return;
            }

           

            int numero = 0;
            while (numero < final)
            {
                numero += 1;

                if (numero % 2 == 0)
                {
                    Console.WriteLine($"Número par {numero}\n");
                }



            }

            Console.ReadLine();
        }

        private static void ejercicio15()
        {
            /*
         15.	Mostrar la sumatoria de los números del 1 al 100.
             * * * * */
            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Mostrar la sumatoria de números del 1 al 100 ****\n");

            int numero = 0;
            int sumatoria = 0;

            while (numero < 100)
            {
                numero += 1;
                sumatoria += numero;

            }

            Console.WriteLine($"La sumatoria del 1 al 100 es {sumatoria} \n");
            Console.ReadLine();

        }

        private static void ejercicio16()
        {
            /*
         16.	Mostrar dos listados uno con los números impares de 1 a 999 y otro con los pares de 2 a 1000.
             * * * * */
            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Mostrar dos listados de pares e impares del 1 al 1000 ****\n");

            int numero = 0;

            String cadena = "";

            String cabecera = "Par   Impar";

            while (numero < 1000)
            {
                numero += 1;

                if (numero % 2 == 0)
                {
                    cadena = cadena + " " + numero + "\n";
                }
                else
                {
                    cadena = cadena + " " + numero + "";
                }



            }

            Console.WriteLine(cabecera);
            Console.WriteLine(cadena);

            Console.ReadLine();

        }


        private static void ejercicio17()
        {
            /*
        17.	Mostrar un listado con los números del 1 al 100, con su respectivo cuadrado al lado. Cada pareja en una línea.
             * * * * * */
            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Mostrar un listados del 1 al 100 con su cuadrado al costado ****\n");

            int numero = 0;

            String cabecera = "Numero  Cuadrado";
            String cadena = "";
            
            while (numero < 100)
            {
                numero += 1;

                    cadena = cadena + $" {numero}     " + $"    {Math.Pow(numero,2)} " + "\n";
               
            }

            Console.WriteLine(cabecera);
            Console.WriteLine(cadena);

            Console.ReadLine();

        }

        private static void ejercicio18()
        {
            /*
      18.	Mostrar la tabla de multiplicar de 2 números cualquiera N, que sea leído por la computadora.
             * * * * * * */
            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Mostrar la tabla de multiplicar de dos numeros ****\n");

            Console.Write("Ingrese el numero 1 \n");
            int numero1 = 0;
            try
            {
                numero1 = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Write("\n");
                Console.Write("Debio Ingresar un Numero\n");
                Console.ReadLine();
                return;
            }

            Console.Write("Ingrese el numero 2 \n");
            int numero2 = 0;
            try
            {
                numero2 = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Write("\n");
                Console.Write("Debio Ingresar un Numero\n");
                Console.ReadLine();
                return;
            }



         
            String cabecera = "Numero  TABLA DEL "+numero2;
            String cadena = "";

            int i = 0;
            while (i <= numero2 )
            {
                
                cadena = cadena + $" {numero1} X {i} = {numero1*i}\n";
                i++;
            }

            Console.WriteLine(cabecera);
            Console.WriteLine(cadena);

            Console.ReadLine();

        }


        private static void ejercicio19()
        {
            /*
     19.	Mostrar un listado con los números consecutivos de M a N, siendo M y N dos valores que son leídos por la computadora, tales que M < N.
             * * * * * * * */
            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Mostrar un listado con los números consecutivos M a N , tales que M < N. ****\n");

            Console.Write("Ingrese el numero 1 \n");
            int numero1 = 0;
            try
            {
                numero1 = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Write("\n");
                Console.Write("Debio Ingresar un Numero\n");
                Console.ReadLine();
                return;
            }

            Console.Write("Ingrese el numero 2 \n");
            int numero2 = 0;
            try
            {
                numero2 = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Write("\n");
                Console.Write("Debio Ingresar un Numero\n");
                Console.ReadLine();
                return;
            }

            if (numero1 > numero2)
            {
                Console.Write("\n");
                Console.Write("El número1 debe ser mayor ál número2\n");
                Console.ReadLine();
                return;
            }
          
            String cadena = "";
            Console.WriteLine("\n");

            while (numero1 <= numero2)
            {

                cadena = cadena + $"{numero1}\n";
                numero1++;
            }

           
            Console.WriteLine(cadena);

            Console.ReadLine();

        }

        private static void ejercicio20()
        {
            /*
     20.	Imprimir un listado que contenga en cada línea: Número par del 2 al 200; múltiplos de 3 del 3 al 300; múltiplos de 4 del 4 al 400.
             * * * * * * * * */
            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Imprimir en cada linea ****\n");
           
            


            int numero = 0;
           
            String cadena = "";
            while (numero <= 200)
            {
                if (numero%2==0)
                {
                    cadena = cadena + numero + "  ";
                }                
                numero++;
            }
            ////
            Console.WriteLine("**** Número par del 2 al 200 ****\n");
            Console.WriteLine($"{cadena}\n");
            numero = 3;
            cadena = "";
            while (numero <= 300)
            {
                if (numero % 3 == 0)
                {
                    cadena = cadena + numero + "  ";
                }
                numero++;
            }

            Console.WriteLine("**** Múltiplos de 3 del 3 al 300 ****\n");           
            Console.WriteLine($"{cadena}\n");
            ////
            numero = 4;
            cadena = "";
            while (numero <= 400)
            {
                if (numero % 4 == 0)
                {
                    cadena = cadena + numero + "  ";
                }
                numero++;
            }

            Console.WriteLine("**** Múltiplos de 4 del 4 al 400 ****\n");
            Console.WriteLine($"{cadena}\n");

            Console.ReadLine();

        }


        private static void ejercicio21()
        {
            /*
    21.	Resolver la función f (x)= 3x + 2x – 5 para valores de x de 0 a 10, incrementándose de 1 en 1.
             * * * * * * * * * */
            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Resolver la función f (x)= 3x + 2x – 5 para valores de x de 0 a 10 ****\n");




            int numero = 0;

            String cadena = "";
            while (numero <= 10)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine($" f({numero}) = {(3*numero)+(2*numero)-5}\n");
                }
                numero++;
            }
           

            Console.ReadLine();

        }


        private static void ejercicio22()
        {
            /*
    22.	Resolver la función y = 3x + 15 – 2(2x) + 3, PARA x que toma valores de 1 al 40, de 2 en 2.
             * * * * * * * * * * */
            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Resolver la función y = 3x + 15 – 2(2x) + 3, PARA x que toma valores de 1 al 40, de 2 en 2 ****\n");




            int numero = 1;

            String cadena = "";
            while (numero <= 40)
            {
                
                    Console.WriteLine($" f({numero}) = {(3 * numero) + 15 - 2*(2 *numero) + 3}\n");
               
                numero+=2;
            }
            Console.ReadLine();
        }

        private static void ejercicio23()
        {
            /*
  23.	Resolver la función z= (4/3x – 2X) / (x + 3) para valores de x de –10 hasta N en incrementos de 0.5. N es leído por el computador y se debe evitar la división por cero.
             * * * * * * * * * * * */
            Console.WriteLine("**** MENU PRINCIPAL ****\n");
            Console.WriteLine("**** Resolver la función z= (4/3x – 2X) / (x + 3) para valores de x de –10 hasta N en incrementos de 0.5. ****\n");
            Console.Write("Ingrese el numero N \n");
            int hasta = 0;
            try
            {
                hasta = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Write("\n");
                Console.Write("Debio Ingresar un Numero\n");
                Console.ReadLine();
                return;
            }
            
            double numero = -10;

            String cadena = "";
            while (numero <= hasta)
            {
                Console.WriteLine($" f({numero}) = {Math.Round((4/(3*numero) - (2*numero))/  (numero + 3),2) }\n");

                numero += 0.5;
            }


            Console.ReadLine();

        }


    }
    }