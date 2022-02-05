namespace SnakeGame
{
    public abstract class GameObject
    {
        // Skapade en publikt variabel från klassen Position
        public Position Position;
        // Skapade en char variabel för Snake'ts utseende.
        public char Appearance;

        public GameObject(Position position, char appeareance)
        {
            Position = position;
            Appearance = appeareance;
        }

        public void Update()
        {

        }
    }
}