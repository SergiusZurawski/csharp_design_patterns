using csharp_design_patterns.behavioural.visitor.implementaion;
using csharp_design_patterns.behavioural.visitor.implementation;

namespace csharp_design_patterns.behavioural.visitor;
// Define an interface for elements that can be visited
public interface IElement
{
    void Accept(IVisitor visitor);
}