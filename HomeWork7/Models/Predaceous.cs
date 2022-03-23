namespace HomeWork7
{
    public abstract class Predaceous : Mammal // wolf parent
    {
        protected Predaceous(string color) : base(color)
        {
        }

        public double AmountOfMeatDay { get; set; }
    }
}
