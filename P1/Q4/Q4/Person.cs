internal class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
    public Person() { }
    public Person(int age, string name)
    {
        Age = age;
        Name = name;
    }
    public override string ToString()
    {
        return "Name: " + Name + ", Age: " + Age;
    }
}