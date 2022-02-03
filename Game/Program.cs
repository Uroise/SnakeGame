using System;
using System.Threading;

namespace SnakeGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /// <summary>
            /// Checks Console to see if a keyboard key has been pressed, if so returns it, otherwise NoName.
            /// </summary>
            static ConsoleKey ReadKeyIfExists() => Console.KeyAvailable ? Console.ReadKey(intercept: true).Key : ConsoleKey.NoName;

            // Initialisera spelet
            const int frameRate = 5;
            GameWorld world = new GameWorld();
            ConsoleRenderer renderer = new ConsoleRenderer(world);
            

            // TODO Skapa spelare och andra objekt etc. genom korrekta anrop till vår GameWorld-instans
            // ...

            // Huvudloopen
            bool running = true;
            while (running)
            {
                // Kom ihåg vad klockan var i början
                DateTime before = DateTime.Now;

                // Hantera knapptryckningar från användaren
                ConsoleKey key = ReadKeyIfExists();
                switch (key)
                {
                    case ConsoleKey.Q:
                        running = false;
                        break;
                    // TODO Lägg till logik för andra knapptryckningar
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:
                        break;
                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        break;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        break;
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        break;
                        // ...
                }

                // Uppdatera världen och rendera om
                world.Update();
                renderer.Render();


                // Mät hur lång tid det tog
                double frameTime = Math.Ceiling((1000.0 / frameRate) - (DateTime.Now - before).TotalMilliseconds);
                if (frameTime > 0)
                {
                    // Vänta rätt antal millisekunder innan loopens nästa varv
                    Thread.Sleep((int)frameTime);
                }
            }
        }
    }
}