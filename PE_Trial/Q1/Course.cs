using System;
using System.Collections.Generic;

namespace Q1
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseTitle { get; set; }
        public Dictionary<Student, double> Students { get; set; } = new Dictionary<Student, double>();

        private int studentCount;
        public event Action<int, int> OnNumberOfStudentChange;

        public Course(int courseID, string courseTitle)
        {
            CourseID = courseID;
            CourseTitle = courseTitle;
            studentCount = 0;
        }

        public void AddStudent(Student p, double g)
        {
            if (!Students.ContainsKey(p))
            {
                int oldCount = studentCount;
                Students.Add(p, g);
                studentCount = Students.Count;
                OnNumberOfStudentChange?.Invoke(oldCount, studentCount);
            }
        }

        public void RemoveStudent(int studentId)
        {
            foreach (var s in Students.Keys)
            {
                if (s.StudentID == studentId)
                {
                    int oldCount = studentCount;
                    Students.Remove(s);
                    studentCount = Students.Count;
                    OnNumberOfStudentChange?.Invoke(oldCount, studentCount);
                    break;
                }
            }
        }

        public override string ToString()
        {
            string result = $"Course ID: {CourseID}, Title: {CourseTitle} \n";
            foreach (var student in Students)
            {
                result += "Students: " +$"{ student.Key.StudentID} - {student.Key.StudentName} - Grade: {student.Value}\n";
            }
            return result;
        }
    }
}
