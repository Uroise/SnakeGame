using System;

namespace SnakeGame
{
    /// <summary>
    /// Console renderer klassen som renderar världen och våra objekt.
    /// </summary>
    internal class ConsoleRenderer
    {
        Random rand = new Random();
        private GameWorld world;

        /// <summary>
        /// En konstruktor för ConsoleRender
        /// </summary>
        /// <param name="gameWorld">Objekt instansen som representerar höjden och bredden för världen.</param>
        public ConsoleRenderer(GameWorld gameWorld)
        {
            // Satt Consolens storlek.
            Console.SetWindowSize(gameWorld.width, gameWorld.height);
            Console.SetBufferSize(gameWorld.width, gameWorld.height);
            world = gameWorld;
            Console.Clear();

        }
        /// <summary>
        /// Metod för att rendera objekten.
        /// </summary>
        public void RenderObjects()
        {
            foreach (GameObject obj in world.gameObjects)  // en foreach loop för att söka igenom gameObjects listan.
            {
                Console.ResetColor(); // ställer tillbaks färgen efter varje loop.

                if (obj is Player) // Om objektet i listan är en spelare kör detta ->
                {   
                   
                    if (obj.Position.X > world.width - 2) // ifall snake träffar väggen den börjar om från andra sidan.
                    {
                        obj.Position.X = 2;
                        Console.SetCursorPosition(obj.Position.X, obj.Position.Y);
                    }
                    else if (obj.Position.X < 2) 
                    {
                        obj.Position.X = world.width - 2;
                        Console.SetCursorPosition(obj.Position.X, obj.Position.Y);
                    }
                    else if (obj.Position.Y < 2) 
                    {
                        obj.Position.Y = world.height - 1;
                        Console.SetCursorPosition(obj.Position.X, obj.Position.Y);
                    }

                    else if (obj.Position.Y > world.height - 2) 
                    {
                        obj.Position.Y = 1;
                        Console.SetCursorPosition(obj.Position.X, obj.Position.Y);
                    }
                    else
                    {
                        Console.SetCursorPosition(obj.Position.X, obj.Position.Y);
                        Console.Write(obj.Appearance);
                    }

                }
                else
                {
                    int FoodColorRandomer = rand.Next(1, 3);
                    switch (FoodColorRandomer)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            break;

                    }
                    Console.SetCursorPosition(obj.Position.X, obj.Position.Y);
                    Console.Write(obj.Appearance);
                    

                }
                
            }
        }

        // vi använder inte denna då vi kunde lösa det genom att rendera blank efter spelaren har förflyttas sig i Player klassen.
        /*        public void RenderBlank()
                {

                    foreach (GameObject obj in world.gameObjects)
                    {

                        if (obj.Position.X < 1)
                        {
                            Console.SetCursorPosition(obj.Position.X, obj.Position.Y);
                            Console.Write(" ");
                        }
                        if (obj.Position.X > world.width)
                        {
                            Console.SetCursorPosition(obj.Position.X, obj.Position.Y);
                            Console.Write(" ");
                        }
                        if (obj.Position.Y < 1)
                        {
                            Console.SetCursorPosition(obj.Position.X, obj.Position.Y);
                            Console.Write(" ");
                        }
                        if (obj.Position.Y > world.height - 2)
                        {
                            Console.SetCursorPosition(obj.Position.X, obj.Position.Y);
                            Console.Write(" ");
                        }

                    }
                }*/


        /// <summary>
        /// Metod för att rendera världen genom for loop
        /// </summary>
        public void Render()
        {
            Console.CursorVisible = false;

            Console.ForegroundColor = ConsoleColor.DarkMagenta; // färgar väggarna
            Console.BackgroundColor = ConsoleColor.DarkMagenta;

            for (int i = 1; i <= (world.width - 1); i++)  // bredden på världen där vi kör for loop för både högra och vänstra väggen
            {
                Console.SetCursorPosition(i, 1);
                Console.Write("■");
            }
            for (int i = 1; i <= (world.width - 1); i++)
            {
                Console.SetCursorPosition(i, (world.height - 1));
                Console.Write("■");
            }
            for (int i = 1; i <= (world.height - 1); i++) // höjden  på världen där vi kör for loop för både toppen och botten väggen
            {
                Console.SetCursorPosition(1, i);
                Console.Write("■");
            }
            for (int i = 1; i <= (world.height - 1); i++)
            {
                Console.SetCursorPosition((world.width - 1), i);
                Console.Write("■");
            }
        }
    }
}