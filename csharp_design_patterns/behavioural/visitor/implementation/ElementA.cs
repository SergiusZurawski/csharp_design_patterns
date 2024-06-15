namespace csharp_design_patterns.behavioural.visitor.implementation;
// Define an interface for elements that can be visited
// Concrete element class A
public class ElementA : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public void OperationA()
    {
        Console.WriteLine("Operation A");
    }
}