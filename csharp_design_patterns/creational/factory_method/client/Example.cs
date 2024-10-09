using csharp_design_patterns.creational.factory_method.implementation;

namespace csharp_design_patterns.creational.factory_method.client;



/*
  When to Use the Factory Method Pattern
Dynamic Object Creation: When a class cannot anticipate the type of objects it needs to create beforehand.
Single Responsibility Principle: To delegate object creation to helper classes.
Extensibility: When you want to enable adding new types without changing existing code.
Resource Management: To manage and reuse resources efficiently.

Components of the Factory Method Pattern
Product: An interface or abstract class defining the objects the factory method creates.
ConcreteProduct: Concrete implementations of the Product interface.
Creator: Abstract class or interface declaring the factory method.
ConcreteCreator: Subclasses that override the factory method to return instances of ConcreteProduct.
 
  
 */
public static class Example
{
    public static void ExecuteExample()
    {
        NotificationCreator creator;

        Console.WriteLine("Enter the type of notification you want to send (Email/SMS/Push):");
        string notificationType = Console.ReadLine();

        // Decide which creator to use based on user input
        switch (notificationType.ToLower())
        {
            case "email":
                creator = new EmailNotificationCreator();
                break;
            case "sms":
                creator = new SmsNotificationCreator();
                break;
            case "push":
                creator = new PushNotificationCreator();
                break;
            default:
                Console.WriteLine("Invalid notification type.");
                return;
        }

        creator.NotifyUser("Hello! This is a test notification.");
        
    }

}