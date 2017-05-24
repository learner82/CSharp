using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseZoo
{
    class Cow : Animal
    {
        public Cow(int age, string kind, Gender fulo) : base(age, kind, fulo)
        {
            sound = "mouououou";

        }
    }
}
