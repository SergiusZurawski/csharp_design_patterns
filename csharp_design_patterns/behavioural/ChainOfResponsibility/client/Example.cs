using csharp_design_patterns.behavioural.ChainOfResponsibility.implementation;

namespace csharp_design_patterns.behavioural.ChainOfResponsibility.client;

public static class Example
{
    public static void ExecuteExample()
    {
        ILogger errorLogger = new ErrorLogger();
        ILogger infoLogger = new InfoLogger();
        ILogger debugLogger = new DebugLogger();

        debugLogger.SetNext(infoLogger);
        infoLogger.SetNext(errorLogger);

        var messages = new List<Message>
        {
            new Message("This is an information.", LogLevel.Info),
            new Message("This is a debug message.", LogLevel.Debug),
            new Message("This is an error!", LogLevel.Error)
        };

        foreach (var message in messages)
        {
            debugLogger.Log(message);
        }
    }

}