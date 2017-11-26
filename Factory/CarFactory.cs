using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class CarFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            Console.WriteLine($"Your brand Car vechicle is ready to use.");
            return new Car();
        }
    }
}
