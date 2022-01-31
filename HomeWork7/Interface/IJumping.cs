using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    internal interface IJumping
    {
        double MaxDistance { get; set; }

        string Jump();

        // double CalculateLengthCage( double coefficient);
    }
}
