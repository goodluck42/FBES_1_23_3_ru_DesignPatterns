namespace BehavioralPatterns.Mediator;

public interface IChatService
{
    void Send(string message);
    void Join(string userName);
    IEnumerable<string> GetMessages();
}