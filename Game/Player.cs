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
        public enum Direction
        {
            Up, Down, Left, Right
        }
    }
}
