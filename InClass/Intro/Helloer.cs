using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    public class Helloer
    {
        public string message;

        public Helloer(string message)
        {
            this.message = message;
        }
    }



    public static class HelloerStatic
    {
        public static string message;
    }

}