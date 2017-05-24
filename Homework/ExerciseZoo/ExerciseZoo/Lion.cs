using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseZoo
{
    class Lion : Animal
    {
        public Lion(int age, string kind, Gender fulo) : base(age, kind, fulo)
        {
            sound = "Graou";
            genna = Birth.inZoo;
        }
    }
}
