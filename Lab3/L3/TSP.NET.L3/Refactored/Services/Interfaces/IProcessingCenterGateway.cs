namespace TSP.NET.L3.Refactored.Services.Interfaces
{
    public interface IProcessingCenterGateway
    {
        void Charge(decimal ticketPrice, PaymentDetails paymentDetails);
    }
}