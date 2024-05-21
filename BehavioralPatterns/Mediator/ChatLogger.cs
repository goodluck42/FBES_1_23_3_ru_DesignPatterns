namespace BehavioralPatterns.Mediator;

public class ChatLogger : ChatComponent
{
    private const string FileName = "chatlog.txt";

    public ChatLogger(IChatMediator mediator) : base(mediator)
    {
    }

    public void Log(string logMessage)
    {
        logMessage = $"{DateTime.Now}: {logMessage}";

        File.AppendAllText(FileName, logMessage);

        Mediator.Notify(this, logMessage);
    }
}