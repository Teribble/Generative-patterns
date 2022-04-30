using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class TheSupplier
    {
        public Car GetCar(CarBuilder carBuilder)
        {
            carBuilder.InstallEngine();
            carBuilder.InstallFrame();
            carBuilder.InstallWheel();
            return carBuilder.Car;
        }
    }
}
