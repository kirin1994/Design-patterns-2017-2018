using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Engine : IEngine
    {
        private int _power;
        private int _maxSpeed;

        public int GetMaxSpeed()
        {
            return _maxSpeed;
        }

        public void SetMaxSpeed(int maxSpeed)
        {
            _maxSpeed = maxSpeed;
        }

        public int GetPower()
        {
            return _power;
        }

        public void SetPower(int power)
        {
            _power = power;
        }
    }
}
