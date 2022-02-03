using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    internal class ConsoleRenderer
    {
        
        private GameWorld world;

        public ConsoleRenderer(GameWorld gameWorld)
        {
            // TODO Konfigurera Console-fönstret enligt världens storlek
            world = gameWorld;
            Console.Clear();

        }

        public void Render()
        {
            Console.CursorVisible = false;
            // TODO Rendera spelvärlden (och poängräkningen)
            Console.Clear();
            for (int i = 1; i <= (world.width + 2); i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write("-");
            }
            for (int i = 1; i <= (world.width + 2); i++)
            {
                Console.SetCursorPosition(i, (world.height + 2));
                Console.Write("-");
            }
            for (int i = 1; i <= (world.height + 2); i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("|");
            }
            for (int i = 1; i <= (world.height + 2); i++)
            {
                Console.SetCursorPosition((world.width + 2), i);
                Console.Write("|");
            }
            // Använd Console.SetCursorPosition(int x, int y) and Console.Write(char)
        }
    }
}