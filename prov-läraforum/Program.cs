using System;

namespace prov_läraforum
{
  class Program
  {
    static void Main(string[] args)
    {

	  string beräkning = "";
      while (beräkning != "n")
      {
        Console.WriteLine("Ange din bruttolön i kr: ");
        int bruttolön = int.Parse(Console.ReadLine());

        if (bruttolön >= 0 && bruttolön <= 10000)
        {
          int nettolön = bruttolön * (100 - 8) / 100;
          Console.WriteLine($"din nettolön blir {nettolön} och marginalskatten 8% ");
        }

        if (bruttolön >= 10000 && bruttolön <= 145000)
        {
          int nettolön = bruttolön * (100 - 22) / 100;
          Console.WriteLine($"din nettolön blir {nettolön} och marginalskatten 22% ");
        }

        if (bruttolön >= 145000 && bruttolön <= 515000)
        {
          int nettolön = bruttolön * (100 - 33) / 100;
          Console.WriteLine($"din nettolön blir {nettolön} och marginalskatten 33% ");
        }

        if (bruttolön >= 515000)
        {
          int nettolön = bruttolön * (100 - 53) / 100;
          Console.WriteLine($"din nettolön blir {nettolön} och marginalskatten 53% ");
        }

        Console.WriteLine("Vill du göra en ny beräkning? (j/n)");
        beräkning = Console.ReadLine();
		
      }




    }
  }
}
