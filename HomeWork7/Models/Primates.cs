namespace HomeWork7
{
    internal abstract class Primates : Mammal
    {
        protected Primates(string color) : base(color)
        {
        }

        public bool IsWalkingOnTwoLimbs { get; set; }
    }
}
