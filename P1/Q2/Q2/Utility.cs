// See https://aka.ms/new-console-template for more information
internal class Utility
{
    public string GetString(string v, string pattern)
    {
        Console.WriteLine(v);
        string input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            {
                if (input.Length == 8 && input.StartsWith("HE") && input.Substring(2).All(char.IsDigit)
                    && v.Contains("ID"))
                {
                    return input;
                }
                else if (v.Contains("name"))
                {
                    return input;
                }
            }
            return GetString(v, "");
        }
        return GetString(v, "");
    }
}