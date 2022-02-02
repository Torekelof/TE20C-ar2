using System;
using Raylib_cs;

namespace fallandesnö
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialisering
            //--------------------------------------------------------------------------------------
            const int fönsterB = 800;
            const int fönsterH = 600;

            Raylib.InitWindow(fönsterB, fönsterH, "Snöflingor");
            Raylib.SetTargetFPS(60);

            //skapa en snöflinga
            Random generator = new Random();

            // array [] för många snöflingor
            Rectangle[] flingor = new Rectangle[100];

            //loopa igenom arrayen och fylll med snöflingor
            for (int i = 0; i < flingor.Length; i++)
            {
                flingor[i] = new Rectangle(0, 0, 10, 10);
                flingor[i].x = generator.Next(0, fönsterB);
                flingor[i].y = generator.Next(0, fönsterH) - fönsterH;
            }

            // array[] för snöflingans hastihet
            int[] hastigheter = new int[100];

            //loopa igenom arrayen och fyll i snöflingornas hastighet
            for (int i = 0; i < hastigheter.Length; i++)
            {
                hastigheter[i] = generator.Next(1, 6);
            }


            //--------------------------------------------------------------------------------------

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Updatering
                //----------------------------------------------------------------------------------

                for (int i = 0; i < flingor.Length; i++)
                {
                    flingor[i].y +=  hastigheter[i];
                    if (flingor[i].y > fönsterH)
                    {
                        flingor[i].y = 0;
                    }
                }


                //----------------------------------------------------------------------------------

                // Rita
                //----------------------------------------------------------------------------------
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.DARKBLUE);

                for (int i = 0; i < flingor.Length; i++)
                {
                    Raylib.DrawRectangleRec(flingor[i], Color.WHITE);
                }



                Raylib.EndDrawing();
                //----------------------------------------------------------------------------------
            }
        }
    }
}