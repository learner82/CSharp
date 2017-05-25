using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseUniversity
{
    public class Student
    {
        public string Name { get; private set; }
        public double Grade { get; private set; }

        public Student(string name)
        {
            Name = name;
        }
    }
}
