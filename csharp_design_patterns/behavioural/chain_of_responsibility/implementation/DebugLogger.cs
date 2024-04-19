namespace csharp_design_patterns.behavioural.chain_of_responsibility.implementation;

public class DebugLogger : ILogger
{
    private ILogger _nextLogger;

    public void SetNext(ILogger nextLogger)
    {
        _nextLogger = nextLogger;
    }

    public void Log(Message message)
    {
        if (message.Severity == LogLevel.Debug)
        {
            Console.WriteLine($"Debug: {message.Text}");
        }
        else
        {
            _nextLogger?.Log(message);
        }
    }
}