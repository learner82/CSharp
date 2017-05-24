using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction g1 = new Fraction(8, 5);
            Fraction g2 = new Fraction(30, 42);
            Fraction g3 = new Fraction(19,33);
            Console.WriteLine(g1);

            Fraction g4 = g1 * g2;
            Fraction g5 = g2 * g1;
            Fraction g6 = g1 *7;
            Fraction g7 = g1 * g2*g4*g6*9;
            Console.WriteLine(g7);

            Console.WriteLine(g7.d);

            Fraction g8 = Fraction.Parse("2/5");

            List<Fraction> katse = new List<Fraction>() { g1, g2, g3, g4, g5, g6, g7, g8, new Fraction(2, 10) };

            Console.WriteLine("Before we sort \n");
            
            foreach (Fraction c in katse)
            {
                Console.WriteLine(c);
            }
            katse.Sort();
            Console.WriteLine("After the  sort \n");

            foreach (Fraction c in katse)
            {
                Console.WriteLine(c);
            }

            Fraction.Parsemulti("4/20,5/2,3/5");
            g7.cancel();
            Console.WriteLine(g7);

            Console.ReadKey();
        }
    }
}
