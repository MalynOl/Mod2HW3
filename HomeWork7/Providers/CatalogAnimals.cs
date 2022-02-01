namespace HomeWork7
{
    internal class CatalogAnimals : IGetCatalogAnimals
    {
        public CatalogAnimals()
        {
            AllAnimals = GetAnimals();
        }

        public AnimalChordal[] AllAnimals { get; set; }

        public AnimalChordal[] GetAnimals()
        {
            Wolf wolfGreyGeneral = new Wolf(
                id: 1012,
                name: "Artur",
                squareHouse: 30,
                length: 70.4,
                age: 3.2,
                isFly: false,
                gender: true,
                climate: new ClimateZones[2] { ClimateZones.Continental, ClimateZones.Subtropical },
                color: "grey",
                numberKgMeet: 5,
                numberInPack: 10);
            Wolf wolfRed = new Wolf(
                id: 10121,
                name: "Armin",
                squareHouse: 30,
                length: 65.4,
                age: 2.1,
                isFly: false,
                gender: false,
                climate: new ClimateZones[1] { ClimateZones.Subtropical },
                color: "red",
                numberKgMeet: 3,
                numberInPack: 6);
            Wolf wolfPolar = new Wolf(
                id: 10123,
                name: "Arct",
                squareHouse: 40,
                length: 75,
                age: 1.5,
                isFly: false,
                gender: true,
                climate: new ClimateZones[1] { ClimateZones.Polar },
                color: "white",
                numberKgMeet: 9,
                numberInPack: 12);
            Lion lionAfric1 = new Lion(
                id: 0909,
                name: "Lucky",
                squareHouse: 20,
                length: 1.6,
                age: 1.5,
                isFly: false,
                gender: true,
                climate: new ClimateZones[2] { ClimateZones.Subtropical, ClimateZones.Tropical },
                color: "brown-orange",
                numberKgMeet: 7,
                volumePurr: 1);
            Lion lionAfric2 = new Lion(
                id: 0909,
                name: "Lusy",
                squareHouse: 20,
                length: 1.5,
                age: 1.8,
                isFly: false,
                gender: false,
                climate: new ClimateZones[2] { ClimateZones.Subtropical, ClimateZones.Tropical },
                color: "brown-orange",
                numberKgMeet: 5,
                volumePurr: 1);
            Elephant elephantAfric = new Elephant(
                id: 00076,
                name: "Teodor",
                squareHouse: 40,
                length: 2.6,
                age: 2.5,
                isFly: false,
                gender: true,
                climate: new ClimateZones[2] { ClimateZones.Subtropical, ClimateZones.Tropical },
                color: "grey",
                lengthProboscis: 1.2);
            Chimpanzee chimpanzeeAfric1 = new Chimpanzee(
                id: 0123,
                name: "Micky",
                squareHouse: 10,
                length: 0.6,
                age: 1.5,
                isFly: false,
                gender: true,
                climate: new ClimateZones[2] { ClimateZones.Subtropical, ClimateZones.Tropical },
                color: "black",
                isWalkingOnTwo: true);
            Chimpanzee chimpanzeeAfric2 = new Chimpanzee(
                id: 01231,
                name: "Mocky",
                squareHouse: 10,
                length: 0.6,
                age: 0.7,
                isFly: false,
                gender: true,
                climate: new ClimateZones[2] { ClimateZones.Subtropical, ClimateZones.Tropical },
                color: "black",
                isWalkingOnTwo: true);
            Flamingo flamingoAfric1 = new Flamingo(
                id: 0099,
                name: "Flamingo1",
                squareHouse: 10,
                length: 0.8,
                age: 1.2,
                isFly: true,
                gender: true,
                climate: new ClimateZones[2] { ClimateZones.Subtropical, ClimateZones.Tropical },
                color: "pink");
            Flamingo flamingoAfric2 = new Flamingo(
                id: 009912,
                name: "Flamingo2",
                squareHouse: 10,
                length: 0.6,
                age: 0.2,
                isFly: true,
                gender: true,
                climate: new ClimateZones[2] { ClimateZones.Subtropical, ClimateZones.Tropical },
                color: "pink");

            Flamingo flamingoAfric3 = new Flamingo(
                id: 009913,
                name: "Flamingo3",
                squareHouse: 10,
                length: 0.6,
                age: 1.2,
                isFly: true,
                gender: false,
                climate: new ClimateZones[2] { ClimateZones.Subtropical, ClimateZones.Tropical },
                color: "pink");
            AnimalChordal[] animals = new AnimalChordal[]
            {
                wolfGreyGeneral, wolfRed, wolfPolar, elephantAfric, chimpanzeeAfric1, chimpanzeeAfric2, flamingoAfric1, flamingoAfric2, flamingoAfric3, lionAfric1, lionAfric2
            };
            return animals;
        }
    }
}