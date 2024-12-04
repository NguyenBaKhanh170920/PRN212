class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person(18, "A");
        Person p2 = new Person(18, "B");
        Person p3 = new Person(18, "C");
        Person p4 = new Person(18, "D");
        MyCollection<Person> myCollection = new MyCollection<Person>();
        myCollection.AddItems(p1, p2, p3, p4);

        Console.WriteLine("OUTPUT:");
        foreach (Person p in myCollection)
            Console.WriteLine(p);

        Console.ReadLine();
    }
}

