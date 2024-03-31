namespace StrategyDesignPattern
{
    public interface IPaymentStrategy
    {
        void ProcessPayment(double amount);
    }
}