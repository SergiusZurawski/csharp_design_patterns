namespace csharp_design_patterns.behavioural.command.implementation;

public class FileReceiver : IReceiver
{
    public void OpenFile()
    {
        Console.WriteLine("File opened.");
    }

    public void WriteFile()
    {
        Console.WriteLine("Writing to file.");
    }

    public void SaveFile()
    {
        Console.WriteLine("File saved.");
    }
}


