namespace HomeWork7
{
    public static class ExtensionMethods
    {
        public static T[] FindAnimalByAgeAndClimate<T>(this T[] array, double age, ClimateZones climateZone)
           where T : AnimalChordal
        {
            var newArray = new T[1];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].AgeAnimal >= age)
                {
                    if (array[i].ClimateAnimal.Contains(climateZone))
                    {
                        if (newArray.Length == 1 && newArray[0] == null)
                        {
                            newArray[0] = array[i];
                        }
                        else
                        {
                            newArray = newArray.Add(array[i]);
                        }
                    }
                }
            }

            return newArray;
        }

        public static T[] FindAnimalByAge<T>(this T[] array, double age)
            where T : AnimalChordal
        {
            var newArray = new T[1];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].AgeAnimal >= age)
                {
                    if (newArray.Length == 1 && newArray[0] == null)
                    {
                        newArray[0] = array[i];
                    }
                    else
                    {
                        newArray.Add(array[i]);
                    }
                }
            }

            return newArray;
        }

        public static T[] Add<T>(this T[] oldArray, T addItem)
            where T : AnimalChordal
        {
            T[] newArray = new T[oldArray.Length + 1];
            for (int i = 0; i < oldArray.Length; i++)
            {
                newArray[i] = oldArray[i];
            }

            newArray[oldArray.Length] = addItem;

            return newArray;
        }

        public static AnimalChordal FindAnimalByName(this AnimalChordal[] array, string name)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].NameAnimal == name)
                {
                    return array[i];
                }
            }

            return null;
        }
    }
}
