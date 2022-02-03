using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    internal abstract class Player : GameObject
    {
        public string name;
        public int X;
        public int Y;

        public Player(string  _name)
        {
            name = _name;
        }
        public enum Direction
        {
            Up, Down, Left, Right
        }
    }
}
