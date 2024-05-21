namespace BehavioralPatterns.Mediator;

public class ChatMediator : IChatMediator
{
    public ChatService? ChatService { get; set; }
    public ChatLogger? ChatLogger { get; set; }
    public ChatThemeChanger? ChatThemeChanger { get; set; }

    public void Notify(object sender, object data)
    {
        if (sender is ChatService)
        {
            LogChatMessage(data);
        }

        if (sender is ChatThemeChanger)
        {
            LogChatTheme(data);
        }
    }

    public void LogChatMessage(object message) // ReactOnA
    {
        ChatLogger?.Log((string)message);
    }

    public void LogChatTheme(object isDark) // ReactOnB
    {
        ChatLogger?.Log($"Current theme: {((bool)isDark ? "Dark" : "Light")}");
    }
}