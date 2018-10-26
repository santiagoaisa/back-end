using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 5, 65, 20, 12, 16 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"valor usando FOR = {array[i]}");
            }

            foreach (int item in array)
            {
                Console.WriteLine($"valor usando FOREACH = {item}");
            }

            Console.ReadLine();

        }
    }
}
