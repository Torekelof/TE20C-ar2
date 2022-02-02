using System;
using Raylib_cs;

namespace Example
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

            // TODO: Infoga variabler och objekt här
            //game state variabler
            int poäng = 0;
            int liv = 3;
            float tid = 0;
            int hastighet = 3;

            Random generator = new Random();
            Rectangle mynt1 = new Rectangle(400, 0, 50, 50);
            Rectangle mynt2 = new Rectangle(400, 0, 50, 50);
            Rectangle spelare = new Rectangle(100, fönsterH - 50, 100, 10);
            Rectangle monster = new Rectangle(100, fönsterH - 50, 100, 10);
            //--------------------------------------------------------------------------------------

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Updatering
                //----------------------------------------------------------------------------------
                //räkna upp tiden
                tid += Raylib.GetFrameTime();

                //Hastigheter och nedre gräns
                mynt1.y += hastighet;
                if (mynt1.y > fönsterH)
                {
                    mynt1.y = -100;
                    mynt1.x = generator.Next(0, fönsterB);
                }
                mynt2.y += hastighet;
                if (mynt2.y > fönsterH)
                {
                    mynt2.y = -100;
                    mynt2.x = generator.Next(0, fönsterB);
                }
                  monster.y += hastighet;
                if (monster.y > fönsterH)
                {
                    monster.y = -100;
                    monster.x = generator.Next(0, fönsterB);
                }

                //Lyssna på tangenter
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                {
                    if (spelare.x > 0)
                    {
                        spelare.x -= 5;
                    }

                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                {
                    if (spelare.x < fönsterB - 100)
                    {
                        spelare.x += 5;

                    }
                }

                //  om spelare träffar ett mynt----------------------------------------------------------------------------------
                if (Raylib.CheckCollisionRecs(spelare, mynt1))
                {
                    mynt1.y = 0;
                    mynt1.x = generator.Next(0, fönsterB);
                    poäng += 5;
                }
                if (Raylib.CheckCollisionRecs(spelare, mynt2))
                {
                    mynt2.y = 0;
                    mynt2.x = generator.Next(0, fönsterB);
                    poäng += 5;
                }
                if (Raylib.CheckCollisionRecs(spelare, monster))
                {
                    monster.y = 0;
                    monster.x = generator.Next(0, fönsterB);
                    liv--;
                }




                // Rita
                //----------------------------------------------------------------------------------
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.DARKBLUE);


                Raylib.DrawRectangleRec(mynt1, Color.GOLD);
                Raylib.DrawRectangleRec(mynt2, Color.GOLD);
                Raylib.DrawRectangleRec(spelare, Color.WHITE);
                Raylib.DrawRectangleRec(monster, Color.RED);
                Raylib.DrawText($"poäng: {poäng} liv:{liv} tid: {(int)tid}", 10, 10, 20, Color.YELLOW);

                Raylib.EndDrawing();
                //----------------------------------------------------------------------------------
            }
        }
    }
}