using System;

namespace TSP.NET.L3.Refactored.Services
{
    public interface ICashManagementService
    {
        void AcceptCash(TicketDetails ticket);

        void DispenseChange(TicketDetails ticket, Action onPayChangeToMobilePhone);
    }
}