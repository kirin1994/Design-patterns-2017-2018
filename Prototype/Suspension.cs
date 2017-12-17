using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    [Serializable]
    class Suspension
    {
        public string Type;
        public Damper Damper;

        public Suspension(string type, Damper damper)
        {
            Type = type;
            Damper = damper;
        }
    }
}
