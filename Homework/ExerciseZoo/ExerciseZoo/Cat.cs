using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseZoo
{
    public class Cat : Animal
    {
        
        public Cat(int age, string kind, Gender fulo) : base(age, kind, fulo)
        {
            sound = "miaou";
            genna = Birth.inAHouse;
        }
    }
}
