using System;

namespace SnakeGame
{
    internal class Food : GameObject
    {
        Random rand = new Random();  
        
        // Food Konstruktor med x,y som parameterar som håller reda på vilken position food är på.
        public Food(Position position, char appearance) : base(position, appearance)
        {

        }
        // Update metoden för Food.
        public void Update()
        {
            Console.SetCursorPosition(Position.X,Position.Y);
            Console.Write(' ');
            Position.X = rand.Next(3, 48);
            Position.Y = rand.Next(3, 18);
            Console.Beep();
        }
    }
}
