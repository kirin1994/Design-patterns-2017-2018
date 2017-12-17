using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    [Serializable]
    class Car
    {
        public string Color;
        public string Type;
        public Suspension Suspension;

        public Car(string color, string type, Suspension suspension )
        {
            Color = color;
            Type = type;
            Suspension = suspension;
        }
    }
}
