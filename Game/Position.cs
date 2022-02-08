namespace SnakeGame
{
    /// <summary>
    /// Position klassen som vi använder för objektens position.
    /// </summary>
    public class Position
    {
  
        public int X { get; set; }
        public int Y { get; set; }
        /// <summary>
        /// Position Konstruktorn som ger x och y positionerna
        /// </summary>
        /// <param name="positionX">X positionen</param>
        /// <param name="positionY">Y position</param>
        public Position(int positionX, int positionY)
        {
            X = positionX;
            Y = positionY;
        }
    }
}
