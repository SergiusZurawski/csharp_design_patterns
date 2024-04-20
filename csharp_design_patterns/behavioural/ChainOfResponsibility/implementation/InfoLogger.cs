namespace csharp_design_patterns.behavioural.ChainOfResponsibility.implementation;

public class InfoLogger : ILogger
{
    private ILogger _nextLogger;

    public void SetNext(ILogger nextLogger)
    {
        _nextLogger = nextLogger;
    }

    public void Log(Message message)
    {
        if (message.Severity == LogLevel.Info)
        {
            Console.WriteLine($"Info: {message.Text}");
        }
        else
        {
            _nextLogger?.Log(message);
        }
    }
}