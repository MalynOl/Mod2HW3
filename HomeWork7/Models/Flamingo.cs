using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    internal class Flamingo : Auk, IJumping, IFlyable, ISwimmable
    {
        private int _classificationNumberForFlamingo;

        public Flamingo(string name, double squareHouse, double length, double age, bool isFly, bool gender, ClimateZones[] climate, string color)
            : base(color)
        {
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

        // private string FeathersColor { get; set; }
        public double MaxDistance { get; set; }

        public string Jump() => "Flamingo can jump";

        public string Swim() => "Flamingo can swim";

        public string Fly() => "Flamingo can fly";

        public override string FeedBabyInsect() => "Flamingo feed their children with insects";
    }
}
