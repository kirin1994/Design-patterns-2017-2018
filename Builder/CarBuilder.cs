using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Builder
{
    class CarBuilder : ICarBuilder
    {
        private Car _car;

        public CarBuilder()
        {
            _car = new Car();
        }

        public void BuildBody()
        {
            IBody body = new Body();
            Console.WriteLine("Order: Creating body...10s");
            Thread.Sleep(10000);

            body.SetColor("Red");
            body.SetOption("Standard");

            _car.SetBody(body);

            Console.WriteLine("Order completed: Body");
        }

        public void BuildEngine()
        {
            IEngine engine = new Engine();
            Console.WriteLine("Order: Creating engine...5s");
            Thread.Sleep(5000);

            engine.SetPower(330);
            engine.SetMaxSpeed(230);

            _car.SetEngine(engine);

            Console.WriteLine("Order completed: Engine");
        }

        public void BuildSuspension()
        {
            ISuspension suspension = new Suspension();
            Console.WriteLine("Order: Creating Suspension...3");
            Thread.Sleep(3000);

            suspension.SetOption("Sport");
            suspension.SetHeight(35);

            _car.SetSuspension(suspension);

            Console.WriteLine("Order completed: Suspension");
        }

        public Car GetCar()
        {
            return _car;
        }
    }
}
