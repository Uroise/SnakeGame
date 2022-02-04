using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    internal class Food : GameObject
    {
        // Food Konstruktor med x,y som parameterar som håller reda på vilken position food är på.
        public Food(int x,int y)
        {
            base.Position.positionX = x;
            base.Position.positionY = y;   
        }
        // Update metoden för Food.
        public void Update()
        {

            return;
        }
    }
}
