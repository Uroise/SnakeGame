using System;
namespace SnakeGame
{

    public class Player : GameObject
    {

        // Player konstruktor med parameterar char, x,y för position med base från GameObject variabeln Position
        public Player(Position position, char SnakeHead) : base(position, SnakeHead)
        {

        }

        public enum Direction
        {
            Up, Down, Left, Right
        }



        // En update metod för Player där den flyttar sig i spelarens riktning.
        public void Update(Direction Type)
        {
            switch (Type)
            {
                case Direction.Up:
                    Console.SetCursorPosition(Position.X, Position.Y);
                    Console.Write(' ');
                    Position.Y--;

                    break;
                case Direction.Down:
                    Console.SetCursorPosition(Position.X, Position.Y);
                    Console.Write(' ');
                    Position.Y++;
                    break;
                case Direction.Right:
                    Console.SetCursorPosition(Position.X, Position.Y);
                    Console.Write(' ');
                    Position.X++;
                    break;
                case Direction.Left:
                    Console.SetCursorPosition(Position.X, Position.Y);
                    Console.Write(' ');
                    Position.X--;
                    break;
            }


        }
    }
}
