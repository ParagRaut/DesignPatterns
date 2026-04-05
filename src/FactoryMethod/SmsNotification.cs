namespace FactoryMethod;

public class SmsNotification : INotification
{
    public void Send(string recipient, string message)
    {
        Console.WriteLine($"[SMS] To: {recipient} — {message}");
    }
}
