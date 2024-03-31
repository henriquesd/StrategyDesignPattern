using StrategyDesignPattern;
using StrategyDesignPattern.PaymentMethods;

Example();
Console.WriteLine();
ExampleWithSetStrategy();
Console.WriteLine();

// In the example below, each payment method is associated with a new instance of PaymentContext.
// For each payment method, a new PaymentContext object is created with the corresponding payment strategy.
// This approach creates a separate context for each payment, ensuring that each payment is processed independently with its associated strategy.
static void Example()
{
    PaymentContext paymentContext;
    double amount = 100.0;

    paymentContext = new PaymentContext(new CreditCardPayment());
    paymentContext.ProcessPayment(amount);

    paymentContext = new PaymentContext(new PayPalPayment());
    paymentContext.ProcessPayment(amount);

    paymentContext = new PaymentContext(new BitcoinPayment());
    paymentContext.ProcessPayment(amount);

    // Output:
    // Processing Credit Card payment of 100 euros.
    // Processing PayPal payment of 100 euros.
    // Processing Bitcoin payment of 100 euros.
}

// In the example below, a single PaymentContext object is reused for processing multiple payment methods.
// The SetStrategy method is used to change the payment strategy dynamically for each payment method.
// This approach allows for more flexibility in switching between payment methods without creating new context objects for each payment.
static void ExampleWithSetStrategy()
{
    PaymentContext paymentContext;
    double amount = 100.0;

    paymentContext = new PaymentContext(new CreditCardPayment());
    paymentContext.ProcessPayment(amount);

    paymentContext.SetStrategy(new PayPalPayment());
    paymentContext.ProcessPayment(amount);

    paymentContext.SetStrategy(new BitcoinPayment());
    paymentContext.ProcessPayment(amount);

    // Output:
    // Processing Credit Card payment of 100 euros.
    // Processing PayPal payment of 100 euros.
    // Processing Bitcoin payment of 100 euros.
}