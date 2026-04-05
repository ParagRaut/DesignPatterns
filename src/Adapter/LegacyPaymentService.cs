namespace Adapter;

// This is a third-party/legacy class we can't modify
// It has a completely different interface than what our app expects
public class LegacyPaymentService
{
    public void MakePayment(string xmlPayload)
    {
        Console.WriteLine($"  [Legacy] Processing XML payment: {xmlPayload}");
    }
}
