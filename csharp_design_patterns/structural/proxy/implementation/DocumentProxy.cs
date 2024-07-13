namespace csharp_design_patterns.structural.proxy.implementation;

public class DocumentProxy : IDocument
{
    private string _fileName;
    private RealDocument _realDocument;

    public DocumentProxy(string fileName)
    {
        _fileName = fileName;
    }

    public void DisplayContent()
    {
        if (_realDocument == null)
        {
            _realDocument = new RealDocument(_fileName);
        }
        _realDocument.DisplayContent();
    }
}
