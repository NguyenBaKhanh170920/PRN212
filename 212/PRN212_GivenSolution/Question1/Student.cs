using static Student;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Dob {  get; set; }
    public string Major {  get; set; }
    public Student(int id, string name, DateTime dob, string major)
    {
        Id = id;
        Name = name;
        Dob = dob;
        Major = major;
    }
    public delegate void Presentation<T>(T item);
    public override string ToString()
    {
        return "Student: "+Id+" - "+Name+" - "+Dob.ToShortDateString()+" - "+Major;
    }
}