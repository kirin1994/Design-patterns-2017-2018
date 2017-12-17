using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    [Serializable]
    class Car : ICloneable
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

        public Car(Car original)
        {
            Color = original.Color;
            Type = original.Type;
            Suspension = new Suspension(original.Suspension);
        }

        public object Clone()
        {
            return new Car(Color, Type, (Suspension) Suspension.Clone());
        }
    }
}
