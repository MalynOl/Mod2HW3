using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    internal class SortBySquareHouseService : ISortBySquareHouseService
    {
        public AnimalChordal[] SortBySquareHouse(AnimalChordal[] allAnimals)
        {
            for (int i = 0; i < allAnimals.Length - 1; i++)
            {
                for (int j = i + 1; j < allAnimals.Length; j++)
                {
                    if (allAnimals[i].MinSquareHouse > allAnimals[j].MinSquareHouse)
                    {
                        var temp = allAnimals[i];
                        allAnimals[i] = allAnimals[j];
                        allAnimals[j] = temp;
                    }
                }
            }

            return allAnimals;
        }
    }
}
