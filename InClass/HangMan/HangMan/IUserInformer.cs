using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    public interface IUserInformer
    {
        void ShowState(List<string> CurrentWordFound, List<string> LettersTried, int Lives);
        void ShowMessage(string message);
    }
}
