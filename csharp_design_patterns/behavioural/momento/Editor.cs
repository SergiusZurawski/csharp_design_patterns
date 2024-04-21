namespace csharp_design_patterns.behavioural.momento;

public class Editor
{
    private string _content = "";

    public void SetContent(string content)
    {
        _content = content;
    }

    public string GetContent()
    {
        return _content;
    }

    public EditorMemento Save()
    {
        return new EditorMemento(_content);
    }

    public void Restore(EditorMemento memento)
    {
        _content = memento.GetContent();
    }
}