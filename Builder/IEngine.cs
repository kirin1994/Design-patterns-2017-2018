using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    interface IEngine
    {
        int GetPower();
        void SetPower(int power);
        int GetMaxSpeed();
        void SetMaxSpeed(int maxSpeed);
    }
}
