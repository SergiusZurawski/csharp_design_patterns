namespace csharp_design_patterns.behavioural.ChainOfResponsibility;

public class Message
{
    public string Text { get; set; }
    public LogLevel Severity { get; set; }

    public Message(string text, LogLevel severity)
    {
        Text = text;
        Severity = severity;
    }
}