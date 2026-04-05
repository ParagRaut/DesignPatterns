namespace FactoryMethod;

public class PushNotificationCreator : NotificationCreator
{
    public override INotification CreateNotification() => new PushNotification();
}
