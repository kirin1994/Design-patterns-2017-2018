using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Motobike : IVehicle
    {
        public void drive()
        {
            Console.WriteLine("Wind in my hair, motobike - my best vehicle");
        }
    }
}
