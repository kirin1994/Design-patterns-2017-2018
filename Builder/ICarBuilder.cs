using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    interface ICarBuilder
    {
        void BuildEngine();
        void BuildSuspension();
        void BuildBody();
        Car GetCar();
    }
}
