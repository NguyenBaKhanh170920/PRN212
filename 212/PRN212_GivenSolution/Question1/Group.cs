
using static Student;

public class Group<T>
{
    public string Name { get; set; }
    private List<T> _items;

    public Group(string name)
    {
        Name = name;
    }

    public void Add(T item)
    {
      //_items.Add(item);
    }

    internal void Show(Action<Student> displaysFullInfoOfStudent)
    {
        
    }

    internal void Remove(Student removeStudent)
    {
        throw new NotImplementedException();
    }
}