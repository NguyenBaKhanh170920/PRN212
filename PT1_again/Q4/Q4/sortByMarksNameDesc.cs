namespace Q4
{
    internal class sortByMarksNameDesc : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            int compare = x.Marks.CompareTo(y.Marks);
            if (compare == 0)
            {
                return string.Compare(y.Name, x.Name);
            }
            return compare;
        }
    }
}
