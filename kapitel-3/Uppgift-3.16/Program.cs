using System.Net.Mail;
using System;

namespace Uppgift_3._16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur lång är din låt i minuter? ");
            int minuter = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Hur lång är din låt i sekunder? ");
            int sekunder = int.Parse(Console.ReadLine());

            int total = minuter * 60 + sekunder;

            if (total >= 165 &&  total <= 260 )
            {
                Console.WriteLine("din låt får spelas");
            }
            else
            {
                Console.WriteLine("din låt får inte spelas");
            }
        }
    }
}
