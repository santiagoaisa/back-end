using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Venta del dia ----");
            string[,] listaProducto = CrearProductos();
            string[,] listaVenta = CrearVenta();



            double importeTotal = 0;
            int cantidad = 0;
            double importe = 0;
            double precio = 0;
            String producto = "";

            Console.WriteLine("Producto    Cantidad  Total  ");
            for (int p = 0; p < listaProducto.GetLength(0); p++)
            {
                cantidad = 0;
                importe =0;
                producto = listaProducto[p, 0];
                precio = Double.Parse(listaProducto[p, 1]);
                
                for (int v = 0; v < listaVenta.GetLength(0); v++)
                {

                    if (listaVenta[v, 1] == producto)
                    {
                        cantidad = cantidad=Int32.Parse(listaVenta[v, 2]);
                    }
                       
                }

                importe = importe + (cantidad*precio);
                importeTotal = importeTotal + importe;
                Console.WriteLine($"{producto}       {cantidad}        {importe}");
            }

            Console.WriteLine($"------------------------");
            Console.WriteLine($"Venta total del dia es   {importeTotal}   ");
            Console.ReadLine();
        }

        static double PrecioProducto(String codigoProducto, string[,] listaProducto)
        {
            double precio=0;
            for (int i = 0; i < listaProducto.Length; i++)
            {
                if (listaProducto[i,0]==codigoProducto)
                {
                    precio = Double.Parse(listaProducto[i,1]);
                 }               
            }

            return precio;
        }

        static string[,] CrearProductos()
        {
            //string[,] listaProducto = new string[5, 2];

            string[,] listaProducto =new string[3, 2] {
                                                     {"PRODUCTO1", "10.00" },
                                                     {"PRODUCTO2","05.00" },
                                                     {"PRODUCTO3","08.00" }
                                                    };
            return listaProducto;
        }

        static string[,] CrearVenta()
        {
            //string[,] listaProducto = new string[5, 2];

            string[,] listaVenta = new string[5, 3] {
                                                      {"MAÑANA","PRODUCTO1","2"},
                                                      {"MAÑANA","PRODUCTO2","2"},
                                                      {"TARDE","PRODUCTO2","3" },
                                                      {"NOCHE","PRODUCTO3","2" },
                                                      {"NOCHE","PRODUCTO3","1" }
                                                    };
            return listaVenta;
        }

    }


    
}
