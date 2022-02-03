using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    internal class GameWorld
    {
        // En lista som ska innehålla alla objekt i spelet
        List<GameObject> gameObjects = new List<GameObject>();
        // Variabler för hur stor spelvärlden är 
        public int width;
        public int height;
        // Variabel för antal poäng
        public int Score;

        // En Konstruktor för GameWorld med Bredd och Höjd
        public GameWorld(int Width,int Height)
        {
            width = Width;
            height = Height;

        }

        // Update metoden för GameWorld ...
        public void Update()
        {
            // TODO
        }
    }
}