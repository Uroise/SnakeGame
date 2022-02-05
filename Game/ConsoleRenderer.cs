using System;

namespace SnakeGame
{
    internal class ConsoleRenderer
    {

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
                if (obj.Position.X >= world.width - 1) // ifall snake träffar väggen den börjar om från andra sidan.
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

                else if (obj.Position.Y >= world.height - 1) // ifall snake träffar väggen den börjar om från andra sidan.
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

        }

        public void RenderBlank()
        {
            foreach (GameObject obj in world.gameObjects)
            {
                Console.SetCursorPosition(obj.Position.X, obj.Position.Y);
                Console.Write(obj.Appearance);

            }
        }

        public void Render()
        {
            Console.CursorVisible = false;
            // TODO Rendera spelvärlden (och poängräkningen)
            Console.Clear();
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
                Console.Write("|");
            }
            for (int i = 1; i <= (world.height - 1); i++)
            {
                Console.SetCursorPosition((world.width - 1), i);
                Console.Write("|");
            }


            // Använd Console.SetCursorPosition(int x, int y) and Console.Write(char)

        }
    }
}