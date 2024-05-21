namespace BehavioralPatterns.Mediator;

public class ChatThemeChanger : ChatComponent
{
    private bool _isDark;

    public ChatThemeChanger(IChatMediator mediator) : base(mediator)
    {
    }

    public void Toggle()
    {
        _isDark = !_isDark;

        Mediator.Notify(this, _isDark);
    }
}