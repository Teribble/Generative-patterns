using System;

namespace Builder
{
    class Program
    {
        public static void Main()
        {
            TheSupplier supplier = new TheSupplier();

            CarBuilder builder = new SportCar();

            Car car = supplier.GetCar(builder);

            Console.WriteLine(car.ToString());

            builder = new RegularCar();

            Car car1 = supplier.GetCar(builder);

            Console.WriteLine(car1.ToString());
        }
    }
}