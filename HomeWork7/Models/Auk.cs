namespace HomeWork7
{
    internal abstract class Auk : AnimalChordal// птицы
    {
        protected Auk(string color)
        {
            FeathersColor = color;
        }

        public string FeathersColor { get; set; }

        public abstract string FeedBabyInsect();
    }
}
