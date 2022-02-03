using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    internal abstract class GameObject
    {
        // Skapade en publikt variabel från klassen Position
        public Position Position;
        // Skapade en char variabel för Snake'ts utseende.
        public char Appearance;

        // TODO
        
        public void Update()
        {
            
        }
    }
}