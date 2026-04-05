namespace Strategy;

public class CryptoPayment : IPaymentStrategy
{
    private readonly string _walletAddress;

    public CryptoPayment(string walletAddress)
    {
        _walletAddress = walletAddress;
    }

    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount:C} using Crypto wallet {_walletAddress[..8]}...");
    }
}
