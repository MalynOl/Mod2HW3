using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    internal class Starter
    {
        private CatalogAnimals _catalogAnimals;

        private IFindService _findService;
        private ISortBySquareHouseService _sortBySquareHouseService;
        private ICountMinSquareForZooService _squareForZooService;
        private INotificationService _notificationService;

        public Starter()
        {
            _catalogAnimals = new CatalogAnimals();
            AllAnimals = _catalogAnimals.GetAnimals();
            MinAgeAnimal = 1;
            ClimateZonesSubTropical = ClimateZones.Subtropical;
        }

        public AnimalChordal[] AllAnimals { get; }
        public double MinAgeAnimal { get; init; }
        public ClimateZones ClimateZonesSubTropical { get; init; }
        public void Start()
        {
            _notificationService.WriteText("Животные старше 1 года, обитающие в субтропическом климате: ");
            var animalsOverTwoYearsAndTropicalClimateZone = _findService.FindAnimalByAgeAndClimate(AllAnimals, MinAgeAnimal, ClimateZonesSubTropical);
            _notificationService.WriteAnimals(animalsOverTwoYearsAndTropicalClimateZone);
            _notificationService.WriteText("Эти животные, отсортированные по минимальной площади вальера: ");
            var animalsSortBySquareHouse = _sortBySquareHouseService.SortBySquareHouse(animalsOverTwoYearsAndTropicalClimateZone);
            _notificationService.WriteAnimals(animalsSortBySquareHouse);
            _notificationService.WriteText("Минимальная общая площадь вальеров: ");
            var minSquareForZoo = _squareForZooService.CountMinSquareForZoo(animalsSortBySquareHouse);
            _notificationService.WriteNumber(minSquareForZoo);
        }
    }
}
