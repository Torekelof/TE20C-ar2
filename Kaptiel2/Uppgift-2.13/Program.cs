using System.Text;
using System;

namespace Uppgift_2._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in 3 löner");
            //Ange 3 löner
            int lön1 = int.Parse(Console.ReadLine());
            int lön2 = int.Parse(Console.ReadLine());
             int lön3 = int.Parse(Console.ReadLine());
            //Medelvärdet
            float Medelvärdet = (lön1 + lön2 + lön3) / 3;
            //Resultatet
            Console.WriteLine($"Medelvärdet är {Medelvärdet}");
         }
    }
}
