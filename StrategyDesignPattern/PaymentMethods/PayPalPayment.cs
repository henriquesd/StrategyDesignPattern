namespace StrategyDesignPattern.PaymentMethods
{
    public class PayPalPayment : IPaymentStrategy
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount} euros.");
        }
    }
}