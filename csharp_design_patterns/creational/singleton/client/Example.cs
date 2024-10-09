using csharp_design_patterns.creational.singleton.implementation;

namespace csharp_design_patterns.creational.singleton.client;



/*
  
 he Singleton Pattern is a creational design pattern that ensures a class has only one instance throughout the application and provides a global point of access to that instance. This pattern is useful when exactly one object is needed to coordinate actions across the system.

When to Use the Singleton Pattern
Resource Management: When managing shared resources such as configuration settings, logging mechanisms, thread pools, or database connections.
Global Access Point: When a single point of access to certain resources or services is required.
Control Access to a Shared Resource: To prevent concurrent access issues by ensuring that only one instance interacts with the resource.
Components of the Singleton Pattern
Singleton Class: The class that ensures only one instance is created and provides a global access point to it.
Private Constructor: Restricts instantiation of the class from other classes.
Static Instance: Holds the single instance of the class.
Public Static Method or Property: Provides global access to the instance.
  
 */
public static class Example
{
    public static void ExecuteExample()
    {
        Logger logger1 = Logger.Instance;
        Logger logger2 = Logger.Instance;

        logger1.Log("First message");
        logger2.Log("Second message");

        // Check if both instances are the same
        Console.WriteLine($"Are logger1 and logger2 the same instance? {logger1 == logger2}");

    }

}