using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class MotobikeFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            Console.WriteLine("Your brand new motobike is ready to use.");
            return new Motobike();
        }
    }
}
