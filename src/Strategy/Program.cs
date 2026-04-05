using Strategy;

var processor = new PaymentProcessor(new CreditCardPayment("4111111111111234"));
processor.ProcessPayment(49.99m);

// Swap strategy at runtime — no code changes needed
processor.SetPaymentStrategy(new PayPalPayment("parag@example.com"));
processor.ProcessPayment(29.99m);

processor.SetPaymentStrategy(new CryptoPayment("0xABCDEF1234567890"));
processor.ProcessPayment(99.99m);
