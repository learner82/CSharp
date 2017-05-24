using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sxhmata
{
    class Program
    {
        static void Main(string[] args)
        {
            double d;
            Console.WriteLine("Give me the rad of the object");
            try
            {
                string dstr = Console.ReadLine();
                 d = Convert.ToDouble(dstr);
            }
            catch (Exception ){
                Console.WriteLine("I said a number!!!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Please choose what kind of object you have");
            Console.WriteLine("1. For Circle");
            Console.WriteLine("2. For Sphere");

            string choose = Console.ReadLine();
            Circle kuklos = new Circle(d);
            Sphere sfaira = new Sphere(d);

            if (choose == "1")
            {
                Console.WriteLine( kuklos.ToString());
            }
            else if (choose == "2")
            {
                Console.WriteLine(sfaira.ToString());
            }
            else 
            Console.WriteLine("Ti 8es apo thn zwh mou");
            Console.ReadKey();
        }
    }
    
}
