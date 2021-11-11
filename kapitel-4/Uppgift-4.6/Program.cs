using System;

namespace Uppgift_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string meddelande = "Jag äter hamburgare! ";

            Console.WriteLine(meddelande);

            Console.WriteLine(meddelande [19]);

             char bokstav = 'z';

            for (int i = 19; i >= 0; i--)
            {
             Console.WriteLine($"index {i} {meddelande [i]}");
            }
        }
    }
}
