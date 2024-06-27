using System.Collections;

namespace Semantica.Lib.Tests.Core.Test._Mocks;

public class TestEnumerator : IEnumerable<int>
{
    private readonly int[] _items;

    public TestEnumerator(IEnumerable<int> items)
    {
        _items = Enumerable.ToArray(items);
        EnumeratedItems = new List<int>();
    }

    public List<int> EnumeratedItems { get; }
    
    public IEnumerable<int> AsEnumerable => this;

    public IEnumerator<int> GetEnumerator()
    {
        foreach (var item in _items)
        {
            EnumeratedItems.Add(item);
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }            
}