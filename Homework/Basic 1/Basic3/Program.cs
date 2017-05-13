using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic3
{
    class Program
    {
        static void Main(string[] args)
        {

            double result = 1;
            bool end = false;

            Console.WriteLine("What opperand you want to use?");
            Console.WriteLine("______________________________");
            Console.WriteLine("1. To add the numbers.");
            Console.WriteLine("2. To substract the numbers.");
            Console.WriteLine("3. To multiply the numbers.");
            Console.WriteLine("4. To divide the numbers.");

            string choise = Console.ReadLine();

            if (choise == "1" || choise == "2") result = 0;
            if (choise == "3" || choise == "4") result = 1;



            int idx = 1;
            while (!end)
            {
                double current = GetNumber(idx);
                if (current != 0)
                {
                    switch (choise)
                    {
                        case "1": result = result + current;
                            break;
                        case "2": result = result - current;
                            break;
                        case "3": result = result * current;
                            break;
                        case "4": result = result / current;
                            break;
                        default: throw new ApplicationException("Unknown");
                            
                    }
                    
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
