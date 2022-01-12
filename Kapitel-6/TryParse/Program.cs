using System;

namespace TryParse
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("gissa ett tal!");

      //slumpgenerator

      Random generator = new Random();

      //slumpa fram ett tal mellan 1, 100

      int slumtal = generator.Next(1, 101);
      int slumtal2 = generator.Next(1, 11);




      int gissningTal = 0;
      bool korrekt = false;

      for (var i = 0; i < 3; i++)
      {
        while (korrekt != true)
        {
          Console.WriteLine("Mata in ett tal (1.100)");
          string gissning = Console.ReadLine();
          korrekt = int.TryParse(gissning, out gissningTal);

        }
        //var gissningen korrekt
        if (gissningTal == slumtal)
        {
          Console.WriteLine("Bra du gissade rätt");
        }
        else
        {
          Console.WriteLine("Tyvärr du gissade fel");
        }
      }




    }
  }
}
