namespace HomeWork7
{
    public abstract class Felids : Predaceous // cats
    {
        protected Felids(string color) : base(color)
        {
        }

        public int PurrVolume { get; set; }
    }
}
