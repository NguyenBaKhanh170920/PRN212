using System.Collections;

public class MyCollection<T> : IEnumerable where T : class, new()

{
    private List<T> list = new List<T>();
    public void AddItems(params T[] items) => list.AddRange(items);
    IEnumerator IEnumerable.GetEnumerator() => list.GetEnumerator();

}