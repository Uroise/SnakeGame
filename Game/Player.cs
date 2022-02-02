using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    internal abstract class Player : GameObject
    {
        ConsoleKeyInfo KeyInfo = new ConsoleKeyInfo();
        char apparance = '#';
        List<Position> playerPosition;

        public int positionX;
        public int positionY;

        public Player()
        {
            positionX = 20;
            positionY = 20;

            playerPosition = new List<Position>();
            playerPosition.Add(new Position(positionX, positionY));
        }
        public enum Direction
        {
            Up, Down, Left, Right
        }
    }
}
