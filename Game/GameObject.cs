using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    internal abstract class GameObject
    {
        int position;
        char appearance = '#';
        // TODO

        public abstract void Update();
    }
}