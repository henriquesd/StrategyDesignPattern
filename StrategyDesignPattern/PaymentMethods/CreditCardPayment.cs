namespace StrategyDesignPattern.PaymentMethods
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing Credit Card payment of {amount} euros.");
        }
    }
}