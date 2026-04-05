namespace FactoryMethod;

public class PushNotification : INotification
{
    public void Send(string recipient, string message)
    {
        Console.WriteLine($"[Push] To: {recipient} — {message}");
    }
}
