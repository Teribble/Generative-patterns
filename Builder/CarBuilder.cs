using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class CarBuilder
    {
        public Car Car { get; private set; }
        public CarBuilder()
        {
            Car = new Car();
        }
        public abstract void InstallEngine();
        public abstract void InstallFrame();
        public abstract void InstallWheel();
    }
}
