using System;
using Raylib_cs;
namespace Ny_mapp__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hej!");
            // Starta grafikmotorn
            Raylib.InitWindow(800, 600, "Mitt Raylib fönster");

            // Bestäm skärmuppdatering
            Raylib.SetTargetFPS(60);
            
            //Skapa en spelare
            Rectangle spelare = new Rectangle(100, 100, 50, 50);
            Rectangle fieande = new Rectangle(100, 100, 50, 50);

            Texture2D agent = Raylib.LoadTexture(@"./Bilder/agent.png");
            Texture2D arch = Raylib.LoadTexture(@"./Bilder/archaeologist.png");

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {

                /* rita ut grafiken */
                // Börja rita
                Raylib.BeginDrawing();

                // Töm ritytan
                Raylib.ClearBackground(Color.GRAY);

                // Rita ut spelaren
                Raylib.DrawTexture(agent, (int)spelare.x,(int) spelare.y, Color.WHITE);
                Raylib.DrawTexture(arch, (int)fieande.x,(int) fieande.y,Color.WHITE);

                // Ritat ut på fönstret
                Raylib.EndDrawing();
                /* Interaktion med användaren */

                //lyssna på tangentbordet

                if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
                {
                spelare.x += 5;
                }
                 if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
                {
                spelare.x += -5;
                }
                 if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
                {
                spelare.y += 5;                
                }
                  if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
                {
                spelare.y -= 5;                
                }
                 if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                {
                fieande.x += 5;
                }
                 if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                {
                fieande.x += -5;
                }
                 if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                {
                fieande.y += 5;                
                }
                  if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                {
                fieande.y -= 5;                
                }
            }
        }
    }
}
