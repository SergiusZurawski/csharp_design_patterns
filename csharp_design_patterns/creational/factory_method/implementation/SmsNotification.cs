namespace csharp_design_patterns.creational.factory_method.implementation;

public class SmsNotification : INotification
{
    public void Notify(string message)
    {
        Console.WriteLine($"Sending SMS Notification: {message}");
    }
}