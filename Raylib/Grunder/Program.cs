using System.Runtime.CompilerServices;
using System.Collections;
using System.ComponentModel;
using System;
using Raylib_cs;

namespace Grunder
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hej Raylib!");

      Raylib.InitWindow(800, 600, "Ett raylib fönster");

      Raylib.SetTargetFPS(60);

      Color Goldenrod = new Color(218, 165, 32, 170);

      while (!Raylib.WindowShouldClose())
      {
        Raylib.BeginDrawing();

        Raylib.ClearBackground(Color.DARKBLUE);

        Raylib.DrawRectangle(100, 100, 200, 100, Color.RED);
        Raylib.DrawRectangle(200, 200, 200, 100, Color.GREEN);

        Raylib.DrawCircle(400, 300, 100, Goldenrod);

        Raylib.DrawText("Det här är en cirkel", 100, 500, 50, Color.RED);

        Raylib.EndDrawing();



      }
    }
  }
}
