using Adapter;

// Our app works with IPaymentGateway — it doesn't care about the implementation
IPaymentGateway[] gateways =
[
    new ModernPaymentGateway(),
    new LegacyPaymentAdapter(new LegacyPaymentService())
];

foreach (var gateway in gateways)
{
    Console.WriteLine($"Using: {gateway.GetType().Name}");
    gateway.ProcessPayment("parag@example.com", 49.99m, "USD");
    Console.WriteLine();
}
