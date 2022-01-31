using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    internal abstract class Predaceous : Mammal // хищные
    {
        protected Predaceous(string color) : base(color)
        {
        }

        public double AmountOfMeatDay { get; set; }
    }
}
