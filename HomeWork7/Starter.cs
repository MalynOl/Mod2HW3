namespace HomeWork7
{
    public class Starter
    {
        private IFindService _findService;
        private ISortService _sortBySquareHouseService;
        private ICountService _squareForZooService;
        private INotificationService _notificationService;

        public Starter(IGetCatalogAnimals getCatalog, IFindService findService, ISortService sortService, ICountService countService, INotificationService notificationService)
        {
            CatalogAnimals = getCatalog;
            AllAnimals = CatalogAnimals.GetAnimals();

            _findService = findService;
            _sortBySquareHouseService = sortService;
            _squareForZooService = countService;
            _notificationService = notificationService;

            MinAgeAnimal = 1;
            ClimateZonesSubTropical = ClimateZones.Subtropical;
        }

        public AnimalChordal[] AllAnimals { get; }
        public double MinAgeAnimal { get; init; }
        public ClimateZones ClimateZonesSubTropical { get; init; }

        private IGetCatalogAnimals CatalogAnimals { get; set; }

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
