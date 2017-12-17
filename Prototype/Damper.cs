using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    [Serializable]
    class Damper : ICloneable
    {
        public int Height;
        public int Weight;

        public Damper(int height, int weight)
        {
            Height = height;
            Weight = weight;
        }

        public Damper(Damper original)
        {
            Weight = original.Weight;
            Height = original.Height;
        }

        public object Clone()
        {
            return new Damper(Height, Weight);
        }
    }
}
