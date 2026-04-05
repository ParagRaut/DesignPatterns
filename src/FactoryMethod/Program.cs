using FactoryMethod;

// Client code works with creators — never directly creates notifications
NotificationCreator[] creators =
[
    new EmailNotificationCreator(),
    new SmsNotificationCreator(),
    new PushNotificationCreator()
];

foreach (var creator in creators)
{
    creator.Notify("Parag", "Your order has been shipped!");
}
