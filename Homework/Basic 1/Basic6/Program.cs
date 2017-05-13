using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic6
{
    class Program
    {
        static void Main(string[] args)
        {

            Min Finder = new Min();
            Finder.AddNumber(55);
            Finder.AddNumber(-12);

            Console.WriteLine($"The minimum number is : {Finder.GetMin()} ");

            Console.ReadKey();
        }
    }
}
