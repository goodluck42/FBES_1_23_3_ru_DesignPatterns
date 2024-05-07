namespace CreationalPatterns.Singleton;

public interface ISingletonLogger
{
    static abstract ISingletonLogger Instance { get; }
    void Log(string message);
}

public class SingletonLogger : ISingletonLogger
{
    protected const string Path = "logs.txt";
    
    protected SingletonLogger()
    {
        
    }

    public virtual void Log(string message)
    {
        File.WriteAllText(Path, message);
    }
    
    private static SingletonLogger? _instance;

    public static ISingletonLogger Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new();
            }

            return _instance;
        }
    }
}