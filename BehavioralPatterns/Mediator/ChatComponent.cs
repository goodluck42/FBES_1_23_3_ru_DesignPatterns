namespace BehavioralPatterns.Mediator;

public abstract class ChatComponent
{
    protected readonly IChatMediator Mediator;

    public ChatComponent(IChatMediator mediator)
    {
        Mediator = mediator;
    }
}