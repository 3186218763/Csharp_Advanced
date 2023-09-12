using System.Collections;
namespace _17_yield和foreach使用和解析;

/// <summary>
/// 创建迭代器，实现IEnumerator的接口
/// </summary>
/// <typeparam name="T"></typeparam>
public class MyEnumerator<T> : IEnumerator<T>
{
    private List<T> items;
    private int position = -1;

    public MyEnumerator(List<T> items) { this.items = items; }
    public T Current
    {
        get { return items[position]; }
    }
    object IEnumerator.Current
    {
        get { return Current; }
    }

    public void Dispose()
    {
        
    }

    public bool MoveNext()
    {
        position++;
        return (position < items.Count);
    }

    public void Reset()
    {
        position = -1;
    }
}
//使用迭代器，实现IEnumerable接口，使自定义的类能使用foreach
public class MyCollection<T> : IEnumerable<T>
{
    private List<T> items = new List<T>();

    public void Add(T item) { items.Add(item); }
    public IEnumerator<T> GetEnumerator()
    {
        return new MyEnumerator<T>(items);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerable<T> Test_yield()
    {
        for (int i = 0; i < items.Count; i++)
        {
            yield return items[i];
        }
    }
}

