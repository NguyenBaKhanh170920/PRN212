// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();
        Utility utility = new Utility();
        s.Id = utility.GetString("Enter ID (HE123456):", @"^[H][E]\d{6}$");
        s.Name = utility.GetString("Enter name (not empty):", @"\S+");
        s.Marks = utility.GetFloat("Enter marks (from 0 to 10):", 0, 10);

        Console.WriteLine("OUTPUT:");
        Console.WriteLine(s);
        Console.ReadKey();
    }

}
