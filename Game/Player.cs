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
        public Snake(int x, int y)
        {
            drawSnake(x, y);
        }

        public void drawSnake(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            //Console.Write("#");
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
