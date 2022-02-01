namespace HomeWork7
{
    internal class Starter
    {
        public Starter(IGetCatalogAnimals getCatalog, IFindService findService, ISortService sortService, ICountService countService, INotificationService notificationService)
        {
            CatalogAnimals = getCatalog;
            AllAnimals = CatalogAnimals.GetAnimals();

            FindService = findService;
            SortBySquareHouseService = sortService;
            SquareForZooService = countService;
            NotificationService = notificationService;

            MinAgeAnimal = 1;
            ClimateZonesSubTropical = ClimateZones.Subtropical;
        }

        public AnimalChordal[] AllAnimals { get; }
        public double MinAgeAnimal { get; init; }
        public ClimateZones ClimateZonesSubTropical { get; init; }

        private IGetCatalogAnimals CatalogAnimals { get; set; }

        private IFindService FindService { get; set; }
        private ISortService SortBySquareHouseService { get; set; }
        private ICountService SquareForZooService { get; set; }
        private INotificationService NotificationService { get; set; }

        public void Start()
        {
            NotificationService.WriteText("Животные старше 1 года, обитающие в субтропическом климате: ");
            var animalsOverTwoYearsAndTropicalClimateZone = FindService.FindAnimalByAgeAndClimate(AllAnimals, MinAgeAnimal, ClimateZonesSubTropical);
            NotificationService.WriteAnimals(animalsOverTwoYearsAndTropicalClimateZone);

            NotificationService.WriteText("Эти животные, отсортированные по минимальной площади вальера: ");
            var animalsSortBySquareHouse = SortBySquareHouseService.SortBySquareHouse(animalsOverTwoYearsAndTropicalClimateZone);
            NotificationService.WriteAnimals(animalsSortBySquareHouse);

            NotificationService.WriteText("Минимальная общая площадь вальеров: ");
            var minSquareForZoo = SquareForZooService.CountMinSquareForZoo(animalsSortBySquareHouse);
            NotificationService.WriteNumber(minSquareForZoo);
        }
    }
}
