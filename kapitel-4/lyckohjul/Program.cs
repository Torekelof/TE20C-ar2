using System;

namespace lyckohjul
{
  class Program
  {
    static void Main(string[] args)
    {


      //Skapa ett program som ska fungera som ett lyckohjul
      Console.WriteLine("Lyckohjul!");

      Random generator = new Random();




      //Användaren får 3 försök
      for (var i = 0; i < 3; i++)
      {
        // När användaren kör programmet får hen välja ett tal från 1 till 10 som hen tror att lyckohjulet kommer att stanna på
        Console.WriteLine("välj ett tal mellan 1-10");
        int gissning = int.Parse(Console.ReadLine());


        //Slumpa därefter fram ett tal från 1 till 10 och säg till användaren vilket tal det blev
        int tal = generator.Next(1, 11);
        Console.WriteLine($"{tal}");

        //Berätta också för användaren om hen vann eller förlorade
        if (tal == gissning)
        {
          Console.WriteLine("Du vann");
        }
        else
        {
          Console.WriteLine("Du förlora");
        }
      }





    }
  }
}
