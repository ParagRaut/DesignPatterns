namespace FactoryMethod;

public class SmsNotificationCreator : NotificationCreator
{
    public override INotification CreateNotification() => new SmsNotification();
}
