using System;
using System.Collections.Generic;
using System.Linq;

namespace SnakeGame
{
    public class GameWorld
    {
        Random rand = new Random();
        // En lista som ska innehålla alla objekt i spelet
        public List<GameObject> gameObjects = new List<GameObject>();

        // Variabler för hur stor spelvärlden är 
        public int width;
        public int height;
        // Variabel för antal poäng
        public int Score;

        // En Konstruktor för GameWorld med Bredd och Höjd

        public GameWorld(int _width, int _height)
        {
            width = _width;
            height = _height;

        }

        // Update metoden för GameWorld som loppar igenom gameObjects listan och sedan anropar Update(); för varje objekt.
        public void Update()
        {
            foreach (GameObject obj in gameObjects)
            {
                obj.Update();
            }

            foreach (GameObject gameObject in gameObjects)
            {
                // Ifall obnjectet är av typen Food
                if (gameObject is Food food)
                {
                    // Hämta spelar instansen med hjälp av Linq (Kommer bara funka ifall det finns 1 och enbart 1 instans av Player pga .Single)
                    Player player = (Player)gameObjects.Single(p => p is Player);

                    // Jämnför positionerna som tidigare
                    if (food.Position.X == player.Position.X && food.Position.Y == player.Position.Y)
                    {
                        Console.SetCursorPosition(food.Position.X, food.Position.Y);
                        Console.Write(' ');
                        food.Position.X = rand.Next(3, 48);
                        food.Position.Y = rand.Next(3, 18);
                        Score++;
                        Console.Title = "Score: " + Score;
                    }
                }
            }

        }
    }
}