using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Rectangle : IFigure
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;

            Height = height;
        }
        public IFigure Clone()
        {
            return new Rectangle(this.Width, this.Height);
        }

        public void GetInfo()
        {
            Console.WriteLine("Прямоуголник " + Width + " " + Height);
        }
    }
}
