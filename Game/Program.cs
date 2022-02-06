﻿using System;
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

            Random rand = new Random();

            ConsoleRenderer renderer = new ConsoleRenderer(world);


            Player Snake = new Player(new Position(5, 5), '#');
            world.gameObjects.Add(Snake);

            Food Food = new Food(new Position(rand.Next(2, 50), rand.Next(2, 20)), '$');
            world.gameObjects.Add(Food);



            // TODO Skapa spelare och andra objekt etc. genom korrekta anrop till vår GameWorld-instans
            // ...

            // Huvudloopen
            bool running = true;
            // Vi renderar väggarna en gång.
            

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
                        Snake.Update(Player.Direction.Up);
                        break;

                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        Snake.Update(Player.Direction.Left);
                        break;

                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        Snake.Update(Player.Direction.Down);
                        break;

                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        Snake.Update(Player.Direction.Right);
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
