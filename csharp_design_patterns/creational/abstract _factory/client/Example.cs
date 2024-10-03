using csharp_design_patterns.creational.abstract__factory.implementation;

namespace csharp_design_patterns.creational.abstract__factory.client;



/*
  The Abstract Factory Pattern is a creational design pattern that provides an interface for creating families of 
related or dependent objects without specifying their concrete classes. It's a way to encapsulate a group of 
individual factories that have a common theme. In C#, this pattern is particularly useful when you need to ensure 
that your code works with various families of related products, without depending on their specific implementations.

 **Purpose:**
- **Encapsulation of Object Creation**: Separates the code that creates objects from the code that uses them.
- **Interchangeable Families**: Allows swapping of entire product families without modifying client code.
- **Consistency**: Ensures that products from the same family are used together, maintaining compatibility.

**Components:**
- **Abstract Factory**: Declares interfaces for creating abstract products.
- **Concrete Factory**: Implements creation methods for specific product families.
- **Abstract Product**: Declares an interface for a type of product.
- **Concrete Product**: Implements the Abstract Product interface.
- **Client**: Uses only interfaces declared by the Abstract Factory and Abstract Product classes.

  When to Use
When your system needs to be independent of how its objects are created.
When you have multiple families of products, and you want to provide a way to use them interchangeably.
When enforcing consistency among products is crucial.
 */
public static class Example
{
    public static void ExecuteExample()
    {
        IGUIFactory factory;
        Application app;

        string osType = GetOperatingSystemType();

        if (osType == "Windows")
        {
            factory = new WinFactory();
        }
        else if (osType == "Mac")
        {
            factory = new MacFactory();
        }
        else
        {
            throw new Exception("Error! Unknown operating system.");
        }

        app = new Application(factory);
        app.Paint();

        Console.ReadKey();
    }
    
    static string GetOperatingSystemType()
    {
        // Placeholder for OS detection logic
        return "Windows"; // For demonstration purposes
    }

}