using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    internal class Chimpanzee : Primates, IJumping
    {
        private int _classificationNumberForChimpanzee;

        public Chimpanzee(string name, double squareHouse, double length, double age, bool isFly, bool gender, ClimateZones[] climate, string color, bool isWalkingOnTwo)
            : base(color)
        {
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

        public string Jump() => "Chimpanzee can Jump";

        public override string FeedBabyMilk() => "Chimpanzee feed their children with milk";
    }
}
