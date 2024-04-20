namespace csharp_design_patterns.behavioural.ChainOfResponsibility;

/*
 The Chain of Responsibility pattern is a behavioral design pattern that allows 
    an object to pass the request along the chain of potential handlers until one 
    of them handles the request. In C#, this can be implemented using interfaces 
    or abstract classes.
    
    Pros of Chain of Responsibility Pattern
   Decoupling of Sender and Receiver: The sender of a request does not need to know about the specific handler that will process the request. This decoupling allows for greater flexibility and scalability in code architecture.
   Flexibility in Assigning Responsibilities: Handlers can be added or changed dynamically without altering the sender of requests. This makes it easy to modify or extend the chain during runtime or maintenance phases.
   Enhanced Separation of Concerns: Each handler focuses solely on its specific handling criteria, adhering to the single responsibility principle. This separation helps keep the system organized, easier to understand, and maintain.
   Dynamic Reconfiguration: The chain can be restructured or expanded without changes to the existing code base. New handlers can be introduced and the order of existing handlers can be altered as needed.
   Conditional Handling: Allows for conditional continuation, meaning a request can be processed by multiple handlers in the chain, which is particularly useful in processing workflows or validation sequences.
   
   Cons of Chain of Responsibility Pattern
   Performance Considerations: If the chain is very long or the process of determining the correct handler is complex, it can lead to a performance hit. Each request might have to go through multiple handlers before being processed, increasing latency.
   Risk of Unhandled Requests: If there's no default handler and a request does not meet any criteria, it might end up unhandled, which can lead to bugs that are difficult to trace.
   Debugging Difficulty: Debugging can be more challenging because the control of the request flows through multiple handlers, making it harder to track where things might be going wrong.
   Complexity in Maintenance: Understanding and maintaining a chain can become complex especially if the chain is dynamic and altered frequently. New developers or maintainers might find it difficult to grasp the flow and interaction between handlers.
   Overhead in Setup: Setting up a useful chain of responsibility pattern requires careful planning to ensure that all potential conditions are considered and that handlers are triggered in the correct sequence. Mistakes in setup can lead to inefficient processing and errors.
   
   Conclusion
   The Chain of Responsibility pattern is powerful for scenarios requiring a flexible and dynamic approach to handling requests, where the exact handler may not be known at compile time or might change based on runtime conditions. 
   However, the use of this pattern should be weighed against potential issues such as performance overhead and maintenance complexity. It is most beneficial when the advantages of handler decoupling and dynamic reconfiguration outweigh these drawbacks.
  
 */
public interface ILogger
{
    void SetNext(ILogger nextLogger);
    void Log(Message message);
}