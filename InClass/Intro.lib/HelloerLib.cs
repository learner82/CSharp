using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.lib
{
    public class HelloerLib
    {
        public string message;

        public HelloerLib(string message)
        {
            this.message = message;
        }

        public void ShowMessage()
        {
            Console.WriteLine(this.message);
        }
    }
}
