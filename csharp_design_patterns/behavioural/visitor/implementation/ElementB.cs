namespace csharp_design_patterns.behavioural.visitor.implementaion;
// Define an interface for elements that can be visited
// Concrete element class A
// Concrete element class B
public class ElementB : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public void OperationB()
    {
        Console.WriteLine("Operation B");
    }
}