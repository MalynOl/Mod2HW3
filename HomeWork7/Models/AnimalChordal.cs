using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    public abstract class AnimalChordal
    {
        // private double minSquareHouse;
        // private double lengthAnimal;
        // private double ageAnimal;
        // protected AnimalChordal(string name, double square, double length, double age, bool isFly, bool gender, ClimateZones[] climateZones)
        // {
        //    NameAnimal = name;
        //    MinSquareHouse = square;
        //    LengthAnimal = length;
        //    AgeAnimal = age;
        //    IsCanFly = isFly;
        //    GenderAnimal = gender;
        //    ClimateAnimal = climateZones;
        // }
        public string NameAnimal { get; set; }

        public double MinSquareHouse { get; set; }

        public double LengthAnimal { get; set; }

        public double AgeAnimal { get; set; }

        public bool IsCanFly { get; set; }

        public bool GenderAnimal { get; set; }

        public ClimateZones[] ClimateAnimal { get; set; }
    }
}
