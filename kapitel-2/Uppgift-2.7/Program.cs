using System;

namespace Uppgift_2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad är ditt förnamn? ");
            string förnamn = Console.ReadLine();
            
            Console.WriteLine("Vad är ditt efternamn? ");
            string efternamn = Console.ReadLine();
            
            Console.WriteLine($"Hej {förnamn} {efternamn}");

            Console.WriteLine($"I England skriver man {efternamn} {förnamn}");

            Console.WriteLine("Är du från Stockholm? y/n");
            string svar = Console.ReadLine();
            
            if (svar == "y")
            {
                Console.WriteLine("Bra");
            }
        }
    }
}
