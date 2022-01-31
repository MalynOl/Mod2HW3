using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    internal abstract class Auk : AnimalChordal// птицы
    {
        protected Auk(string color) // base (name, square, length, age, isFly, gender, climateZones)
        {
            FeathersColor = color;
        }

        public string FeathersColor { get; set; }

        public abstract string FeedBabyInsect();
    }
}
