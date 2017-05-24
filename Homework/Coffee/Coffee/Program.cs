using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseCoffee
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee c1 = new Coffee(Coffee.coffeeSize.large);
            Console.WriteLine(c1);



            string input;
            input = Console.ReadLine();


            Order prwth = new Order();
            prwth.Add(new Coffee(Coffee.coffeeSize.large));
            prwth.Add(new Coffee(Coffee.coffeeSize.small));
            prwth.Add(c1);

            Console.WriteLine(prwth.calculateCost());
            



            Console.ReadKey();
        }











        
    }
}
