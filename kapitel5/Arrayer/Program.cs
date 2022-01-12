using System;

namespace Arrayer
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine("Använda Array!");

      string[] öar = new string[3];


      öar[0] = "Syros";
      öar[1] = "Naxos";
      öar[2] = "Kreta";

      öar[0] = "Amorgos";

      Console.WriteLine(öar[0]);
      Console.WriteLine($"Två andra öar är {öar[1]} och {öar[2]}");

    }
  }
}
