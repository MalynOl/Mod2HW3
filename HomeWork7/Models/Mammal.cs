namespace HomeWork7
{
    internal abstract class Mammal : AnimalChordal
    {
        protected Mammal(string color)
        {
            FurColor = color;
        }

        public string FurColor { get; set; }

        public abstract string FeedBabyMilk();
    }
}
