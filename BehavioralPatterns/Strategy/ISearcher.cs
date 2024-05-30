namespace BehavioralPatterns.Strategy;

public interface ISearcher
{
    int Find<T>(T[] array, T toFind);
    ISearchStrategy Strategy { get; set; }
}