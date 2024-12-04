using System;
using System.Collections.Generic;

namespace Q2
{

    class Program
    {
        private static void Examinee_LowMarks(string name, double marks)
            => Console.WriteLine("Marks of examinee {0} = {1} - Failed.", name, marks);

        static void Main(string[] args)
        {
            List<Examinee> examinees = new List<Examinee>();
            int no;
            Console.Write("Enter the number of students:");
            no = int.Parse(Console.ReadLine());

            string name;
            double marks;
            Console.WriteLine("OUTPUT:");
            for (int i = 0; i < no; i++)
            {
                Examinee examinee = new Examinee();
                examinee.LowMarks += Examinee_LowMarks;
                Console.Write($"Enter name of student # {i + 1}: ");
                name = Console.ReadLine();
                Console.Write($"Enter marks of student # {i + 1}: ");
                marks = double.Parse(Console.ReadLine());
                examinee.Name = name;
                examinee.Marks = marks;

                examinees.Add(examinee);
            }

            Console.Read();
        }
    }
}