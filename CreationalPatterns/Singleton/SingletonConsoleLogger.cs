namespace CreationalPatterns.Singleton;

public sealed class SingletonConsoleLogger : ISingletonLogger
{
    private readonly SingletonLogger _logger;
    private static ISingletonLogger? _instance;

    public static ISingletonLogger Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new SingletonConsoleLogger((SingletonLogger.Instance as SingletonLogger)!);
            }

            return _instance;
        }
    }

    private SingletonConsoleLogger(SingletonLogger logger)
    {
        _logger = logger;
    }
    public void Log(string message)
    {
        _logger.Log(message);
        
        Console.WriteLine(message);
    }
}