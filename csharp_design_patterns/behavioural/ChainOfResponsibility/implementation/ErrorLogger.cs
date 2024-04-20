namespace csharp_design_patterns.behavioural.ChainOfResponsibility.implementation;

public class ErrorLogger : ILogger
{
    private ILogger _nextLogger;

    public void SetNext(ILogger nextLogger)
    {
        _nextLogger = nextLogger;
    }

    public void Log(Message message)
    {
        if (message.Severity == LogLevel.Error)
        {
            Console.WriteLine($"Error: {message.Text}");
        }
        else
        {
            _nextLogger?.Log(message);
        }
    }
}