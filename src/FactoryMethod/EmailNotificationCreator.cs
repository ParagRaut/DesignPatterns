namespace FactoryMethod;

public class EmailNotificationCreator : NotificationCreator
{
    public override INotification CreateNotification() => new EmailNotification();
}
