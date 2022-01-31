using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    internal class Elephant : Proboscideans, ISwimmable
    {
        private int _classificationNumberForElephant;

        public Elephant(string name, double squareHouse, double length, double age, bool isFly, bool gender, ClimateZones[] climate, string color, double lengthProboscis) : base(color)
        {
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

        // public int MinSquareHouse { get; set; }
        public bool IsNeedWaterForLive { get; set; }

        public string Swim() => "Elephant can swim";

        public override string FeedBabyMilk() => "Elephants feed their children with milk";
    }
}
