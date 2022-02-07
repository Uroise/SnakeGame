using System;

namespace SnakeGame
{
    internal class ConsoleRenderer
    {
        Random rand = new Random();
        private GameWorld world;

        public ConsoleRenderer(GameWorld gameWorld)
        {
            // Satt Consolens storlek.
            Console.SetWindowSize(gameWorld.width, gameWorld.height);
            Console.SetBufferSize(gameWorld.width, gameWorld.height);
            world = gameWorld;
            Console.Clear();

        }
        public void RenderObjects()
        {

            foreach (GameObject obj in world.gameObjects)
            {
                if (obj is Player)
                {   
                    Console.ResetColor();
                    if (obj.Position.X > world.width - 2) // ifall snake träffar väggen den börjar om från andra sidan.
                    {
                        obj.Position.X = 2;
                        Console.SetCursorPosition(obj.Position.X, obj.Position.Y);
                    }
                    else if (obj.Position.X < 2) // ifall snake träffar väggen den börjar om från andra sidan.
                    {
                        obj.Position.X = world.width - 2;
                        Console.SetCursorPosition(obj.Position.X, obj.Position.Y);
                    }
                    else if (obj.Position.Y < 2) // ifall snake träffar väggen den börjar om från andra sidan.
                    {
                        obj.Position.Y = world.height - 1;
                        Console.SetCursorPosition(obj.Position.X, obj.Position.Y);
                    }

                    else if (obj.Position.Y > world.height - 2) // ifall snake träffar väggen den börjar om från andra sidan.
                    {
                        obj.Position.Y = 1;
                        Console.SetCursorPosition(obj.Position.X, obj.Position.Y);
                    }

                    else
                    {
                        Console.SetCursorPosition(obj.Position.X, obj.Position.Y);
                        Console.Write(obj.Appearance);

                    }

                }
                else
                {
                    int FoodColorRandomer = rand.Next(1, 3);
                    switch (FoodColorRandomer)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            break;
                        case 2:

                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;

                            break;

                    }
                    Console.SetCursorPosition(obj.Position.X, obj.Position.Y);
                    Console.Write(obj.Appearance);
                    Console.ResetColor();
                }



            }

        }

/*        public void RenderBlank()
        {

            foreach (GameObject obj in world.gameObjects)
            {
               
                if (obj.Position.X < 1)
                {
                    Console.SetCursorPosition(obj.Position.X, obj.Position.Y);
                    Console.Write(" ");
                }
                if (obj.Position.X > world.width)
                {
                    Console.SetCursorPosition(obj.Position.X - 3, obj.Position.Y);
                    Console.Write(" ");
                }
                if (obj.Position.Y < 1)
                {
                    Console.SetCursorPosition(obj.Position.X, obj.Position.Y + 1);
                    Console.Write(" ");
                }
                if (obj.Position.Y > world.height - 2)
                {
                    Console.SetCursorPosition(obj.Position.X, obj.Position.Y - 1);
                    Console.Write(" ");
                }

            }
        }*/

        public void Render()
        {
            Console.CursorVisible = false;

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;

            for (int i = 1; i <= (world.width - 1); i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write("■");
            }
            for (int i = 1; i <= (world.width - 1); i++)
            {
                Console.SetCursorPosition(i, (world.height - 1));
                Console.Write("■");
            }
            for (int i = 1; i <= (world.height - 1); i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("■");
            }
            for (int i = 1; i <= (world.height - 1); i++)
            {
                Console.SetCursorPosition((world.width - 1), i);
                Console.Write("■");
            }



        }
    }
}