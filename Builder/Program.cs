using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarBuilder carBuilder = new CarBuilder();
            Boss boss = new Boss(carBuilder);
            boss.BuildCar();
            Car car = boss.GetCar();
            car.Description();
            
        }
    }
}
