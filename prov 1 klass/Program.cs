using Internal;
using System;

namespace prov_1_klass
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Uträkning av nettolön");

      //fråga efter namn
      Console.WriteLine("Vad heter du? ");
      string namn = Console.ReadLine();

      //fråga efter bruttolön
      Console.Write("Ange din bruttolön i kronor");
      int bruttolön = int.Parse(Console.ReadLine());

      //Kolla att vilkoren är uppfilda
      if (bruttolön >= 10000 && bruttolön <= 45000)
      {
        Console.Write("Ange din skattesats i kronor");
        int skattesats = int.Parse(Console.ReadLine());

        if (skattesats >= 10 && skattesats <= 45000)
        {
          int nettolön = bruttolön * (100 - skattesats) / 100;
          Console.WriteLine($"{namn}, din lön efter skatt {nettolön}");
        }
        else
        {
          Console.WriteLine("Skattesats måste vara mellan 10 och 45");

        }

      }
      else
      {
        Console.WriteLine("bruttolön måste vara mellan 10000 och 45000");
      }

    }
  }
}
