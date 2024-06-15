namespace csharp_design_patterns.behavioural.visitor;
/*
 Visitor Pattern Structure
   The Visitor pattern involves several key components:
   
   Visitor Interface: This defines a visit operation for each type of concrete element in the object structure.
   Concrete Visitor: Implements each visit operation declared by the visitor interface. Each operation typically contains the logic required to perform the operation on the corresponding object.
   Element Interface: Defines an accept method that takes a visitor object as an argument.
   Concrete Element: Implements the accept method defined by the element interface. This method simply calls the visit method on the visitor object with this as its parameter.
   Object Structure: A collection or composite of elements that can enumerate its elements and provide a high-level interface to allow the visitor to visit its elements.
 
 */
public interface IShapeVisitor
{
    void Visit(Circle circle);
    void Visit(Rectangle rectangle);
}