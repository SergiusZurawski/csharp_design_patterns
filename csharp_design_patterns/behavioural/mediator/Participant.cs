namespace csharp_design_patterns.behavioural.mediator;

public class Participant
{
    public string Id { get; private set; }
    public string Name { get; private set; }
    public IChatRoomMediator ChatRoom { get; set; }

    public Participant(string id, string name)
    {
        Id = id;
        Name = name;
    }

    public void Send(string message)
    {
        ChatRoom.SendMessage(message, Id);
    }

    public void Receive(string message)
    {
        Console.WriteLine($"{Name} received message: {message}");
    }
}
