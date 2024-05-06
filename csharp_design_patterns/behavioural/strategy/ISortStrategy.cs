namespace csharp_design_patterns.behavioural.strategy;


/*
 Key Concepts of the Strategy Pattern:
   Strategy Interface: This defines a common interface for all supported algorithms. Any algorithm that implements this interface can be used interchangeably by the client.
   Concrete Strategies: These are actual implementations of the strategy interface, representing specific algorithms or behaviors.
   Context: This is the class that uses the strategy. The context object contains a reference to a strategy object and might define an interface to allow the strategy to access its data.
   
   Benefits:
   Flexibility: It provides a way to configure a class with one of many behaviors.
   Separation of Concerns: It separates the implementation details of an algorithm from the code that uses it.
   Ease of Switching Strategy: Algorithms can be switched out easily at runtime.
   Simplifies Unit Testing: Each strategy can be tested separately from the client.
 
 */
public interface ISortStrategy
{
    List<int> Sort(List<int> dataset);
}
