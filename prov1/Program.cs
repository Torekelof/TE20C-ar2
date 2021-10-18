using System;

namespace GuessANBR
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      //Namn
      Console.WriteLine("Hej vad heter du? ");
      string namn = Console.ReadLine();
      //Bruttolön
      Console.Write($"Ange din brutto lön i kr {namn}: ");
      string bruttolön = Console.ReadLine();
      
      Console.WriteLine($"ange din skattesats i %  ");
      string  skattesats = Console.ReadLine();
      
      int skattesats = *(100- skattesats / 100);
      Console.WriteLine($"{namn}, din nättolön blir {bruttolön} {skattesats}");
      
      
      



        }
    }
}
