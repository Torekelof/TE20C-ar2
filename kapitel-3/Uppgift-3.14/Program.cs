using System;

namespace Uppgift_3._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymmnasiet? j/n");
            string gymmnasiet = Console.ReadLine();
            
            Console.WriteLine("Hur gammal är du? ");
            int ålder = int.Parse(Console.ReadLine());
            
            if (gymnasiet == "j" && ålder < 22)
            {
            Console.WriteLine("Vi vill gärna anställa dig");
            }
            else
            {
            Console.WriteLine("Vi letar efter en annan personal just nu");
            }
            
        }
    }
}
