namespace Adapter;

// The adapter wraps the legacy service and makes it conform to IPaymentGateway
public class LegacyPaymentAdapter : IPaymentGateway
{
    private readonly LegacyPaymentService _legacyService;

    public LegacyPaymentAdapter(LegacyPaymentService legacyService)
    {
        _legacyService = legacyService;
    }

    public void ProcessPayment(string customerEmail, decimal amount, string currency)
    {
        // Translate the modern interface into the legacy XML format
        var xml = $"<Payment><Email>{customerEmail}</Email><Amount>{amount}</Amount><Currency>{currency}</Currency></Payment>";
        _legacyService.MakePayment(xml);
    }
}
