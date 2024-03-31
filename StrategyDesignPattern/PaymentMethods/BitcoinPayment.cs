namespace StrategyDesignPattern.PaymentMethods
{
    public class BitcoinPayment : IPaymentStrategy
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing Bitcoin payment of {amount} euros.");
        }
    }
}