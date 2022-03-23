namespace HomeWork7
{
    public class Flamingo : Auk, IJumping, IFlyable, ISwimmable
    {
        public Flamingo(int id, string name, double squareHouse, double length, double age, bool isFly, bool gender, ClimateZones[] climate, string color)
            : base(color)
        {
            ClassificationNumberForFlamingo = id;
            NameAnimal = name;
            MinSquareHouse = squareHouse;
            LengthAnimal = length;
            AgeAnimal = age;
            IsCanFly = isFly;
            GenderAnimal = gender;
            ClimateAnimal = climate;
            FeathersColor = color;
        }

        public double MaxWingspan { get; set; }

        public bool IsNeedWaterForLive { get; set; }

        public double MaxDistance { get; set; }

        private int ClassificationNumberForFlamingo { get; set; }

        public string Jump() => "Flamingo can jump";

        public string Swim() => "Flamingo can swim";

        public string Fly() => "Flamingo can fly";

        public override string FeedBabyInsect() => "Flamingo feed their children with insects";
    }
}
