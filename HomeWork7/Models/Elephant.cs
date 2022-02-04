namespace HomeWork7
{
    public class Elephant : Proboscideans, ISwimmable
    {
        public Elephant(int id, string name, double squareHouse, double length, double age, bool isFly, bool gender, ClimateZones[] climate, string color, double lengthProboscis) : base(color)
        {
            ClassificationNumberForElephant = id;
            NameAnimal = name;
            MinSquareHouse = squareHouse;
            LengthAnimal = length;
            AgeAnimal = age;
            IsCanFly = isFly;
            GenderAnimal = gender;
            ClimateAnimal = climate;
            FurColor = color;
            LengthProboscis = lengthProboscis;
        }

        public bool IsNeedWaterForLive { get; set; }

        private int ClassificationNumberForElephant { get; set; }

        public string Swim() => "Elephant can swim";

        public override string FeedBabyMilk() => "Elephants feed their children with milk";
    }
}
