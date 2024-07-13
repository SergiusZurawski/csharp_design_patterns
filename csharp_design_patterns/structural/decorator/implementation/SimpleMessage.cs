namespace csharp_design_patterns.structural.decorator.implementation;

public class SimpleMessage : IMessage
{
    private string _message;

    public SimpleMessage(string message)
    {
        _message = message;
    }

    public string GetContent()
    {
        return _message;
    }
    
}
