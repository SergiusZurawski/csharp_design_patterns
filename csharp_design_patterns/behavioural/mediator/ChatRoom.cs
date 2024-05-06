namespace csharp_design_patterns.behavioural.mediator;

public class ChatRoom : IChatRoomMediator
{
    private Dictionary<string, Participant> _participants = new Dictionary<string, Participant>();

    public void AddParticipant(Participant participant)
    {
        if (!_participants.ContainsKey(participant.Id))
        {
            _participants.Add(participant.Id, participant);
        }
        participant.ChatRoom = this;
    }

    public void SendMessage(string message, string userId)
    {
        if (_participants.ContainsKey(userId))
        {
            _participants[userId].Receive(message);
        }
    }
}

