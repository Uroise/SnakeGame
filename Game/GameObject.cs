using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    internal abstract class GameObject
    {
        public int x { get; set; }
        public int y { get; set; }

        // TODO
        
        public abstract void Update();
    }
}