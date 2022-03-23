namespace HomeWork7
{
    public interface IFindService
    {
        public AnimalChordal[] FindAnimalByAgeAndClimate(AnimalChordal[] allAnimals, double age, ClimateZones climateZone);
        public AnimalChordal[] FindAnimalByAge(AnimalChordal[] allAnimals, double age);
    }
}
