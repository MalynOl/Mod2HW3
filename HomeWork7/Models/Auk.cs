namespace HomeWork7
{
    public abstract class Auk : AnimalChordal// birds
    {
        protected Auk(string color)
        {
            FeathersColor = color;
        }

        public string FeathersColor { get; set; }

        public abstract string FeedBabyInsect();
    }
}
