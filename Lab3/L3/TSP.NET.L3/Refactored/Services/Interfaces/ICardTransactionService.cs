namespace TSP.NET.L3.Refactored.Services
{
    public interface ICardTransactionService
    {
        void ChargeCard(TicketDetails ticket, PaymentDetails payment);
    }
}