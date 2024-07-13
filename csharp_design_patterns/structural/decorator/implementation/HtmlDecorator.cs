namespace csharp_design_patterns.structural.decorator.implementation;

public class HtmlDecorator : MessageDecorator
{
    public HtmlDecorator(IMessage message) : base(message)
    {
    }

    public override string GetContent()
    {
        return $"<html>{base.GetContent()}</html>";
    }
}

public class Base64Decorator : MessageDecorator
{
    public Base64Decorator(IMessage message) : base(message)
    {
    }

    public override string GetContent()
    {
        var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(base.GetContent());
        return System.Convert.ToBase64String(plainTextBytes);
    }
}
