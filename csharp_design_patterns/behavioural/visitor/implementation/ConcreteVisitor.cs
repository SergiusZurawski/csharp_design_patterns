using csharp_design_patterns.behavioural.visitor.implementaion;

namespace csharp_design_patterns.behavioural.visitor.implementation;

public class ConcreteVisitor : IVisitor
{
    public void Visit(ElementA element)
    {
        element.OperationA();
        Console.WriteLine("Visited Element A");
    }

    public void Visit(ElementB element)
    {
        element.OperationB();
        Console.WriteLine("Visited Element B");
    }
}