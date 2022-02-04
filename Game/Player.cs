using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    //Skrivit en snake klass som skriver ut ormen på en specifik position
    public class Snake
    {
        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo { };
        char key = 'w';

        public int x { get; set; }
        public int y { get; set; }
        public Snake()
        {
            x = 20;
            y = 20;
        }

        public void drawSnake()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("#");
        }

        public void Input()
        {
            if (Console.KeyAvailable)
            {
                key = keyInfo.KeyChar;
            }
        }

    }
    internal abstract class Player : GameObject
    {

        // Player konstruktor med parameterar x,y för position med base från GameObject variabeln Position.s
        public Player(int x, int y)
        {
            base.Position.positionX = x;
            base.Position.positionY = y;
        }
        public enum Direction
        {
            Up, Down, Left, Right
        }
    }
}
