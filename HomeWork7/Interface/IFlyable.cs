using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    internal interface IFlyable
    {
        double MaxWingspan { get; set; }

        string Fly();

        // double CalculateHeightCage(double wingspan, double coefficient);
    }
}
