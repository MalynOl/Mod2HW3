namespace HomeWork7
{
    public class CountService : ICountService
    {
        public double CountMinSquareForZoo(AnimalChordal[] animalChordals)
        {
            double sum = 0;
            for (int i = 0; i < animalChordals.Length; i++)
            {
                sum += animalChordals[i].MinSquareHouse;
            }

            return sum;
        }
    }
}
