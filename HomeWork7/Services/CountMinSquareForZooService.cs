using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    internal class CountMinSquareForZooService : ICountMinSquareForZooService
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
