using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    internal interface INotificationService
    {
        public void WriteAnimals(AnimalChordal[] animalChordals);

        public void WriteText(string text);

        public void WriteNumber(double d);
    }
}
