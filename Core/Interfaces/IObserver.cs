﻿using AutoBase.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBase.Core.Interfaces
{
    internal interface IObserver
    {
        void OnAutobaseEvent(ModelEventArgs args);
    }
}
