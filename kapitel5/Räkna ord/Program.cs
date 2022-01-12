using System;

namespace Räkna_ord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Ange en mening");

            string mening = Console.ReadLine();
            
            string[] orden = mening.Split(' ');

            foreach (var ord in orden)
            {
                Console.WriteLine(ord);
            }

            Console.WriteLine($"Antal ord i en mening är {orden.Length}");


            string nyMening = string.Join('/', orden);

            Console.WriteLine(nyMening);
        }
    }
}
