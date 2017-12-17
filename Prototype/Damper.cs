using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    [Serializable]
    class Damper
    {
        public int Height;
        public int Weight;

        public Damper(int height, int weight)
        {
            Height = height;
            Weight = weight;
        }
    }
}
