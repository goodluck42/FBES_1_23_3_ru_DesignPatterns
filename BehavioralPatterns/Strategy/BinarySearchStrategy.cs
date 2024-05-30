namespace BehavioralPatterns.Strategy;

public class BinarySearchStrategy : ISearchStrategy
{
    public int FindInArray<T>(T[] array, T toFind)
    {
        return Array.BinarySearch(array, toFind);
    }
}