using csharp_design_patterns.behavioural.momento;

namespace csharp_design_patterns.behavioural.mediator.client;

public static class Example
{
    public static void ExecuteExample()
    {
        var chatRoom = new ChatRoom();

        var john = new Participant("1", "John");
        var jane = new Participant("2", "Jane");

        chatRoom.AddParticipant(john);
        chatRoom.AddParticipant(jane);

        john.Send("Hi Jane!");
        jane.Send("Hey John, how are you?");

    }

}