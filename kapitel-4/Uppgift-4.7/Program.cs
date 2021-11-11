using System;

namespace Uppgift_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriv din summa
            Console.WriteLine("Skriv din summa");
            string summaText = Console.ReadLine();
            
            for (int i = 0; i < summaText.Length; i++)
            {
                char siffra = summaText[i];
                Console.WriteLine(siffra);

                int siffraTal = int.Parse(siffra.ToString());

                summaText += siffraTal; 
            }
        }
    }
}
