using csharp_design_patterns.structural.decorator.implementation;

namespace csharp_design_patterns.structural.decorator.client;


/*
 The Decorator Design Pattern is a structural pattern that allows behavior to be added to individual objects, dynamically, without affecting the behavior of other objects from the same class. Decorators provide a flexible alternative to subclassing for extending functionality.
   
   Components of Decorator Design Pattern
   Component: An abstract class or interface that defines the interface for objects that can have responsibilities added to them dynamically.
   ConcreteComponent: A class that implements the Component interface.
   Decorator: An abstract class that implements the Component interface and contains a reference to a Component object.
   ConcreteDecorator: A class that extends the functionality of the component by adding additional responsibilities.
 
  
 */
public static class Example
{
    public static void ExecuteExample()
    {
        // Create a simple message
        IMessage message = new SimpleMessage("Hello, World!");

        // Decorate the message with HTML formatting
        IMessage htmlMessage = new HtmlDecorator(message);

        // Further decorate the HTML message with Base64 encoding
        IMessage base64HtmlMessage = new Base64Decorator(htmlMessage);

        // Display the original, HTML, and Base64+HTML messages
        Console.WriteLine("Original Message: " + message.GetContent());
        Console.WriteLine("HTML Message: " + htmlMessage.GetContent());
        Console.WriteLine("Base64 + HTML Message: " + base64HtmlMessage.GetContent());
    }

}