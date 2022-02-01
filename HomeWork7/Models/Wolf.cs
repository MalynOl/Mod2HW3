namespace HomeWork7
{
    internal class Wolf : Canines, IJumping, ISwimmable
    {
        public Wolf(
            int id, string name, double squareHouse, double length, double age, bool isFly, bool gender, ClimateZones[] climate, string color, double numberKgMeet, int numberInPack) : base(color)
        {
            ClassificationNumberForWolf = id;
            NameAnimal = name;
            MinSquareHouse = squareHouse;
            LengthAnimal = length;
            AgeAnimal = age;
            IsCanFly = isFly;
            GenderAnimal = gender;
            ClimateAnimal = climate;
            FurColor = color;
            AmountOfMeatDay = numberKgMeet;
            NumberIndividualsPack = numberInPack;
        }

        public bool IsNeedWaterForLive { get; set; }

        public double MaxDistance { get; set; }

        private int ClassificationNumberForWolf { get; set; }

        public string Jump() => "Wolf can jump";

        public string Swim() => "Wolf can swim";

        public override string FeedBabyMilk() => "Wolf feed their children with milk";
    }
}
