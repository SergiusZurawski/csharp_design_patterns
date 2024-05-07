namespace csharp_design_patterns.behavioural.state;

public class Document
{
    public IDocumentState State { get; set; }

    public Document()
    {
        // Initial state
        State = new NewState();
    }

    public void Approve()
    {
        State.Approve(this);
    }

    public void Reject()
    {
        State.Reject(this);
    }
}
