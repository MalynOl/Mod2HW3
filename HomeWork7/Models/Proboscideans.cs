using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    internal abstract class Proboscideans : Mammal // хоботные
    {
        protected Proboscideans(string color) : base(color)
        {
        }

        public double LengthProboscis { get; set; }
    }
}
