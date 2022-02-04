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
            //Console.Write("test");
            Console.Clear();

        }
        public void Time(string time)
        {
            Console.SetCursorPosition(35, (world.height));
            Console.Write("Time : {0}", time);
        }

        public void Score( int score)
        {
            Console.SetCursorPosition(5,(world.height));
            Console.Write("Score : {0}",score);
        }

        public void Render()
        {
            Console.CursorVisible = false;
            // TODO Rendera spelvärlden (och poängräkningen)
            Console.Clear();
            for (int i = 1; i <= (world.width - 1); i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write("_");
            }
            for (int i = 1; i <= (world.width - 1); i++)
            {
                Console.SetCursorPosition(i, (world.height - 1 ));
                Console.Write("_");
            }
            for (int i = 2; i <= (world.height - 1); i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("|");
            }
            for (int i = 2; i <= (world.height - 1); i++)
            {
                Console.SetCursorPosition((world.width - 1), i);
                Console.Write("|");
            }
            // Använd Console.SetCursorPosition(int x, int y) and Console.Write(char)
        }
    }
}