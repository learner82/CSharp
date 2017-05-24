using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseZoo
{
    public class Animal:IComparable<Animal>
    {
        public enum Gender { Male, Female }
        public string sound;
        public int Age { get; set; }    
        public string Kind { get; set; }
        public Gender Fulo;
        public enum Birth {inZoo, inWild, inAHouse}
        public Birth genna;


        public Animal()
        {
            Age = 0;
            Kind = "-";
            Fulo = Gender.Male;
        }
        public Animal( int age, string kind, Gender fulo)
        {
            this.Age = age;
            this.Kind = kind;
            fulo = Gender.Male;
        }

        
            public virtual string Sound (string Sound)
        {
            this.sound=Sound;
            return Sound;
        }

        public int CompareTo(Animal other)
        {
            if (this.Age > other.Age)
            {
                return +1;
            }
            else if (this.Age > other.Age)
            {
                return -1;
            }
            else
                return 0;

        }
        public override string ToString()
        {
            return $"This is a {Kind} and sounds like {sound}. Its {Age} years old ";
        }
    }
}
