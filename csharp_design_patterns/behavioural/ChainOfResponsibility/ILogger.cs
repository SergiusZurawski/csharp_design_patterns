namespace csharp_design_patterns.behavioural.ChainOfResponsibility;

/*
 The Chain of Responsibility pattern is a behavioral design pattern that allows 
    an object to pass the request along the chain of potential handlers until one 
    of them handles the request. In C#, this can be implemented using interfaces 
    or abstract classes.
  
 */
public interface ILogger
{
    void SetNext(ILogger nextLogger);
    void Log(Message message);
}