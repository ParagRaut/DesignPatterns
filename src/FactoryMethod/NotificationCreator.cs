namespace FactoryMethod;

public abstract class NotificationCreator
{
    // The factory method — subclasses decide which notification to create
    public abstract INotification CreateNotification();

    public void Notify(string recipient, string message)
    {
        var notification = CreateNotification();
        notification.Send(recipient, message);
    }
}
