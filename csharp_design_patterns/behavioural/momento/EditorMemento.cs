namespace csharp_design_patterns.behavioural.momento;

public class EditorMemento
{
    private string _content;

    public EditorMemento(string content)
    {
        _content = content;
    }

    public string GetContent()
    {
        return _content;
    }
}