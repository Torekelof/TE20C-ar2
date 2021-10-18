using System;

namespace menyprogram_med_while
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enkelt menyprogram");

      //skapa en slumpgenerator

      Random tärning = new Random();

      while (true)
      {
        //slumpa fram ett tal
        int slumptal = tärning.Next(1, 4);

        Console.WriteLine("Välj ett av följande alternativ");
        Console.WriteLine("Väljer du sten? (1)");
        Console.WriteLine("Väljer du sax? (2)");
        Console.WriteLine("Väljer du påse? (3)");
        Console.WriteLine("Vill du avsulta? (4) ");
        string val = Console.ReadLine();

        if (valString == "4")
        {
          break;
        }

        //Omvandla till en int eftersom slumptal är en int
        int val = int.Parse(valString);

        //är det rätt svar 
        if (val == slmuptal)
        {
          Console.WriteLine("du vinner! ");
        }
        else
        {
          Console.WriteLine("du förlorar skit ner dig! ");
        }

      }
    }
  }
}
