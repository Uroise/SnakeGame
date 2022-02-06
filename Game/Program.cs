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
            GameWorld world = new GameWorld(50, 20);
            Console.Title = "Score: " + world.Score;
            Random rand = new Random();

            ConsoleRenderer renderer = new ConsoleRenderer(world);


            Player Snake = new Player(new Position(5, 5), '#');
            world.gameObjects.Add(Snake);

            Food Food = new Food(new Position(rand.Next(3, 48), rand.Next(3, 18)), '$');
            world.gameObjects.Add(Food);



            // TODO Skapa spelare och andra objekt etc. genom korrekta anrop till vår GameWorld-instans
            // ...

            // Huvudloopen
            bool running = true;
            // Vi renderar väggarna en gång.
            
            var RunDirection = "Left";
            while (running)
            {
                // Kom ihåg vad klockan var i början
                
                DateTime before = DateTime.Now;

                // Logik för kontroll av Snake position och för den ska kunna köra i en riktning
                if (RunDirection == "Up")
                    Snake.Update(Player.Direction.Up);
                if (RunDirection == "Down")
                    Snake.Update(Player.Direction.Down);
                if (RunDirection == "Left")
                    Snake.Update(Player.Direction.Left);
                if (RunDirection == "Right")
                    Snake.Update(Player.Direction.Right);


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
                        RunDirection = "Up";
                        break;

                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        RunDirection = "Left";
                        break;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        RunDirection = "Down";
                        break;

                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        RunDirection = "Right";
                        break;

                }

                // Uppdatera världen och rendera om
                renderer.Render();

                renderer.RenderBlank();

                renderer.RenderObjects();

                world.Update();
                





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
