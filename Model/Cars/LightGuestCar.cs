using AutoBase.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBase.Model.Cars
{
    internal class LightGuestCar : Car
    {
        public LightGuestCar()
        {
            Type = CarType.LightWorker;
            Condition = CarCondition.Broken;
        }
    }
}
