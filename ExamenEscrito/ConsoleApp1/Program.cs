using System;

namespace ConsoleApp1
{
    class Program
    {
        /*
         2.	Un vendedor recibe un sueldo base más un 10% extra por comisión de sus ventas, 
         el vendedor desea saber cuánto dinero obtendrá por concepto de comisiones por las 
         tres ventas que realiza en el mes y el total que recibirá en el mes 
         tomando en cuenta su sueldo base y comisiones.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su Sueldo Base:");
            double sueldo = Double.Parse(Console.ReadLine());

            Console.WriteLine("Importe de Venta 1:");
            double montoVenta1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Importe de Venta 2:");
            double montoVenta2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Importe de Venta 3:");
            double montoVenta3 = Double.Parse(Console.ReadLine());

            double porcentajeComision = 10;

            double montoVenta = montoVenta1 + montoVenta2 + montoVenta3;
            double comision = Math.Round(montoVenta * (porcentajeComision / 100), 2);
         

            Console.WriteLine($"Por su sueldo base es de {sueldo} UD. logro una comision por sus ventas de {comision}");
            Console.WriteLine($"Su SUELDO TOTAL es de {sueldo+comision}");
            Console.ReadLine();
        }

        
    }
}
