﻿using System;

namespace Uppgift1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Detta är ett program gjort i C#.");
            Console.WriteLine("Programmet skriver ut text på flera rader.");
            Console.WriteLine("Detta är programmets sista utskrift.");

             // Ändra bakgrundsfärg till mörkröd            
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();

                        // Ändra textfärgen till vit
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Ett testmeddelande");


        }
    }
}
