using System;

namespace ConsoleApp13
{
    class Program
    {
        /*
         14.	El dueño de una tienda compra un artículo a un precio determinado. 
         Obtener el precio en que lo debe vender para obtener una ganancia del 30%.
         */
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese el costo de su articulo:");
            double costoCompra = Double.Parse(Console.ReadLine());

            double porcentajeGanancia = 30;

            double ganancia = Math.Round(costoCompra * (porcentajeGanancia / 100),2);

            Console.WriteLine($"El precio de su venta es  {costoCompra+ganancia}");

            Console.ReadLine();
        }
    }
}
