// See https://aka.ms/new-console-template for more information
internal class Student
{
    public string Id { get; set; }
    public string Name { get; set; }
    public float Marks { get; set; }
    public Student(string id, string name, float marks)
    {
        Id = id;
        Name = name;
        Marks = marks;
    }
    public Student() { }
    public override string ToString()
    {
        return Id + "-" + Name + "-" + Marks;
    }
}