// See https://aka.ms/new-console-template for more information
using Q3;
using System.Text.RegularExpressions;

internal class Utility : IUility
{
    public float GetFloat(string msg, float min, float max)
    {
        while (true)
        {
            Console.Write(msg);
            string input = Console.ReadLine();
            if (float.TryParse(input, out float value))
            {
                if (value >= min && value <= max)
                {
                    return value;
                }
            }
        }
    }

    public string GetString(string msg, string pattern)
    {
        while (true)
        {
            Console.Write(msg);
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(input))
            {
                return input;
            }

        }
    }
}