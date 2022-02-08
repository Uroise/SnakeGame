using System;
using System.Threading;

namespace SnakeGame
{/// <summary>
/// Det är ett snakespel som ger användaren poäng när man åker över matbiten och hastigheten ökar när man får mer poäng.
/// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            /// <summary>
            /// Checks Console to see if a keyboard key has been pressed, if so returns it, otherwise NoName.
            /// </summary>
            static ConsoleKey ReadKeyIfExists() => Console.KeyAvailable ? Console.ReadKey(intercept: true).Key : ConsoleKey.NoName;


            // Initialisera spelet

            int frameRate = 5;
            GameWorld world = new GameWorld(50, 20);
            Console.Title = "Score: " + world.Score;
            Random rand = new Random();


            // skapar en renderar instansen.
            ConsoleRenderer renderer = new ConsoleRenderer(world);


            //Skapar spelare och andra objekt etc. genom korrekta anrop till vår GameWorld-instans
            Player Snake = new Player(new Position(5, 5), '■');
            world.gameObjects.Add(Snake);

            Food Food = new Food(new Position(rand.Next(3, 48), rand.Next(3, 18)), '■');
            world.gameObjects.Add(Food);




            // Deklararer variabeln Rundirection med strängen "Left" som kommer användas sen för att bestämma vilken riktning ormen ska röra sig mot först.
            var RunDirection = "Left";

            // Huvudloopen - En while loop som körs medans running är lika med true.
            bool running = true;
            while (running)
            {
                // Logik för ormens hastighet efter den har ätit upp mat.
                if (world.Score == 3)
                {
                    frameRate = 6;
                }
                if (world.Score == 5)
                {
                    frameRate = 8;
                }
                if (world.Score == 7)
                {
                    frameRate = 10;
                }
                if (world.Score == 10)
                {
                    frameRate = 12;
                }
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


                // Hantera knapptryckningar från användaren och logiken.
                ConsoleKey key = ReadKeyIfExists();
                switch (key)
                {
                    case ConsoleKey.Q:
                        running = false;
                        break;

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

                // Renderar väggarna sedan objekten och uppdatera världen.
                renderer.Render();
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
