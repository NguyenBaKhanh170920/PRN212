namespace Q1
{
    public class Student
    {
        public int StudentID { get; set; } 
        public string StudentName { get; set; }
        public Student(int studentID, string studentName)
        {
            StudentID = studentID;
            StudentName = studentName;
        }
    }
}