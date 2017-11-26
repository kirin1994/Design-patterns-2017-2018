using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class TruckFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            Console.WriteLine("Your brand new truck is ready to use.");
            return new Truck();
        }
    }
}
