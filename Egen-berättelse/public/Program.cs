using System;

namespace klassuppgift_bärettälse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Du är ensam i en djungel och det börjar bli mörkt. Vad gör du? Letar du efter hjälp eller bygger du ett skydd ");

            string val1 = Console.ReadLine().ToLower();
           
           if (val1 == "Letar efter hjälp")
           {
               Console.WriteLine("Du letade hela natten men till slut så hittade du en by mitt i skogen");
           }
           else
           {
               Console.WriteLine("Du byggde ett skydd vilket tog cirka 2 timmar och du vaknade nästa dag");
           } 
            
          Console.WriteLine("Du är väldigt hungrig och du hittate konstiga svampar. Vill du äta dem? ja/nej");

          string val2 = Console.ReadLine().ToLower();

          if (val2 == "nej")
          {
              Console.WriteLine("Du hade tur de svamparna var giftiga och du överlevde");
          }
          else
          {
              Console.WriteLine("Svamparna var giftiga och du dog. Game Over! Better luck next time");
          }
          
        }
    }
}


