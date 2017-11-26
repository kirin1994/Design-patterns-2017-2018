﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    interface IVehicleFactory
    {
       IVehicle CreateVehicle();
    }
}
