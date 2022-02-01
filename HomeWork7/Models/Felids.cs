namespace HomeWork7
{
    internal abstract class Felids : Predaceous // кошачьи
    {
        protected Felids(string color) : base(color)
        {
        }

        public int PurrVolume { get; set; }
    }
}
