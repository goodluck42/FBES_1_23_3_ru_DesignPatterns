using System.Collections;

namespace BehavioralPatterns.Iterator;

public class FixedArray<T> : IEnumerable<T>
    where T : notnull
{
    private readonly T[] _items;
    private readonly int _capacity;
    private int _length;
    
    public FixedArray(int capacity)
    {
        _capacity = capacity;
        _items = new T[capacity];
        _length = 0;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return new FixedArrayEnumerator<T>(_items, _length);
    }

    public void Add(T item)
    {
        if (_length >= _capacity) throw new ArgumentOutOfRangeException(nameof(item), "Max capacity reached.");
        
        _items[_length++] = item;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}