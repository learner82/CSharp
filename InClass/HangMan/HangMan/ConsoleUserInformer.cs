using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    public class ConsoleUserInformer : IUserInformer
    {
        public void ShowState(List<string> CurrentWordFound, List<string> LettersTried, int Lives)
        {
            Console.WriteLine("");
            foreach (var letter in CurrentWordFound)
                Console.Write(letter+" ");
            Console.WriteLine("");
            Console.WriteLine("Already tried: ");
            foreach (var letter in LettersTried)
                Console.Write(letter + " ");

            Console.WriteLine($"Remaining lives: {Lives}");
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine("");
            Console.WriteLine(message);
        }
    }
}
