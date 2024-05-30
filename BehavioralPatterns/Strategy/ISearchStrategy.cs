namespace BehavioralPatterns.Strategy;

public interface ISearchStrategy
{
    int FindInArray<T>(T[] array, T toFind);
}