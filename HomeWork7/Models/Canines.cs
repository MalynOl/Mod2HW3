namespace HomeWork7
{
    public abstract class Canines : Predaceous // dogs
    {
        protected Canines(string color) : base(color)
        {
        }

        public int NumberIndividualsPack { get; set; }
    }
}
