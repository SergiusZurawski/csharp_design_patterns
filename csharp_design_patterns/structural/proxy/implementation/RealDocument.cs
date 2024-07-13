namespace csharp_design_patterns.structural.proxy.implementation;

public class RealDocument : IDocument
{
    private string _fileName;

    public RealDocument(string fileName)
    {
        _fileName = fileName;
        LoadFile();
    }

    private void LoadFile()
    {
        Console.WriteLine($"Loading file {_fileName}...");
        // Simulate expensive file loading operation
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine($"File {_fileName} loaded.");
    }

    public void DisplayContent()
    {
        Console.WriteLine($"Displaying content of {_fileName}.");
    }
}
