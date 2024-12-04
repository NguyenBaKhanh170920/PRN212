public class Utility
{
    internal float GetFloat(string v1, int v2, int v3)
    {
        try
        {
            Console.WriteLine(v1);
            float num = float.Parse(Console.ReadLine());
            if (num >= v2 && num <= v3)
                return num;
            return GetFloat(v1, v2, v3);
        }
        catch (Exception)
        {
            return GetFloat(v1, v2, v3);
        }
    }
}