using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Circle : IFigure
    {
        public int Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public IFigure Clone()
        {
            return new Circle(Radius);
        }

        public void GetInfo()
        {
            Console.WriteLine("Круг с радиусом: " + Radius);
        }
    }
}
