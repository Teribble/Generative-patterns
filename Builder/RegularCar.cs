using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class RegularCar : CarBuilder
    {
        public override void InstallEngine()
        {
            this.Car.Engine = new Engine { Model = "Обычный 1.5" };
        }

        public override void InstallFrame()
        {
            this.Car.Frame = new Frame { Country = "Россия" };
        }

        public override void InstallWheel()
        {
            this.Car.Wheel = new Wheel { Company = "Рынок" };
        }
    }
}
