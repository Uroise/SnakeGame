using System;
using System.Collections.Generic;
using System.Linq;

namespace SnakeGame
{
    /// <summary>
    /// GameWorld klassen där vi bestämmer längd,höjd, poäng och updatering som sker för objekten när de förändras.
    /// </summary>
    public class GameWorld
    {

        // En lista som ska innehålla alla objekt i spelet
        public List<GameObject> gameObjects = new List<GameObject>();

        // Variabler för hur stor spelvärlden är 
        public int width;
        public int height;
        // Variabel för antal poäng
        public int Score;


        /// <summary>
        /// En Konstruktor för GameWorld med Bredd och Höjd
        /// </summary>
        /// <param name="_width">Representerar bredden för spelet</param>
        /// <param name="_height">Representerar bredden för spelet</param>
        public GameWorld(int _width, int _height)
        {
            width = _width;
            height = _height;

        }

        /// <summary>
        /// Update metoden för GameWorld som loppar igenom gameObjects listan och sedan anropar Update()
        /// </summary>
        public void Update()
        {
       
            // Vi kör en foreach loop för att  gå igenom objekten i listan där ifall ormen och maten är i samma position.
            foreach (GameObject gameObject in gameObjects)
            {
                // Ifall objektet är av typen Food
                if (gameObject is Food food)
                {
                    // Hämta spelar instansen med hjälp av Linq (Kommer bara funka ifall det finns 1 och enbart 1 instans av Player pga .Single)
                    Player player = (Player)gameObjects.Single(p => p is Player);

                    // Jämnför positionerna 
                    if (food.Position.X == player.Position.X && food.Position.Y == player.Position.Y)
                    {
                        food.Update();
                        Score++;
                        Console.Title = "Score: " + Score;
                    }
                }
            }

        }
    }
}