using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    internal class Wolf : Canines, IJumping, ISwimmable
    {
        private int _classificationNumberForWolf;

        public Wolf(
            string name, double squareHouse, double length, double age, bool isFly, bool gender, ClimateZones[] climate, string color, double numberKgMeet, int numberInPack) : base(color)
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
            NumberIndividualsPack = numberInPack;
        }

        public bool IsNeedWaterForLive { get; set; }

        public double MaxDistance { get; set; }

        public string Jump() => "Wolf can jump";

        public string Swim() => "Wolf can swim";

        public override string FeedBabyMilk() => "Wolf feed their children with milk";
    }
}
