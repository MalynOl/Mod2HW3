namespace HomeWork7
{
    public class Chimpanzee : Primates, IJumping
    {
        public Chimpanzee(int id, string name, double squareHouse, double length, double age, bool isFly, bool gender, ClimateZones[] climate, string color, bool isWalkingOnTwo)
            : base(color)
        {
            ClassificationNumberForChimpanzee = id;
            NameAnimal = name;
            MinSquareHouse = squareHouse;
            LengthAnimal = length;
            AgeAnimal = age;
            IsCanFly = isFly;
            GenderAnimal = gender;
            ClimateAnimal = climate;
            FurColor = color;
            IsWalkingOnTwoLimbs = isWalkingOnTwo;
        }

        public double MaxDistance { get; set; }

        private int ClassificationNumberForChimpanzee { get; set; }

        public string Jump() => "Chimpanzee can Jump";

        public override string FeedBabyMilk() => "Chimpanzee feed their children with milk";
    }
}
