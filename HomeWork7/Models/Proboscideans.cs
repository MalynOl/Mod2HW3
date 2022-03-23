namespace HomeWork7
{
    public abstract class Proboscideans : Mammal // elephant parent
    {
        protected Proboscideans(string color) : base(color)
        {
        }

        public double LengthProboscis { get; set; }
    }
}
