using System;
using TSP.NET.L3.Refactored.Services;

namespace TSP.NET.L3.Refactored
{
    public class PaymentHandler
    {
        private readonly ICashManagementService cashManagementService;
        private readonly ICardTransactionService cardTransactionService;

        public PaymentHandler(ICashManagementService cashManagementService, ICardTransactionService cardTransactionService)
        {
            this.cashManagementService = cashManagementService;
            this.cardTransactionService = cardTransactionService;
        }

        public void BuyTicket(TicketDetails ticket,
                              PaymentDetails payment, Action onPayChangeToMobilePhone)
        {
            if (payment.Method == PaymentMethod.CreditCard)
            {
                cardTransactionService.ChargeCard(ticket, payment);
            }
            else
            {
                cashManagementService.AcceptCash(ticket);
                cashManagementService.DispenseChange(ticket, onPayChangeToMobilePhone);
            }
        }
    }
}
