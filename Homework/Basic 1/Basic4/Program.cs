using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, x3;
            try
            {

                x1 = GetNumber(1);
                x2 = GetNumber(2);
                x3 = GetNumber(3);
            }
            catch (Exception e)
            {
                Console.WriteLine("Some of the inputs was not in the correct form");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("What opperand you want to use?");
            Console.WriteLine("______________________________");
            Console.WriteLine("1. To add the numbers.");
            Console.WriteLine("2. To substract the numbers.");
            Console.WriteLine("3. To multiply the numbers.");
            Console.WriteLine("4. To divide the numbers.");

            string choise = Console.ReadLine();

            Basic4 op= new Basic4(x1, x2, x3);

            switch (choise)
            {
                case "1" : op.Add();
                    break;
                case "2":
                    op.Subtrack();
                    break;
                case "3":
                    op.Multiply();
                    break;
                case "4":
                    op.Divide();
                    break;
                    
            }
            Console.WriteLine($"The result is: {op.Result}");
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
