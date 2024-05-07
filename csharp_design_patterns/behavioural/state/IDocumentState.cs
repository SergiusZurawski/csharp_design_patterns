namespace csharp_design_patterns.behavioural.state;
public interface IDocumentState
{
    void Approve(Document document);
    void Reject(Document document);
}

