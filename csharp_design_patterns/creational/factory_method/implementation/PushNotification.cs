namespace csharp_design_patterns.creational.factory_method.implementation;

public class PushNotification : INotification
{
    public void Notify(string message)
    {
        Console.WriteLine($"Sending Push Notification: {message}");
    }
}