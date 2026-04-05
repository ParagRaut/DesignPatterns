namespace FactoryMethod;

public class EmailNotification : INotification
{
    public void Send(string recipient, string message)
    {
        Console.WriteLine($"[Email] To: {recipient} — {message}");
    }
}
