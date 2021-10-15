namespace TSP.NET.L3.Refactored.Services
{
    public class CardTransactionService
    {
        private void ChargeCard(TicketDetails ticket, PaymentDetails payment)
        {
            var gateway = new ProcessingCenterGateway();
            gateway.Charge(ticket.Price, payment);
        }
    }
}
