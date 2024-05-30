namespace BehavioralPatterns.Strategy;

public class Searcher : ISearcher
{
    public Searcher()
    {
        Strategy = new LinearSearchStrategy();
    }

    public int Find<T>(T[] array, T toFind)
    {
        switch (array.Length)
        {
            case <= 100:
            {
                Strategy = new LinearSearchStrategy();
                
                break;
            }
            case > 100:
            {
                Strategy = new BinarySearchStrategy();
            
                Array.Sort(array);
                
                break;
            }
        }
        
        return Strategy.FindInArray(array, toFind);
    }

    public ISearchStrategy Strategy { get; set; }
}