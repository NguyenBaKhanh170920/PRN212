using Q3;

class Program
{
    static void Main(string[] args)
    {
        List<Student> list = new List<Student>();
        StreamReader sr = new StreamReader("C:\\CSharp\\ListStudents.txt");
        string line;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        while ((line = sr.ReadLine()) != null)
        {
            Console.WriteLine(line);
            string[] tokens = line.Split('\t');
            list.Add(new Student
            {
                StudentNumber = int.Parse(tokens[0]),
                ClassId= tokens[1],
                StudentName = tokens[2],
                Marks=float.Parse(tokens[3]),
            });
        }
        Console.WriteLine("OUTPUT");
        var ls = list.GroupBy(x => x.ClassId).Select(s => new
        {
            Key = s.Key,
            Count = s.Count(),
            Average=s.Average(s=>s.Marks),
        }).OrderBy(s => s.Key);


        foreach (var group in ls)
            Console.WriteLine($"ClassId = {group.Key}, Count = {group.Count}, Average marks = {group.Average:N1}");


        Console.ReadLine();
    }

}