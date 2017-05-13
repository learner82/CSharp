using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.lib
{
    public class HelloerLibAccessors
    {
        private string _message;
        public string Message
        {
            get
            {
                return _message;
            }

            set
            {
                _message = value;
            }
        }

        public string MessageDefault { get; set; }
        public string MessagePrivateSet { get; private set; }

        public HelloerLibAccessors(string message)
        {
            this.Message = message;
        }

        public void ShowMessage()
        {
            Console.WriteLine(this.Message);
        }
    }
}
