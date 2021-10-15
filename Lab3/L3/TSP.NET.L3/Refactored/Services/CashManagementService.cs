using System;

namespace TSP.NET.L3.Refactored.Services
{
    public class CashManagementService : ICashManagementService
    {
        private decimal _cashAccepted;

        public void AcceptCash(TicketDetails ticket)
        {
            var r = new Random();
            _cashAccepted = r.Next((int)ticket.Price, (int)ticket.Price + 1000);
        }

        public void DispenseChange(TicketDetails ticket, Action onPayChangeToMobilePhone)
        {
            if (_cashAccepted > ticket.Price &&
                !TryToDispense(_cashAccepted - ticket.Price))
                onPayChangeToMobilePhone?.Invoke();
        }

        private bool TryToDispense(decimal changeAmount)
        {
            return false; //or true :)
        }
    }
}
