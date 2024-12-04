namespace Q4
{
    internal class Student
    {
        public string Name { get; set; }
        public float Marks { get; set; }
        public override string ToString()
        {
            return Name + "-" + Marks;
        }
    }
}
