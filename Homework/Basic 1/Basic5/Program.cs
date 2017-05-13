using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> demo = new List<double>()
            {
                11,25,35,35668,1154,659,444,110,3,64,1,-5
            };

            double smaller = double.MaxValue;
            foreach (double s in demo)
                if (s < smaller) smaller = s;

            Console.WriteLine($"This is the smaller: {smaller}");
            Console.ReadKey();

        }
    }
}
