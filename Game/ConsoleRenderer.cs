using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    internal class ConsoleRenderer
    {
        int height = 20;
        int width = 40;
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
            for (int i = 1; i <= (width + 2) ; i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write("-");
            }
            for (int i = 1; i <= (width + 2); i++)
            {
                Console.SetCursorPosition(i, (height + 2));
                Console.Write("-");
            }
            for (int i = 1; i <= (height + 2); i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("|");
            }
            for (int i = 1; i <= (height + 2); i++)
            {
                Console.SetCursorPosition((width + 2), i);
                Console.Write("|");
            }

            // Använd Console.SetCursorPosition(int x, int y) and Console.Write(char)
        }
    }
}