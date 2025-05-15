using AutoBase.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBase.Model.Cars
{
    internal abstract class Car
    {
        public CarType Type { get; protected set; }
        public CarCondition Condition { get; set; }
    }
}
