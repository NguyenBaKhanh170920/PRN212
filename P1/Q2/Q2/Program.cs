// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        Utility u = new Utility();
        string id;
        string name;
        string pattern = "@\"HE\\d{6}";
        id = u.GetString("Enter ID (HE123456):", "");
        name = u.GetString("Enter name (NOT EMPTY):", "");
        Console.WriteLine("OUTPUT");
        Console.WriteLine($"ID = {id}");
        Console.WriteLine($"Name = {name}");
        Console.ReadLine();
    }

}
