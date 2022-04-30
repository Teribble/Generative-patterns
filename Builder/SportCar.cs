using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class SportCar : CarBuilder
    {
        public override void InstallEngine()
        {
            this.Car.Engine = new Engine { Model = "Sport2000" };
        }

        public override void InstallFrame()
        {
            this.Car.Frame = new Frame { Country = "Германия" };
        }

        public override void InstallWheel()
        {
            this.Car.Wheel = new Wheel { Company = "SportWheel" };
        }
    }
}
