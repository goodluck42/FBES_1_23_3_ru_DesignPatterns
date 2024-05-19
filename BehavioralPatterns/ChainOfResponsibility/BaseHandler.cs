namespace BehavioralPatterns.ChainOfResponsibility;

public abstract class BaseHandler<T> : IHandler<T>
    where T : class
{
    public IHandler<T>? Next { get; set; }

    public abstract void Handle(T data);
}