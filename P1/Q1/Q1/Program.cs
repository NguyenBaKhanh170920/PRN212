// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args)
    {
        float marks;
        Utility u = new Utility();
        marks = u.GetFloat("Enter marks (0-10):", 0, 10);
        Console.WriteLine("OUTPUT");
        Console.WriteLine($"Marks = {marks}");
        Console.ReadLine();

    }

}