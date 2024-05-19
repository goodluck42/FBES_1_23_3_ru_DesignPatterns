using System.Collections;

namespace BehavioralPatterns.Iterator;

public class FixedArrayEnumerator<T> : IEnumerator<T>
    where T : notnull
{
    private readonly T[] _items;
    private readonly int _length;
    private int _currentIndex;

    public FixedArrayEnumerator(T[] items, int length)
    {
        _items = items;
        _length = length;
        _currentIndex = -1;
    }
    public bool MoveNext()
    {
        if (_currentIndex == _length - 1)
        {
            return false;
        }

        _currentIndex += 1;

        return true;
    }
    
    public void Reset()
    {
        _currentIndex = -1;
    }

    public T Current => _items[_currentIndex];

    object IEnumerator.Current => Current;

    public void Dispose() { }
}