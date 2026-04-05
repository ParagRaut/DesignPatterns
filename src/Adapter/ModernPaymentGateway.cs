namespace Adapter;

public class ModernPaymentGateway : IPaymentGateway
{
    public void ProcessPayment(string customerEmail, decimal amount, string currency)
    {
        Console.WriteLine($"  [Modern] Charged {amount} {currency} to {customerEmail}");
    }
}
