namespace HomeWork7
{
    public class FindService : IFindService
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
