using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Truck : IVehicle
    {
        public void drive()
        {
            Console.WriteLine("Designed to transport cargo");
        }
    }
}
