using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseComplex
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Complex complex = new Complex();
            string input;
            double Re1;
            double Im1;
            double Re2;
            double Im2;

            do
            {
                Console.Write("Give me the real part of a complex number:");
            } while (!double.TryParse(Console.ReadLine(), out Re1));


            do
            {
                Console.Write("Give me the imaginary part of a complex number:");
            } while (!double.TryParse(Console.ReadLine(), out Im1));
            Complex z = new Complex(Re1, Im1);

            do
            {
                Console.Write("Give me the real part of a complex number:");
            } while (!double.TryParse(Console.ReadLine(), out Re2));


            do
            {
                Console.Write("Give me the imaginary part of a complex number:");
            } while (!double.TryParse(Console.ReadLine(), out Im2));
            Complex w = new Complex(Re2, Im2);





            Console.Write("What do you want me to do add(type add), substract(type sub), divide (type div) or multiply(type multi) the two complex numbers");
            input = Console.ReadLine();
            var result = new Complex();

            if (input.Equals("add"))
            {
                 result = Complex.Add(z, w);

            }
            else if (input.Equals("sub"))
            {
                 result = z-w;
            }
            else if (input.Equals("div"))
            {
                 result = Complex.divide(z, w);
            }
            else if (input.Equals("multi"))
            {
                 result =  z*w;
            }
            Console.WriteLine( result);

            Console.ReadKey();
        }
    
    }
}
