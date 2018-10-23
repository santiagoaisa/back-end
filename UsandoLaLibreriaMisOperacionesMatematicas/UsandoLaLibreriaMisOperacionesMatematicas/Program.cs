using System;
using MisOperacionesMatematicas;


namespace UsandoLaLibreriaMisOperacionesMatematicas
{
    class Program
    {
        static void Main(string[] args)
        {
            Profesor profesor = new Profesor();

            String menuPrincipal = "******** MENÚ PRINCIPAL ********\n";
            menuPrincipal  =menuPrincipal+ "Ingrese dos números y seleccione la operacion Matemática que desee realizar\n";

            menuPrincipal = menuPrincipal + "1 - Sumar\n";
            menuPrincipal = menuPrincipal + "2 - Restar\n";
            menuPrincipal = menuPrincipal + "3 - Multiplicar\n";
            menuPrincipal = menuPrincipal + "4 - División\n";
            menuPrincipal = menuPrincipal + "5 - Resto\n";
            menuPrincipal = menuPrincipal + "6 - Potencia\n";
            menuPrincipal = menuPrincipal + "7 - Raíz\n";
            menuPrincipal = menuPrincipal + "8 - Es Número Primo\n";

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

            switch (operacion)
            {
                case 1:
                    operacionRealizada = "Sumar";
                    resultado = profesor.sumar(numero1, numero2);
                    break;
                case 2:
                    operacionRealizada = "Restar";
                    resultado = profesor.restar(numero1, numero2);
                    break;
                case 3:
                    operacionRealizada = "Multiplicar";
                    resultado = profesor.multiplicar(numero1, numero2);
                    break;
                case 4:
                    operacionRealizada = "Dividir";
                    resultado = profesor.dividir(numero1, numero2);
                    break;
                case 5:
                    operacionRealizada = "El Resto";
                    resultado = profesor.resto(numero1, numero2);
                    break;
                case 6:
                    operacionRealizada = "La Potencia";
                    resultado = profesor.potencia(numero1, numero2);
                    break;
                case 7:
                    operacionRealizada = "La Raíz";
                    resultado = profesor.raiz(numero1, numero2);
                    break;
                case 8:
                    operacionRealizada = "Es Número Primo ";
                    if (profesor.esPrimo(numero1)) {
                        operacionRealizada = operacionRealizada + ": Si Es primo";
                    }else{
                        operacionRealizada = operacionRealizada + ": No Es primo";
                    }
                    
                    break;
            }

            Console.WriteLine("\n");
            Console.WriteLine( $"El Resultado de {operacionRealizada}  {numero1} y {numero2} es {resultado} ");
            Console.ReadLine();
        }
    }
}
