namespace HomeWork7
{
    public interface INotificationService
    {
        public void WriteAnimals(AnimalChordal[] animalChordals);

        public void WriteText(string text);

        public void WriteNumber(double d);
    }
}
