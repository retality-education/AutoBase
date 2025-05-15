using AutoBase.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBase.Model.Cars
{
    internal class HeavyWorkerCar : Car
    {
        public HeavyWorkerCar()
        {
            Type = CarType.HeavyWorker;
            Condition = CarCondition.Working;
        }
    }
}
