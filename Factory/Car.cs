using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Car : IVehicle
    {
        public void drive()
        {
            Console.WriteLine("This car is fast");
        }
    }
}
