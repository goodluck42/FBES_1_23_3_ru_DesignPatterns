using System.Collections;
using System.Collections.Specialized;

namespace BehavioralPatterns.Observer;

public class FixedObservableArray<T> : IEnumerable<T>, INotifyCollectionChanged
    where T : notnull
{
    private readonly T[] _items;
    private readonly int _capacity;
    private int _length;

    public FixedObservableArray(int capacity)
    {
        _capacity = capacity;
        _items = new T[capacity];
        _length = 0;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return new FixedObservableArrayEnumerator<T>(_items, _length);
    }

    public void Add(T item)
    {
        UnsafeAdd(item);

        CollectionChanged?.Invoke(this,
            new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, new T[] { item }));
    }

    private void UnsafeAdd(T item)
    {
        if (_length >= _capacity) throw new ArgumentOutOfRangeException(nameof(item), "Max capacity reached.");

        _items[_length++] = item;
    }
    
    public void AddRange(IEnumerable<T> items)
    {
        foreach (var item in items)
        {
            UnsafeAdd(item);
        }

        CollectionChanged?.Invoke(this,
            new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, items));
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public event NotifyCollectionChangedEventHandler? CollectionChanged;
}