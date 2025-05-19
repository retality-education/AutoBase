using AutoBase.Core.Events;
using AutoBase.Core.Interfaces;
using AutoBase.Model.Peoples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBase.View
{
    internal interface IAutoBaseView : IObserver
    {
        //online
        void OnReceiveOnlineOrder();
        void OnWorkerMoveToGarage();
        void OnWorkerCarMoveToOrder(int CarId);
        void OnWorkerCarCameFromOrderToGarage(int CarId);
        void OnWorkerCarCameFromOrderToRepair(int CarId);
        void OnWorkerCarMoveFromRepairToGarage(int CarId);

        //offline
        void OnGuestMoveToChief(int CarId);
        void OnReceiveOfflineOrder();
        void OnGuestMoveToRepair(int CarId);
        void OnWorkerMoveToRepair();
        void OnGuestMoveAwayFromBase(int CarId);
    }
}
