namespace StrategyDesignPattern
{
    public class PaymentContext
    {
        private IPaymentStrategy _payment;

        public PaymentContext(IPaymentStrategy payment)
        {
            _payment = payment;
        }

        public void ProcessPayment(double amount)
        {
            _payment.ProcessPayment(amount);
        }

        /// <summary>
        /// This method allows you to switch between payment methods dynamically at runtime (based on user input or other runtime conditions for example),
        /// without creating new PaymentContext instances.
        /// </summary>
        /// <param name="payment"></param>
        public void SetStrategy(IPaymentStrategy payment)
        {
            _payment = payment;
        }
    }
}