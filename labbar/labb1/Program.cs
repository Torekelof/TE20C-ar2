using System;

namespace labb1
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine("Program som skriver ut ASCII");

      Console.Write("Ange ett ord: ");
      string ord = Console.ReadLine();

      Console.WriteLine("Ange en nyckel (1-9):");
      int nyckel = int.Parse(Console.ReadLine());
     
      string meddelandeKrypterad = "";


      for (int i = 0; i < ord.Length; i++)
      {
        char bokstav = ord[i];
        int kod = (int)bokstav;
        kod += nyckel;
        char bokstavKrypterad = (char)(kod);
        meddelandeKrypterad += bokstavKrypterad.ToString();
        Console.WriteLine($"Hej på dig blir {meddelandeKrypterad}");
      }
    }
  }
}
