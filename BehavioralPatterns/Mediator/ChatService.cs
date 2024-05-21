namespace BehavioralPatterns.Mediator;

public class ChatService : ChatComponent, IChatService
{
    private List<string> _messages = new();
    private List<string> _users = new();

    public ChatService(IChatMediator mediator) : base(mediator)
    {
    }

    public void Send(string message)
    {
        _messages.Add(message);

        Mediator.Notify(this, message);
    }

    public void Join(string userName)
    {
        if (!_users.Contains(userName))
        {
            _users.Add(userName);
        }
    }

    public IEnumerable<string> GetMessages()
    {
        return _messages;
    }
}