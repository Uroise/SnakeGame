using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
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
