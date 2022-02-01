namespace HomeWork7
{
    internal abstract class Proboscideans : Mammal // хоботные
    {
        protected Proboscideans(string color) : base(color)
        {
        }

        public double LengthProboscis { get; set; }
    }
}
