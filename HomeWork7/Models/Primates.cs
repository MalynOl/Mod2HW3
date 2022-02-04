namespace HomeWork7
{
    public abstract class Primates : Mammal
    {
        protected Primates(string color) : base(color)
        {
        }

        public bool IsWalkingOnTwoLimbs { get; set; }
    }
}
