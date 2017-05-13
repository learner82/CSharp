using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    public interface IUserReader
    {
        string GetStringFromUser(string PromptMessage);
        string GetInstantLetterInput(string PromptMessage);
    }
}
