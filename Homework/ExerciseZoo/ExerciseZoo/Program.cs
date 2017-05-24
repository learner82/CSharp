using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo("Zappeio");

            zoo.Add(new Cat(10, "Bill", Animal.Gender.Male));
            zoo.Add(new Cat(8, "King", Animal.Gender.Male));
            zoo.Add(new Cow(15, "Lucy", Animal.Gender.Female));
            zoo.Add(new Monkey(13, "Kong", Animal.Gender.Male));
            zoo.Add(new Lion(6, "Kitty", Animal.Gender.Female));
            zoo.Add(new Snake(3, "Python", Animal.Gender.Male));

            Console.WriteLine(zoo.zooString());
            zoo.sortpark();
            Console.WriteLine(zoo.zooString());

            Console.ReadKey();

        }
    }
}
