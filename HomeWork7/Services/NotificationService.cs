namespace HomeWork7
{
    public class NotificationService : INotificationService
    {
        public void WriteAnimals(AnimalChordal[] animalChordals)
        {
            string gender = " ";
            for (int i = 0; i < animalChordals.Length; i++)
            {
                gender = animalChordals[i].GenderAnimal ? "Мальчик" : "Девочка";
                Console.WriteLine($"{gender} {animalChordals[i].GetType().Name} по имени {animalChordals[i].NameAnimal}, необходимая минимальная площадь вальера: {animalChordals[i].MinSquareHouse}");
            }

            Console.WriteLine();
        }

        public void WriteText(string text)
        {
            Console.WriteLine(text);
        }

        public void WriteNumber(double d)
        {
            Console.WriteLine(d.ToString());
        }
    }
}
