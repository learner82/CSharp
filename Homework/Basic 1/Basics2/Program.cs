using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics2
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 1;
            bool end = false;

            int idx = 1;
            while (!end)
            {
                double current = GetNumber(idx);
                if (current != 0)
                {
                    result = result * current;

                    idx++;

                }
                else
                    end = true;
                Console.WriteLine("The current result is: " + result);

            }
            Console.ReadKey();

        }

        static double GetNumber(double idx)
        {

            Console.WriteLine($"Give me number {idx}:");
            string xstr = Console.ReadLine();
            double x = Convert.ToDouble(xstr);

            return x;
        }
    }
}
