using csharp_design_patterns.creational.prototype.implementation;

namespace csharp_design_patterns.creational.prototype.client;



/*
  The Prototype Pattern is a creational design pattern that allows cloning objects, even complex ones, without coupling to their specific classes.
   It enables you to create new objects by copying or cloning existing instances,
    which can be more efficient than creating new instances from scratch, especially for resource-intensive objects.

This pattern is particularly useful when the cost of creating a new object is high, and you need to create multiple instances of an object with similar properties.

When to Use the Prototype Pattern
Resource-Intensive Object Creation: When creating a new object is costly in terms of time or resources.
Dynamic Object Creation: When you need to create objects at runtime without specifying their exact types.
Avoiding Subclassing: When you want to avoid creating a factory hierarchy or subclasses to create new objects.
Configurable Objects: When objects need to be configured before use, and you want to avoid repeating the configuration.
Components of the Prototype Pattern
Prototype Interface: Declares a Clone() method for cloning itself.
Concrete Prototype: Implements the Clone() method to create a copy of itself.
Client: Creates new objects by cloning existing prototypes

Explanation
IShape Interface: Defines the Clone() method for cloning shapes and GetInfo() for displaying information.
Circle and Rectangle Classes: Implement the IShape interface and provide concrete implementations of the Clone() method.
Cloning: Each class's Clone() method creates a new instance with the same property values.
In the Program class, we create original shapes (circle1, rectangle1) and then create clones (circle2, rectangle2). Modifications to the clones do not affect the original objects, demonstrating that a separate copy has been made.

Deep Copy vs. Shallow Copy
Shallow Copy: Copies the object's references, so changes to the cloned object's reference-type properties affect the original object.
Deep Copy: Creates a new object and recursively copies all reference-type properties, ensuring changes to the clone do not affect the original.
In the initial example, since we are dealing with value types (int), the default copy acts as a deep copy.
 
  
 */
public static class Example
{
    public static void ExecuteExample()
    {
        // Create original objects
        Circle circle1 = new Circle(5);
        Rectangle rectangle1 = new Rectangle(10, 20);

        // Clone the objects
        Circle circle2 = (Circle)circle1.Clone();
        Rectangle rectangle2 = (Rectangle)rectangle1.Clone();

        // Modify the cloned objects
        circle2.Radius = 10;
        rectangle2.Width = 15;

        // Display information
        circle1.GetInfo(); // This is a circle with radius 5.
        circle2.GetInfo(); // This is a circle with radius 10.

        rectangle1.GetInfo(); // This is a rectangle with width 10 and height 20.
        rectangle2.GetInfo(); // This is a rectangle with width 15 and height 20.
        
    }

}