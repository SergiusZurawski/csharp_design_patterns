namespace csharp_design_patterns.behavioural.state.client;

public static class Example
{
    public static void ExecuteExample()
    {
        Document doc = new Document();
        doc.Approve(); // Changes state to ApprovedState
        doc.Reject();  // Since it's approved, it cannot be rejected
    }

}