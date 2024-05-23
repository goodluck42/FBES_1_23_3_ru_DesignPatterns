namespace BehavioralPatterns.ObjectPool;

public class ObjectPool<T> : IObjectPool<T>
    where T : IResettable, new()
{
    public const int DefaultCapacity = 15;
    private Queue<T> _objects;

    public ObjectPool() : this(DefaultCapacity)
    {
    }

    public ObjectPool(int maxCapacity)
    {
        _objects = new(maxCapacity);
    }

    public T Get()
    {
        if (_objects.Count == 0)
        {
            Console.WriteLine("New object created...");
            return new T();
        }

        Console.WriteLine("Got object from pool...");
        
        return _objects.Dequeue();
    }

    public void Return(T @object)
    {
        _objects.Enqueue(@object);
        @object.Reset();

        Console.WriteLine("Object returned...");
    }
}