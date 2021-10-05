using System;

namespace GuessANBR
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine("Spel - gissa ett tal mellan 1 och 100.");
      //slumpa fram ett tal
      Random tärning = new Random();
      int slumptal = tärning.Next(1, 101);

      //Upprepa
      int räknare = 0;
      while (true)
      {
          //räkna upp antal gissningar
        räknare++;

        //Fråga användaren om en gissning
        Console.Write("Gissa ett tal (1-100): ");
        int gissning = int.Parse(Console.ReadLine());

        //är gissningen rätt?
        if (gissning == slumptal)
        {
            Console.WriteLine($"Bra gissat du gjorde det på {räknare} försök");
            break;
        }
        
         //Jämför med ett slumtal
        if (gissning < slumptal)
        {
          Console.WriteLine("För lågt!");
        }
        else
        {
          Console.WriteLine("För högt!");
        }
      }
    }
  }
}
