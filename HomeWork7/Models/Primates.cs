using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    internal abstract class Primates : Mammal
    {
        protected Primates(string color) : base(color)
        {
        }

        public bool IsWalkingOnTwoLimbs { get; set; }
    }
}
