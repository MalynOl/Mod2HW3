using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    internal interface ISwimmable
    {
        bool IsNeedWaterForLive { get; set; }

        string Swim();

        // double CalculateSquarePool(double lengthAnimal, double coefficient);
    }
}
