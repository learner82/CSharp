using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceDemo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice Dice = new Dice();

            int Number = 0;
            while (Number != 1000)
            {
                Console.Write("Give me a number between 1 and 6:");
                string NumberStr = Console.ReadLine();
                Number = Int32.Parse(NumberStr);
                if (Number != 1000) 
                {
                    Dice.Throw(Number);
                    Console.WriteLine(Dice.Success ? "WON :)" : "LOST :(");
                }
            }
           
        }
    }
}
