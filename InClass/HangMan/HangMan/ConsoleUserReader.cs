using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    public class ConsoleUserReader:IUserReader
    {
        public string GetStringFromUser(string PromptMessage)
        {
            Console.Write(PromptMessage);
            return Console.ReadLine();
        }

        public string GetInstantLetterInput(string PromptMessage)
        {
            Console.Write(PromptMessage);
            return Console.ReadKey().Key.ToString().ToUpper();
        }
    }
}
