namespace SnakeGame
{
    /// <summary>
    /// En abstrakt klass GameObjekt som sätter sig som bas för objekten vi skapar t.ex. spelare och mat.
    /// </summary>
    public abstract class GameObject
    {
        // Skapade en publikt variabel från klassen Position
        public Position Position;
        // Skapade en char variabel för Snake'ts utseende.
        public char Appearance;

        /// <summary>
        /// GameObject konstruktor
        /// </summary>
        /// <param name="position"> Positionen för X,Y som de ärver.</param>
        /// <param name="appeareance">Utseendet som de ärver.</param>
        public GameObject(Position position, char appeareance)
        {
            Position = position;
            Appearance = appeareance;
        }

        /// <summary>
        /// En virtual update så player kan update kan ta in parameter.
        /// </summary>
        public virtual void Update()
        {

        }
       
    }
}