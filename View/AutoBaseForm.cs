using AutoBase.Controller;
using AutoBase.Core.Enums;
using AutoBase.Core.Events;
using AutoBase.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBase.View
{
    internal partial class AutoBaseForm : Form, IAutoBaseView
    {
        public AutoBaseController autoBaseController;

        public AutoBaseForm()
        {
            InitializeComponent();
            
        }

        void start()
        {
            autoBaseController.Start();
        }
        private void LogMessage(string message, [CallerMemberName] string methodName = "")
        {
            Console.WriteLine($"[{methodName}] {message}");
        }
        #region  IAutoBaseView
        public void OnGuestMoveAwayFromBase(int CarId)
        {
            LogMessage($"{CarId}");
        }

        public void OnGuestMoveToChief(int CarId)
        {
            LogMessage($"{CarId}");
        }

        public void OnGuestMoveToRepair(int CarId)
        {
            LogMessage($"{CarId}");
        }

        public void OnReceiveOfflineOrder()
        {
            LogMessage("");
        }

        public void OnReceiveOnlineOrder()
        {
            LogMessage("");
        }

        public void OnWorkerCarCameFromOrderToGarage(int CarId)
        {
            LogMessage($"{CarId}");
        }

        public void OnWorkerCarCameFromOrderToRepair(int CarId)
        {
            LogMessage($"{CarId}");
        }

        public void OnWorkerCarMoveFromRepairToGarage(int CarId)
        {
            LogMessage($"{CarId}");
        }

        public void OnWorkerCarMoveToOrder(int CarId)
        {
            LogMessage($"{CarId}");
        }

        public void OnWorkerMoveToGarage()
        {
            LogMessage("");
        }

        public void OnWorkerMoveToRepair()
        {
            LogMessage("");
        }
        #endregion
        public void OnAutobaseEvent(ModelEventArgs args)
        {
            switch (args.EventType)
            {
                case EventType.GuestMoveToChief:
                    OnGuestMoveToChief(CarId: args.CarInfo!.Id);
                    break;
                case EventType.ReceiveOfflineOrder:
                    OnReceiveOfflineOrder();
                    break;
                case EventType.GuestMoveToRepair:
                    OnGuestMoveToRepair(CarId: args.CarInfo!.Id);
                    break;
                case EventType.WorkerMoveToRepair:
                    OnWorkerMoveToRepair();
                    break;
                case EventType.GuestMoveAwayFromBase:
                    OnGuestMoveAwayFromBase(CarId: args.CarInfo!.Id);
                    break;
                case EventType.ReceiveOnlineOrder:
                    OnReceiveOnlineOrder();
                    break;
                case EventType.WorkerMoveToGarage:
                    OnWorkerMoveToGarage();
                    break;
                case EventType.WorkerCarMoveToOrder:
                    OnWorkerCarMoveToOrder(CarId: args.CarInfo!.Id);
                    break;
                case EventType.WorkerCarCameFromOrderToGarage:
                    OnWorkerCarCameFromOrderToGarage(CarId: args.CarInfo!.Id);
                    break;
                case EventType.WorkerCarCameFromOrderToRepair:
                    OnWorkerCarCameFromOrderToRepair(CarId: args.CarInfo!.Id);
                    break;
                case EventType.WorkerCarMoveFromRepairToGarage:
                    OnWorkerCarMoveFromRepairToGarage(CarId: args.CarInfo!.Id);
                    break;
                default:
                    break;
            }
        }

        private void AutoBaseForm_Load(object sender, EventArgs e)
        {
            start();
        }
    }
}
