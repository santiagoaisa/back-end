using System;

namespace ConsoleApp2
{
    class Program
    {
        /*
         *3.	Una tienda ofrece un descuento del 15% sobre el total de la compra 
         * y un cliente desea saber cuánto deberá pagar finalmente por su compra.
         */
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese el monto de su compra:");
            double montoCompra = Double.Parse(Console.ReadLine());

            double porcentajeDescuento = 15;

            double descuento = Math.Round(montoCompra * (porcentajeDescuento / 100), 2);

            Console.WriteLine($"Su compra es por {montoCompra} , sin embargo ud tiene un descuento del 15% que equivale a {descuento}");
            Console.WriteLine($"Su total a pagar es de {montoCompra-descuento}");
            Console.ReadLine();

        }

        

    }
}
