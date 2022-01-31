using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    internal class Lion : Felids, ISwimmable, IJumping
    {
        private int _classificationNumberForLion;

        public Lion(string name, double squareHouse, double length, double age, bool isFly, bool gender, ClimateZones[] climate, string color, double numberKgMeet, int volumePurr) : base(color)
        {
            NameAnimal = name;
            MinSquareHouse = squareHouse;
            LengthAnimal = length;
            AgeAnimal = age;
            IsCanFly = isFly;
            GenderAnimal = gender;
            ClimateAnimal = climate;
            FurColor = color;
            AmountOfMeatDay = numberKgMeet;
            PurrVolume = volumePurr;
        }

        public bool IsNeedWaterForLive { get; set; }

        public double MaxDistance { get; set; }

        public string Jump() => "Lion can jump";

        public string Swim() => "Lion can swim";

        public override string FeedBabyMilk() => "Lions feed their children with milk";
    }
}
