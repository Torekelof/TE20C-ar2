using System;

namespace Uppgift_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uppgift 5.1!");

            string[] städer = new string[3];
            städer[0] = "Malmö";
            städer[1] = "Stockholm";
            Console.WriteLine($"Skriv in namnet på en svenska stad förutom {städer[0]} och {städer[1]}");
            städer[2] = Console.ReadLine();

          

        }
    }
}
