using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, x3;
            try { 

                x1 = GetNumber(1);
                x2 = GetNumber(2);
                x3 = GetNumber(3);
            }
            catch(Exception e)
            {
                Console.WriteLine("Some of the inputs was not in the correct form");
                Console.ReadKey();
                return;
            }

            double result =(x1+x2+x3);

            Console.WriteLine($"The result is: {result}");
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
