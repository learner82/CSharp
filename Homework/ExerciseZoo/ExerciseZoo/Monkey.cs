using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseZoo
{
    class Monkey : Animal
    {
        public Monkey(int age, string kind, Gender fulo) : base(age, kind, fulo)
        {
            sound = "oug";
            genna = Birth.inWild;
        }
    }
}
