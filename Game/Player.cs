using System;
namespace SnakeGame
{
    /// <summary>
    /// Player klassen som ärver från GameObject. Här anropas en instans till när vi ska skapa en spelare.
    /// </summary>
    public class Player : GameObject
    {

        /// <summary>
        /// Player konstruktor med parameterar char, x,y för position med base från GameObject variabeln Position
        /// </summary>
        /// <param name="position"> Positionen med X och Y</param>
        /// <param name="SnakeHead">Objektets utseende</param>
        public Player(Position position, char SnakeHead) : base(position, SnakeHead)
        {

        }
        /// <summary>
        /// En enum för Directions.
        /// </summary>
        public enum Direction
        {
            Up, Down, Left, Right
        }



        /// <summary>
        /// En update metod för Player där den flyttar sig i spelarens riktning.
        /// </summary>
        /// <param name="Type"> Type är för enum som ska veta vilken riktning</param>
        public void Update(Direction Type)
        {
            switch (Type)
            {
                // Om typen är Up. D.v.s inmatningen från användaren är W eller uppåt pilen så körs detta.
                case Direction.Up:
                    Console.SetCursorPosition(Position.X, Position.Y); // den gamla positionen.
                    Console.Write(' '); // Vi gör den gamla positionen till en blank.
                    Position.Y--; // sedan förflyttar vi ormen ett steg uppåt där den renderas på nytt.

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
