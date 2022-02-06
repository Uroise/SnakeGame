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
            
            foreach (GameObject player in gameObjects)
            {

                if (player is Player)
                {
                    foreach(GameObject food in gameObjects)
                    {
                        if (food is Food)
                        {
                            if (player.Position.X == food.Position.X && player.Position.Y == food.Position.Y)
                            {
                                Console.SetCursorPosition(food.Position.X, food.Position.Y);
                                Console.Write(' ');
                                food.Position.X = rand.Next(3, 50);
                                food.Position.Y = rand.Next(3, 20);
                             
                            }
                                

                        }
                    }
                }
                
            }

        }
    }
}