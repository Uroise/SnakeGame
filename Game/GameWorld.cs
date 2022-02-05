using System.Collections.Generic;

namespace SnakeGame
{
    public class GameWorld
    {
        // En lista som ska innehålla alla objekt i spelet
        public List<GameObject> gameObjects = new List<GameObject>();

        // Variabler för hur stor spelvärlden är 
        public int width;
        public int height;
        // Variabel för antal poäng
        public int Score;

        // En Konstruktor för GameWorld med Bredd och Höjd

        public GameWorld(int Width, int Height)
        {
            width = Width;
            height = Height;

        }

        // Update metoden för GameWorld som loppar igenom gameObjects listan och sedan anropar Update(); för varje objekt.
        public void Update()
        {
            foreach (GameObject obj in gameObjects)
            {
                obj.Update();
            }

        }
    }
}