using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseZoo
{
    public class Zoo
    {
        List<Animal> park;

        public Zoo(string name)
        {
            var Name = name;
            park = new List<Animal>();
        }

        public void Add(Animal a)
        {
            park.Add(a);
        }

        public void sortpark()
        {
            park.Sort();
        }





        public string zooString()
        {
            string result = "";
            foreach (Animal s in park)
            {
                result += s.ToString() + "\n";
            }
            return result;
        }
    }
}


   

