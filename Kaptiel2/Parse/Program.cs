using System;

namespace Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hhur gammal är du? ");
            string ålder = Console.ReadLine();
            Console.WriteLine($"Du är {ålder} gammal");
            // Konvertera från string till heltal
            int ålderTal = int.Parse(ålder);
            Console.WriteLine($"Du har {20 - ålderTal} år kvar tills du får gå på systembolaget");
            Console.Write("Hur mycket väger du? ");
            //Använder en Float för vikt använd "," istället för "." i terminalen för att det är ett svenskt tangentbord
            float vikt = float.Parse(Console.ReadLine());
            Console.WriteLine($"Din vikt blir {vikt * 2.2} Lbs ");
        }
    }
}
