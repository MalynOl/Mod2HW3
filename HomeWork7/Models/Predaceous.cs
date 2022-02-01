namespace HomeWork7
{
    internal abstract class Predaceous : Mammal // хищные
    {
        protected Predaceous(string color) : base(color)
        {
        }

        public double AmountOfMeatDay { get; set; }
    }
}
