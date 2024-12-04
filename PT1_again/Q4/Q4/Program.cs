// See https://aka.ms/new-console-template for more information
using Q4;

class Program
{
    static void Main(string[] args)
    {
        int nS, i;
        Console.Write("Enter the number of students:");
        nS = int.Parse(Console.ReadLine());
        Student[] ls = new Student[nS];
        for (i = 0; i < nS; i++)
        {
            ls[i] = new Student();
            Console.Write("Enter name of student #{0}:", i + 1);
            ls[i].Name = Console.ReadLine();
            Console.Write("Enter marks of student #{0}:", i + 1);
            ls[i].Marks = float.Parse(Console.ReadLine());
        }

        Array.Sort(ls, new sortByMarksNameDesc());

        Console.WriteLine("OUTPUT:");
        Console.WriteLine("List of students sorted by marks ascending, name descending:");
        foreach (Student s in ls)
            Console.WriteLine(s);

        Console.ReadKey();
    }

}