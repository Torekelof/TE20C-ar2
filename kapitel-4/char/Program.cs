using System;

namespace Char
{
    class Program
    {
        static void Main(string[] args)
        {
            string meddelande = "Hej på dig! ";

            Console.WriteLine(meddelande);

            Console.WriteLine(meddelande [0]);

            Console.WriteLine(meddelande [10]);

            char bokstav = 'z';

            for (int i = 0; i < 11; i++)
            {
             Console.WriteLine($"index {i} {meddelande [i]}");
            }
        }
    }
}
