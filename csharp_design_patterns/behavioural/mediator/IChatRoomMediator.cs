
namespace csharp_design_patterns.behavioural.mediator;



public interface IChatRoomMediator
{
    void SendMessage(string message, string userId);
    void AddParticipant(Participant participant);
}

