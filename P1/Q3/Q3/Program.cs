class Program
{
    static void Main(string[] args)
    {
        string[] msg = { "Apple", "Mango", "Guava", "Orange" };
        ref string fruit = ref find("Guava", msg);
        Console.Write("Enter a fruit name:");
        string s = Console.ReadLine();
        fruit = s;
        Console.WriteLine("OUTPUT:");
        Console.WriteLine(string.Join(" ", msg));
        Console.ReadLine();

    }
    static ref string find(string s, string[] ls)
    {
        for (int i = 0; i < ls.Length; i++)
        {
            if (ls[i].Contains(s))
            {
                return ref ls[i];
            }
        }
        throw new ArgumentException("The specified fruit was not found in the list.");
    }
}