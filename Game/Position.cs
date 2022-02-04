using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    internal class Position
    {
        public int positionX { get; set; }
        public int positionY { get; set; }
        public Position(int _positionX, int _positionY)
        {
            this.positionX = _positionX;
            this.positionY = _positionY;
        }
        public void Update() {
            //TODO
        }
    }
}
