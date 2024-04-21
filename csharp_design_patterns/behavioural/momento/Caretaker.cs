namespace csharp_design_patterns.behavioural.momento;


/*
    The Memento pattern is a behavioral design pattern that allows an object to save its state so that it can be restored to this state later.
    This pattern is particularly useful in applications where you need to provide undo functionalities or save points.
    
    Pros of the Memento Pattern
   Encapsulation: The Memento pattern keeps the details about an object's state encapsulated. The object itself is responsible for creating a memento of its state, while other objects, such as the caretaker, can only use this memento to return to a previous state without knowing its internal structure.
   Undo or Rollback: It provides an easy mechanism for rolling back to an earlier state when needed. This is particularly useful in applications like text editors, graphic editors, or any kind of application that requires undo functionality.
   Preservation of Integrity: By saving the complete state into mementos, the integrity of the original object's state can be preserved. This is particularly important in complex systems where transitions between states need to be flawless and reversible.
   Decoupling State and Business Logic: The Memento pattern helps in separating the state management from the business logic of the application. The originator deals with the actual business logic, while the caretaker handles the state management independently.
   Cons of the Memento Pattern
   
   High Memory Usage: If the object's state is large or the number of saved states is high, the memory usage can become significant. Each memento may store a duplicate of the object's state, leading to high memory consumption.
   Complexity: Implementing the Memento pattern can increase the complexity of the code, especially in large applications where managing mementos might require additional care in handling lifecycle, storage, and restoration accurately.
   Performance Overhead: Creating and restoring from mementos may involve deep copying and serialization, which can be resource-intensive. This overhead can impact performance, especially if the state transitions are frequent and involve complex objects.
   Potential for Bugs: If not implemented correctly, the pattern can lead to bugs where the state is not restored correctly or the mementos are not managed properly (e.g., not being cleared from memory when no longer needed).
   State Exposure Risks: Even though mementos are supposed to encapsulate state, they can inadvertently expose state details if not handled properly. For instance, if direct references to mutable objects are stored in the memento, those objects can still be altered externally.
 
  
 */
public class Caretaker
{
    private Stack<EditorMemento> _mementos = new Stack<EditorMemento>();

    public void SaveState(Editor editor)
    {
        _mementos.Push(editor.Save());
    }

    public void RestoreState(Editor editor)
    {
        if (_mementos.Count > 0)
        {
            editor.Restore(_mementos.Pop());
        }
        else
        {
            Console.WriteLine("No earlier states to restore.");
        }
    }
}
