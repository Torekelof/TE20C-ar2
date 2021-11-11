using System.Runtime.InteropServices;
using Internal;
using System;

namespace slumptal
{
  class Program
  {
    static void Main(string[] args)
    {
      
      Console.WriteLine("Slumptal!");

      Random generator = new Random();

      int slumptal = generator.Next(1, 11);

      int slumptal2 = generator.Next(1, 7);

      Console.WriteLine($"{slumptal} {slumptal2}");


    }
  }
}
