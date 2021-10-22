namespace INET.Lab4.Abstracts
{
    public abstract class PaymentProcessor
    {
        public void ProcessTransaction()
        {
            WithdrawMoney();
            CalculateBonus();
            SendGreetings();
        }

        protected abstract void WithdrawMoney();
        protected abstract void CalculateBonus();
        protected abstract void SendGreetings();
    }
}
