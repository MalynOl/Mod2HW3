using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    internal class FindService : IFindService
    {
        public AnimalChordal[] FindAnimalByAgeAndClimate(AnimalChordal[] allAnimals, double age, ClimateZones climateZone)
        {
            return allAnimals.FindAnimalByAgeAndClimate(age, climateZone);
        }

        public AnimalChordal[] FindAnimalByAge(AnimalChordal[] allAnimals, double age)
        {
            return allAnimals.FindAnimalByAge(age);
        }
    }
}
