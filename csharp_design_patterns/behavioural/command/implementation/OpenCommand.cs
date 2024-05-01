namespace csharp_design_patterns.behavioural.command.implementation;

public class OpenCommand : ICommand
{
    private readonly IReceiver _receiver;

    public OpenCommand(IReceiver receiver)
    {
        _receiver = receiver;
    }

    public void Execute()
    {
        _receiver.OpenFile();
    }
}

public class WriteCommand : ICommand
{
    private readonly IReceiver _receiver;

    public WriteCommand(IReceiver receiver)
    {
        _receiver = receiver;
    }

    public void Execute()
    {
        _receiver.WriteFile();
    }
}

public class SaveCommand : ICommand
{
    private readonly IReceiver _receiver;

    public SaveCommand(IReceiver receiver)
    {
        _receiver = receiver;
    }

    public void Execute()
    {
        _receiver.SaveFile();
    }
}

