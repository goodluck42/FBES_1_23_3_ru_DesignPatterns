namespace BehavioralPatterns.Mediator;

public interface IChatMediator
{
    void Notify(object sender, object data);
}