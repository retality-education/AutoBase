using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBase.Model.Enums
{
    internal enum EventType
    {
        //offline
        ReceiveOnlineOrder,
        WorkerMoveToGarage,
        WorkerCarMoveToOrder,
        WorkerCarCameFromOrderToGarage,
        WorkerCarCameFromOrderToRepair,
        WorkerCarMoveFromRepairToGarage,

        //online
        GuestMoveToChief,
        ReceiveOfflineOrder,
        GuestMoveToRepair,
        WorkerMoveToRepair,
        GuestMoveAwayFromBase
    }
}
