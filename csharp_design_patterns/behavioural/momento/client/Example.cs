namespace csharp_design_patterns.behavioural.momento.client;

public static class Example
{
    public static void ExecuteExample()
    {
        var editor = new Editor();
        var caretaker = new Caretaker();

        editor.SetContent("First sentence.");
        caretaker.SaveState(editor);  // Save state

        editor.SetContent("Second sentence.");
        caretaker.SaveState(editor);  // Save state

        editor.SetContent("Third sentence.");

        // Restore to the previous saved state
        caretaker.RestoreState(editor);
        Console.WriteLine(editor.GetContent());  // Outputs: Second sentence.

        caretaker.RestoreState(editor);
        Console.WriteLine(editor.GetContent());  // Outputs: First sentence.

        caretaker.RestoreState(editor);
        Console.WriteLine(editor.GetContent());
    }

}