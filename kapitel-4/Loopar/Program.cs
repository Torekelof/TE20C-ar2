using System;

namespace Loopar
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 6; i++)
            {
            Console.WriteLine(i);
            }
            for (int i = 9; i > 0; i--)
            {
            Console.WriteLine(i);
            }
            int summa = 0;
            for (int i = 1; i < 11; i++)
            {
            summa +- i;
            }
            Console.WriteLine($"Summan är {summa}");
            string namn = "Mohamme";

            Console.WriteLine(namn[0]);
            Console.WriteLine(namn[1]);
            Console.WriteLine(namn[3]);
            Console.WriteLine(namn[4]);

            for (int i = 7; i > -1; i--)
            {
            Console.WriteLine(namn[i]);
            }
        }
    }
}
