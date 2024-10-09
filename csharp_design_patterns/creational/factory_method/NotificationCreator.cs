namespace csharp_design_patterns.creational.factory_method;

public abstract class NotificationCreator
{
    // Factory Method
    public abstract INotification CreateNotification();

    // Common method that uses the product
    public void NotifyUser(string message)
    {
        var notification = CreateNotification();
        notification.Notify(message);
    }
}
