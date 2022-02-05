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
                int default_x = 25;
                int default_y = 10;
                const int frameRate = 5;
                GameWorld world = new GameWorld(50,20);
                ConsoleRenderer renderer = new ConsoleRenderer(world);
                Snake player = new Snake(default_x,default_y);
                Position position = new Position(default_x, default_y);

                // TODO Skapa spelare och andra objekt etc. genom korrekta anrop till vår GameWorld-instans
                // ...

                // Huvudloopen
                bool running = true;
                string direction = "RIGHT"; // player börjar röra sig till höger.
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
                        direction = "UP"; //Ändrar direction till "UP".
                        break;

                        case ConsoleKey.A:
                        case ConsoleKey.LeftArrow:
                        direction = "LEFT";
                        break;

                        case ConsoleKey.S:
                        case ConsoleKey.DownArrow:
                        direction = "DOWN";
                        break;

                        case ConsoleKey.D:
                        case ConsoleKey.RightArrow:
                        direction = "RIGHT";
                        break;
                            // ...
                    }

                    // Uppdatera världen och rendera om
                    //world.Update();  //vi har ingenting att uppdatera just nu
                    renderer.Render();
                    renderer.Score(0);
                    renderer.Time("00:00");// la till Time , den visar '00:00', just nu den räknar inte, uppdateras inom kort.
                
                    // Mät hur lång tid det tog
                    double frameTime = Math.Ceiling((1000.0 / frameRate) - (DateTime.Now - before).TotalMilliseconds);
                    if (frameTime > 0)
                {
                    // detta kommer skrivas om snart till funcion istället
                    // här Ritar Vi Player och bestämmer direction. 
                    if (direction == "RIGHT")
                    {
                        if (default_x == world.width - 1) // ifall snake träffar väggen den börjar om från andra sidan.
                        {
                            default_x = 1;
                            player.drawSnake(default_x, default_y); // Ritar player.
                        }
                        else
                        {
                            player.drawSnake(default_x++, default_y);
                        }
                    } else if (direction=="LEFT") {

                        if (default_x == 1) 
                        {
                            default_x = world.width-1;
                            player.drawSnake(default_x, default_y);
                        }
                        else
                        {
                            player.drawSnake(default_x--, default_y);
                        }
                    } else if (direction=="UP")
                    {
                        if (default_y == 1) 
                        {
                            default_y = world.height-1;
                            player.drawSnake(default_x, default_y);
                        }
                        else
                        {
                            player.drawSnake(default_x, default_y--);
                        }
                    } else if (direction=="DOWN") {

                        if (default_y == world.height ) 
                        {
                            default_y = 2;
                            player.drawSnake(default_x, default_y);
                        }
                        else
                        {
                            player.drawSnake(default_x, default_y++);
                        }
                    }
                        // Vänta rätt antal millisekunder innan loopens nästa varv
                        Thread.Sleep((int)frameTime);
                    }
                }
               
            }
        }
   }
