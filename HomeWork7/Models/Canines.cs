using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    internal abstract class Canines : Predaceous // псовые
    {
        protected Canines(string color) : base(color)
        {
        }

        public int NumberIndividualsPack { get; set; }
    }
}
