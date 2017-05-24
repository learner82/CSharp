using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseZoo
{
    class Snake : Animal
    {
        public Snake(int age, string kind, Gender fulo) : base(age, kind, fulo)
        {
            sound = "xssssss";
        }
    }
}
