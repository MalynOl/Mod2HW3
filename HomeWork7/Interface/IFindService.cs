using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    internal interface IFindService
    {
        public AnimalChordal[] FindAnimalByAgeAndClimate(AnimalChordal[] allAnimals, double age, ClimateZones climateZone);
        public AnimalChordal[] FindAnimalByAge(AnimalChordal[] allAnimals, double age);
    }
}
