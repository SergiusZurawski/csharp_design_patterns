namespace csharp_design_patterns.creational.factory_method.implementation;

public class EmailNotification : INotification
{
    public void Notify(string message)
    {
        Console.WriteLine($"Sending Email Notification: {message}");
    }
}