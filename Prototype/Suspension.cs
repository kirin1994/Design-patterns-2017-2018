using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    [Serializable]
    class Suspension : ICloneable
    {
        public string Type;
        public Damper Damper;

        public Suspension(string type, Damper damper)
        {
            Type = type;
            Damper = damper;
        }

        public Suspension(Suspension original)
        {
            Type = original.Type;
            Damper = new Damper(original.Damper);
        }

        public object Clone()
        {
            return new Suspension(Type, (Damper)Damper.Clone());
        }
    }
}
