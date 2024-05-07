namespace csharp_design_patterns.behavioural.state;

public class NewState : IDocumentState
{
    public void Approve(Document document)
    {
        Console.WriteLine("Document approved.");
        document.State = new ApprovedState();
    }

    public void Reject(Document document)
    {
        Console.WriteLine("Document rejected.");
        document.State = new RejectedState();
    }
}

public class ApprovedState : IDocumentState
{
    public void Approve(Document document)
    {
        Console.WriteLine("Document is already approved.");
    }

    public void Reject(Document document)
    {
        Console.WriteLine("Approved document cannot be rejected.");
    }
}

public class RejectedState : IDocumentState
{
    public void Approve(Document document)
    {
        Console.WriteLine("Rejected document cannot be approved directly.");
    }

    public void Reject(Document document)
    {
        Console.WriteLine("Document is already rejected.");
    }
}
