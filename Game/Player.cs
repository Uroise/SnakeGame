using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    internal abstract class Player : GameObject
    {
        public Player()
        {
        }
        public enum direction
        {
            Up, Down, Left, Right
        }
    }
}
