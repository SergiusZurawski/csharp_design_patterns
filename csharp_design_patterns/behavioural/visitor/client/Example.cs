
using csharp_design_patterns.behavioural.strategy.implementaion;
using csharp_design_patterns.behavioural.visitor.implementaion;
using csharp_design_patterns.behavioural.visitor.implementation;

namespace csharp_design_patterns.behavioural.visitor.client;

public static class Example
{
    public static void ExecuteExample()
    {
        // Create a list of elements
        List<IElement> elements = new List<IElement>
        {
            new ElementA(),
            new ElementB()
        };

        // Create a visitor
        IVisitor visitor = new ConcreteVisitor();

        // Iterate over elements and accept visitor
        foreach (IElement element in elements)
        {
            element.Accept(visitor);
        }
    }

}