namespace BehavioralPatterns.Strategy;

public class LinearSearchStrategy : ISearchStrategy
{
    public int FindInArray<T>(T[] array, T toFind)
    {
        return Array.FindIndex(array, obj => EqualityComparer<T>.Default.Equals(toFind, obj));
    }
}