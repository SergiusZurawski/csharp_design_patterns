namespace csharp_design_patterns.behavioural.command.implementation;
public class Invoker
{
    private ICommand _onOpen;
    private ICommand _onWrite;
    private ICommand _onSave;

    public void SetOnOpenCommand(ICommand command) => _onOpen = command;
    public void SetOnWriteCommand(ICommand command) => _onWrite = command;
    public void SetOnSaveCommand(ICommand command) => _onSave = command;

    public void Open()
    {
        _onOpen.Execute();
    }

    public void Write()
    {
        _onWrite.Execute();
    }

    public void Save()
    {
        _onSave.Execute();
    }
}



