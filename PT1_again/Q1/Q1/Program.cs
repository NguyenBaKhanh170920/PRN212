class Program
{
    static void Main(string[] args)
    {
        string[] msg = { "Apple", "Mango", "Guava" };
        Console.Write("Enter a fruit name to search:");
        string search = Console.ReadLine();
        ref string fruit = ref find(search, msg);
        Console.Write("Enter a fruit name to replace:");
        string replace = Console.ReadLine();
        if (fruit == search) fruit = replace;
        Console.WriteLine("OUTPUT:");
        Console.WriteLine(string.Join(" ", msg));
        Console.ReadLine();
    }
    static ref string find(string s, string[] ls)
    {
        for (int i = 0; i < ls.Length; i++)
        {
            if (ls[i] == s)
            {
                return ref ls[i];
            }
        }
        return ref ls[0];
    }
}