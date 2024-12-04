using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Examinee
    {
        public string Name {  get; set; }
        private double marks;
        public double Marks
        {
            get => marks;
            set
            {
                marks = value;
                if (marks < 20)
                {
                    LowMarks?.Invoke(Name, marks);
                }
            }
        }

        // Delegate and Event
        public delegate void LowMarksEventHandler(string name, double marks);
        public event LowMarksEventHandler LowMarks;
    }
}
