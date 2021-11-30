using System;

namespace TP_frågor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Slumpa fram en fråga");


            string[] korten =
            {"Vem vann fotbolls-EM 1984",                //0
            "När uppfördes Verdi",                          //1
            "Vem skrev Frankenstien",                          //2
            "Vad är 5+5",                                         //3
            "När startades andra världskriget",                      //4
            "Vem är president i USA just nu"                            //5
            };

            Random tärning = new Random();
            int slumptal = tärning.Next(0, 6);



            Console.WriteLine($"Tärningen slog {slumptal}");

            Console.WriteLine($"Frågan: {korten[slumptal]}");

    }
}
}
