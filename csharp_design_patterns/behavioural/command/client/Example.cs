using csharp_design_patterns.behavioural.command.implementation;

namespace csharp_design_patterns.behavioural.command.client;

public static class Example
{
    public static void ExecuteExample()
    {
        var receiver = new FileReceiver();
        var openCmd = new OpenCommand(receiver);
        var writeCmd = new WriteCommand(receiver);
        var saveCmd = new SaveCommand(receiver);

        var invoker = new Invoker();
        invoker.SetOnOpenCommand(openCmd);
        invoker.SetOnWriteCommand(writeCmd);
        invoker.SetOnSaveCommand(saveCmd);

        invoker.Open();
        invoker.Write();
        invoker.Save();
    }

}