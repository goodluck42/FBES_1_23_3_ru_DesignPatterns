namespace BehavioralPatterns.ChainOfResponsibility;

public interface IHandler<T>
    where T : class
{
    IHandler<T>? Next { get; set; }
    void Handle(T data);
}